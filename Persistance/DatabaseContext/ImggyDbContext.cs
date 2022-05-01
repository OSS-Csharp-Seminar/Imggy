using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Persistence.DatabaseContext
{
    public class ImggyDbContext : Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityDbContext<User>
    {
        public ImggyDbContext(DbContextOptions<ImggyDbContext> options) : base(options)
        {

        }

        public override int SaveChanges()
        {
            var entities = ChangeTracker.Entries().Where(x => x.Entity is BaseEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entity in entities)
            {
                if (entity.State == EntityState.Added)
                {
                    ((BaseEntity)entity.Entity).CreatedAt = DateTime.UtcNow;
                }

                ((BaseEntity)entity.Entity).UpdatedAt = DateTime.UtcNow;
            }

            return base.SaveChanges();
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ImggyDbContext).Assembly);
            modelBuilder
                .Entity<Album>()
                .HasMany(a => a.Posts);
            modelBuilder
                .Entity<Post>()
                .HasMany(p => p.Albums);
            modelBuilder
                .Entity<Tag>()
                .HasMany(t => t.Posts);
            modelBuilder
                .Entity<Post>()
                .HasMany(p => p.Tags);
            base.OnModelCreating(modelBuilder);
        }

    }
}
