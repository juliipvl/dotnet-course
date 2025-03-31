using Core.Models;

namespace Infrastructure.Repositories
{
    public abstract class Repository<TEntity> where TEntity : class, IEntity
    {
        private readonly JsonService _jsonService;
        private const string IndexFileName = "index.json";

        public Repository(JsonService jsonService)
        {
            _jsonService = jsonService;
            EnsureIndexFileExists();
        }

        public List<TEntity> GetAll()
        {
            var ids = LoadIndex();
            return ids.Select(GetById).Where(entity => entity != null).ToList();
        }

        public TEntity GetById(Guid id) => _jsonService.Read<TEntity>($"{id}.json");

        public void Add(TEntity entity)
        {
            var ids = LoadIndex();
            if (ids.Contains(entity.Id)) return;

            _jsonService.Write($"{entity.Id}.json", entity);
            ids.Add(entity.Id);
            SaveIndex(ids);
        }

        public void Update(TEntity entity)
        {
            if (!_jsonService.Exists($"{entity.Id}.json")) return;
            _jsonService.Write($"{entity.Id}.json", entity);
        }

        public void Delete(Guid id)
        {
            _jsonService.Delete($"{id}.json");
            var ids = LoadIndex();
            ids.Remove(id);
            SaveIndex(ids);
        }

        private void EnsureIndexFileExists()
        {
            if (!_jsonService.Exists(IndexFileName))
                _jsonService.Write(IndexFileName, new List<Guid>());
        }

        private List<Guid> LoadIndex() => _jsonService.Read<List<Guid>>(IndexFileName) ?? new List<Guid>();

        private void SaveIndex(List<Guid> index) => _jsonService.Write(IndexFileName, index);

    }
}