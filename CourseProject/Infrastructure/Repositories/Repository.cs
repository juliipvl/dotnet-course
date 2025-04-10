using Core.Models;
using System.Text.Json;

namespace Infrastructure.Repositories
{
    public class Repository<TEntity> where TEntity : BaseModel
    {
        private readonly JsonService _jsonService;
        private string _fileName;
        private List<TEntity> _cache;
        private bool _isCacheLoaded = false;

        public Repository(JsonService jsonService, string fileName)
        {
            _jsonService = jsonService;
            _fileName = fileName;
            EnsureFileExists();
        }

        private void EnsureFileExists()
        {
            if (!File.Exists(_fileName))
            {
                File.WriteAllText(_fileName, "[]");
            }
        }

        private void LoadCache()
        {
            if (_isCacheLoaded) return;

            var json = File.ReadAllText(_fileName);
            _cache = JsonSerializer.Deserialize<List<TEntity>>(json) ?? new List<TEntity>();
            _isCacheLoaded = true;
        }

        private void SaveChanges()
        {
            var json = JsonSerializer.Serialize(_cache, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_fileName, json);
        }

        public List<TEntity> GetAll()
        {
            LoadCache();
            return new List<TEntity>(_cache);
        }

        public TEntity GetById(Guid id)
        {
            LoadCache();
            return _cache.FirstOrDefault(b => b.Id == id);
        }

        public void Add(TEntity entity)
        {
            LoadCache();

            if (entity.Id == Guid.Empty)
            {
                entity.Id = Guid.NewGuid();
            }

            _cache.Add(entity);
            SaveChanges();
        }

        public void Update(TEntity entity)
        {
            LoadCache();
            var index = _cache.FindIndex(b => b.Id == entity.Id);
            if (index >= 0)
            {
                _cache[index] = entity;
                SaveChanges();
            }
        }

        public void Delete(Guid id)
        {
            LoadCache();
            _cache.RemoveAll(b => b.Id == id);
            SaveChanges();
        }
    }
}