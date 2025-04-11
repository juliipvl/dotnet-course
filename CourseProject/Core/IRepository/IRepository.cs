using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.IRepositories
{
    public interface IRepository<TEntity> 
    {
        List<TEntity> GetAll();

        TEntity GetById(Guid id);

        void Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(Guid id);
    }
}
