using DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Interface
{
    public interface IBaseRepository<TEntity, TKey> where TEntity : class
    {
        EducationSystemContext Context { get; }

        Task<List<TEntity>> GetAllAsync();
        Task<TEntity> FindAsync(TKey id);
        Task<TEntity> AddAsync(TEntity entity);
        void Delete(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);

    }
}
