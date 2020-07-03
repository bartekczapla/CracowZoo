using CracowZoo.Models.Aditionals;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CracowZoo.Interfaces
{
    public interface IRepository
    {
        Task<IEnumerable<TEntity>> GetManyAsync<TEntity>(
            Expression<Func<TEntity, bool>> whereExpression = null,
            OrderElementDescription orderElementDescriptor = null
            )
            where TEntity : class;

        Task<TEntity> GetAsync<TEntity>(Expression<Func<TEntity, bool>> whereExpression = null)
            where TEntity : class;

        Task<TEntity> AddAsync<TEntity>(TEntity entity)
             where TEntity : class;

        Task<TEntity> UpdateAsync<TEntity>(TEntity entity)
             where TEntity : class;

        Task<TEntity> DeleteAsync<TEntity>(int id)
             where TEntity : class;

        Task SaveAsync();
    }
}
