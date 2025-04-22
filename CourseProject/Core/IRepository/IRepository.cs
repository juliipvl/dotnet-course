using Core.Models;
namespace Core.IRepositories
{
    public interface IRepository<TEntity> 
    {
        Task<List<TEntity>> GetAllAsync();

        Task<TEntity> GetByIdAsync(Guid id);

        Task AddAsync(TEntity entity);

        Task UpdateAsync(TEntity entity);

        Task DeleteAsync(Guid id);
    }
}
