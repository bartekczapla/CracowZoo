using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CracowZoo.DataAccess.Interfaces
{
    public interface IRepository<T> where T: class, IEntity
    {
        Task<IEnumerable<T>> Get(Expression<Func<T, bool>> whereExpression = null);

        Task<T> GetById(int id);

        Task<T> Add(T entity);

        Task<T> Update(T entity);

        Task<T> Delete(int id);

        Task Save();
    }
}
