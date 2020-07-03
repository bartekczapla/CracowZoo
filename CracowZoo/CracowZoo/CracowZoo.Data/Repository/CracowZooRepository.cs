using CracowZoo.Interfaces;
using CracowZoo.Models.Aditionals;
using CracowZoo.PlatformCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using static CracowZoo.Helpers.LinqExtensions;

namespace CracowZoo.Data.Repository
{
    public class CracowZooRepository: IRepository
    {
        private readonly CracowZooDbContext _dbContext;
        private readonly IPlatformSettingsProvider _platformSettingsProvider;

       public CracowZooRepository(IPlatformSettingsProvider platformSettingsProvider)
       {
            _platformSettingsProvider = platformSettingsProvider;
            _dbContext = new CracowZooDbContext(_platformSettingsProvider.ConnectionString);
       }

        protected virtual IQueryable<TEntity> Set<TEntity>() where TEntity : class
        {
            return _dbContext.Set<TEntity>();
        }

        public async Task<TEntity> AddAsync<TEntity>(TEntity entity) where TEntity : class
        {
            var ent = _dbContext.Set<TEntity>().Add(entity);

            foreach (var navigation in ent.Navigations)
            {
                navigation.Load();
            }

            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> DeleteAsync<TEntity>(int id) where TEntity : class
        {
            var entity = await _dbContext.Set<TEntity>().FindAsync(id);
            if (entity == null)
            {
                return null;
            }

            _dbContext.Set<TEntity>().Remove(entity);
            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<TEntity> GetAsync<TEntity>(Expression<Func<TEntity, bool>> whereExpression) where TEntity : class
        {
            var many = await GetManyAsync(whereExpression);

            return many.SingleOrDefault();
        }

        public async Task<IEnumerable<TEntity>> GetManyAsync<TEntity>(Expression<Func<TEntity, bool>> whereExpression = null, OrderElementDescription orderElementDescriptor = null, IEnumerable<string> includes = null) where TEntity : class
        {
            IQueryable<TEntity> result = _dbContext.Set<TEntity>().AsNoTracking();

            if (whereExpression != null)
            {
                result = result.Where(whereExpression);
            }

            if (orderElementDescriptor != null)
            {
                result = result.OrderBy(orderElementDescriptor);
            }

            if (includes != null)
            {
                foreach (string include in includes)
                {
                    result = result.Include(include);

                }
            }
      
            return await result.ToListAsync();
        }

        public async Task<TEntity> UpdateAsync<TEntity>(TEntity entity) where TEntity : class
        {
            var entry = _dbContext.Entry(entity);
            entry.State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task SaveAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
