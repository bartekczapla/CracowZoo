using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CracowZoo.DataAccess.Interfaces
{
    public interface IRepository<TEntity> where TEntity: class, IEntity
    {
        Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> whereExpression = null);

        Task<TEntity> GetByIdAsync(int id);

        Task<TEntity> AddAsync(TEntity entity);

        Task<TEntity> UpdateAsync(TEntity entity);

        Task<TEntity> DeleteAsync(int id);

        Task SaveAsync();
    }
}
