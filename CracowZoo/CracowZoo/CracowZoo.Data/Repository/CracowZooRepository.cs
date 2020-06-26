using CracowZoo.DataAccess.Interfaces;
using CracowZoo.PlatformCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CracowZoo.Data.Repository
{
    public class CracowZooRepository<TEntity> : IRepository<TEntity> where TEntity: class, IEntity
    {
        private readonly CracowZooDbContext _dbContext;
        private readonly IPlatformSettingsProvider _platformSettingsProvider;

       public CracowZooRepository(IPlatformSettingsProvider platformSettingsProvider)
       {
            _platformSettingsProvider = platformSettingsProvider;
            _dbContext = new CracowZooDbContext(_platformSettingsProvider.ConnectionString);
       }


        public async Task<TEntity> Add(TEntity entity)
        {
            var ent = _dbContext.Set<TEntity>().Add(entity);

            foreach (var navigation in ent.Navigations)
            {
                navigation.Load();
            }

            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> Delete(int id)
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


        public async Task<IEnumerable<TEntity>> Get(Expression<Func<TEntity, bool>> whereExpression = null)
        {
            IQueryable<TEntity> result = _dbContext.Set<TEntity>();

            if (whereExpression != null)
            {
                result = result.Where(whereExpression);
            }

            return await result.ToListAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _dbContext.Set<TEntity>().FindAsync(id);
        }

        public Task Save()
        {
            return _dbContext.SaveChangesAsync();
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            var entry = _dbContext.Entry(entity);
            entry.State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return entity;
        }
    }
}
