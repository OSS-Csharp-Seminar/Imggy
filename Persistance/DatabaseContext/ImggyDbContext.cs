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

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ImggyDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<AlbumPosts>()
                .HasKey(ap => new { ap.AlbumId, ap.PostId });
            modelBuilder.Entity<AlbumPosts>()
                .HasOne(ap => ap.Album)
                .WithMany(a => a.AlbumPosts)
                .HasForeignKey(ap => ap.AlbumId);
            modelBuilder.Entity<AlbumPosts>()
                .HasOne(ap => ap.Post)
                .WithMany(p => p.AlbumPosts)
                .HasForeignKey(ap => ap.PostId); 
            modelBuilder.Entity<PostTags>()
                 .HasKey(pt => new { pt.PostId, pt.TagId});
            modelBuilder.Entity<PostTags>()
                .HasOne(pt => pt.Post)
                .WithMany(p => p.PostTags)
                .HasForeignKey(pt => pt.PostId);
            modelBuilder.Entity<PostTags>()
                .HasOne(pt => pt.Tag)
                .WithMany(t => t.PostTags)
                .HasForeignKey(pt => pt.TagId);
        }
    }
}
