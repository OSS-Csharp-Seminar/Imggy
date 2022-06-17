using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persistance.Repository
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

        public void Persist(T entity)
        {
            DbSet.Add(entity);
        }

        public void PersistRange(IEnumerable<T> entities)
        {
            DbSet.AddRange(entities);
        }

        public void Flush()
        {
            Db.SaveChanges();
        }

        public void FlushAsync()
        {
            Db.SaveChangesAsync();
        }
    }
}
