using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace XFiles.Ef
{
    public abstract class SqlRepository<T> where T : class
    {
        public SqlRepository(DbContext dbContext)
        {
            DbContext = dbContext;
            Entity = dbContext.Set<T>();
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await Entity
                .ToArrayAsync()
                .ConfigureAwait(false);
        }

        protected virtual async Task<T> UpdateAsync(T item)
        {
            DbContext.Entry(item).State = EntityState.Modified;
            await DbContext
                .SaveChangesAsync()
                .ConfigureAwait(false);
            return item;
        }

        protected virtual async Task<T> AddAsync(T item)
        {
            DbContext.Entry(item).State = EntityState.Added;
            await DbContext
                .SaveChangesAsync()
                .ConfigureAwait(false);
            return item;
        }

        protected virtual async Task DeleteAsync(T item)
        {
            DbContext.Entry(item).State = EntityState.Deleted;
            await DbContext
                .SaveChangesAsync()
                .ConfigureAwait(false);
        }

        public DbSet<T> Entity { get; set; }

        public DbContext DbContext { get; set; }
    }
}
