using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories
{
    public class BaseRepository<T> where T : class
    {
        protected readonly DbContext Db;
        protected readonly DbSet<T> DbSet;

        public BaseRepository(IdentityDbContext db)
        {
            Db = db;
            DbSet = Db.Set<T>();
        }

        public IQueryable<T> Query()
        {
            return this.DbSet;
        }

        public T Single(int id)
        {
            return this.DbSet.Find(id);
        }
        public async Task<T> SingleAsync(int id)
        {
            return await this.DbSet.FindAsync(id);
        }

        public void Persist(T entity)
        {
            DbSet.Add(entity);
        }
        public async Task PersistAsync(T entity)
        {
            await DbSet.AddAsync(entity);
        }

        public void Update(T entity)
        {
            DbSet.Update(entity);
        }

        public void Remove(T entity)
        { 
            DbSet.Remove(entity);
        }

        public void PersistRange(IEnumerable<T> entities)
        {
            DbSet.AddRange(entities);
        }

        public void Flush()
        {
            Db.SaveChanges();
        }

        public async Task FlushAsync()
        {
            await Db.SaveChangesAsync();
        }
    }
}
