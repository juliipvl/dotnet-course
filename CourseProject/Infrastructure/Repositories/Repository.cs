using Core.IRepositories;
using Core.Models;

namespace Infrastructure.Repositories
{
    public class Repository<TEntity>: IRepository<TEntity> where TEntity : BaseModel
    {
        private readonly JsonService _jsonService;
        private readonly string _fileName;
        private List<TEntity> _cache;
        private bool _isCacheLoaded = false;

        public Repository(JsonService jsonService, string fileName)
        {
            _jsonService = jsonService;
            _fileName = fileName;
        }

        private async Task EnsureFileExistsAsync()
        {
            if (!_jsonService.Exists(_fileName))
            {
                await _jsonService.WriteAsync(_fileName, new List<TEntity>());
            }
        }

        private async Task LoadCacheAsync()
        {
            if (_isCacheLoaded) return;

            await EnsureFileExistsAsync();

            _cache = await _jsonService.ReadAsync<List<TEntity>>(_fileName) ?? new List<TEntity>();
            _isCacheLoaded = true;
        }

        private async Task SaveChangesAsync()
        {
            await _jsonService.WriteAsync(_fileName, _cache);
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            await LoadCacheAsync();
            return new List<TEntity>(_cache);
        }

        public async Task<TEntity> GetByIdAsync(Guid id)
        {
            await LoadCacheAsync();
            return _cache.FirstOrDefault(x => x.Id == id);
        }

        public async Task AddAsync(TEntity entity)
        {
            await LoadCacheAsync();
            if (entity.Id == Guid.Empty)
            {
                entity.Id = Guid.NewGuid();
            }
            _cache.Add(entity);
            await SaveChangesAsync();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            await LoadCacheAsync();
            var index = _cache.FindIndex(x => x.Id == entity.Id);
            if (index >= 0)
            {
                _cache[index] = entity;
                await SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(Guid id)
        {
            await LoadCacheAsync();
            var removed = _cache.RemoveAll(x => x.Id == id);
            if (removed > 0)
            {
                await SaveChangesAsync();
            }
        }

        public async Task ReloadAsync()
        {
            _isCacheLoaded = false;
            await LoadCacheAsync();
        }
    }
}