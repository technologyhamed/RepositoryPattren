using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreApi.Repository
{
    public abstract class EfCoreRepository<TEntity, TContext> : IRepository<TEntity>
        where TEntity : class, IEntity
        where TContext : DbContext
    {
        private readonly TContext Context;
        public EfCoreRepository(TContext Context)
        {
            this.Context = Context;
        }
        public async Task<TEntity> Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
            await Context.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> Delete(int id)
        {
            var entity = await Context.Set<TEntity>().FindAsync(id);
            if (entity == null)
                return entity;
            Context.Set<TEntity>().Remove(entity);
            await Context.SaveChangesAsync();
            return entity;
        }

        public Task<List<TEntity>> GetAll()
        {
            return Context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetId(int id)
        {
            return await Context.Set<TEntity>().FindAsync(id);
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            await Context.SaveChangesAsync();
            return entity;
        }
    }
}
