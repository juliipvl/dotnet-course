using Core.Models;
using System.Text.Json;

namespace Infrastructure.Repositories
{
    public class Repository<TEntity> where TEntity : BaseModel
    {
        private readonly JsonService _jsonService;
        private readonly string _fileName;
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
            if (!_jsonService.Exists(_fileName))
            {
                _jsonService.Write(_fileName, new List<TEntity>());
            }
        }

        private void LoadCache()
        {
            if (_isCacheLoaded) return;

            _cache = _jsonService.Read<List<TEntity>>(_fileName) ?? new List<TEntity>();
            _isCacheLoaded = true;
        }

        private void SaveChanges()
        {
            _jsonService.Write(_fileName, _cache);
        }

        public List<TEntity> GetAll()
        {
            LoadCache();
            return new List<TEntity>(_cache);
        }

        public TEntity GetById(Guid id)
        {
            LoadCache();
            return _cache.FirstOrDefault(x => x.Id == id);
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
            var index = _cache.FindIndex(x => x.Id == entity.Id);
            if (index >= 0)
            {
                _cache[index] = entity;
                SaveChanges();
            }
        }

        public void Delete(Guid id)
        {
            LoadCache();
            var removed = _cache.RemoveAll(x => x.Id == id);
            if (removed > 0)
            {
                SaveChanges();
            }
        }

        public void Reload()
        {
            _isCacheLoaded = false;
            LoadCache();
        }
    }
}