using System;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using WeatherApplication.Core.DataAccess.Abstract;
using WeatherApplication.Core.Entities.Concrete;

namespace WeatherApplication.Core.DataAccess.Concrete
{
    public class BaseRepository<TEntity, TContext> : IBaseInterface<TEntity>
        where TEntity: BaseEntity, new()
        where TContext: DbContext, new()
    {
        public async Task AddAsync(TEntity entity)
        {
            using (TContext context =new TContext())
            {
                var Added = context.Entry(entity);
                Added.State = EntityState.Added;
                await context.SaveChangesAsync();

            }
        }

        public async Task DeleteAsync(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var Deleted = context.Entry(entity);
                Deleted.State = EntityState.Deleted;
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>>? filter = null)
        {
            using (TContext context = new TContext())
            {
                if (filter == null)
                {
                    return await context.Set<TEntity>().ToListAsync();
                }
                else
                {
                    return await context.Set<TEntity>().Where(filter).ToListAsync();
                }
            }
        }

        public async Task<TEntity> GetById(int id)
        {
            using (TContext context = new TContext())
            {
                return await context.Set<TEntity>().FirstOrDefaultAsync(x=>x.Id==id);
            }
        }

        public async Task UpdateAsync(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var Update = context.Entry(entity);
                Update.State = EntityState.Modified;
                await context.SaveChangesAsync();
            }
        }
    }
}

