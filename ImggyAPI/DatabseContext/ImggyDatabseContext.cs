using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ImggyAPI.DatabseContext
{
    public class ImggyDatabseContext : DbContext
    {
        public ImggyDatabseContext(DbContextOptions<ImggyDatabseContext> dbContextOptions) : base(dbContextOptions)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AlbumPost>()
                .HasOne(a => a.Album)
                .WithMany(ap => ap.Album_Post)
                .HasForeignKey(p => p.PostId);

            modelBuilder.Entity<AlbumPost>()
                .HasOne(p => p.Post)
                .WithMany(ap => ap.Album_Post)
                .HasForeignKey(a => a.AlbumId);

            modelBuilder.Entity<PostTag>()
                .HasOne(p => p.Post)
                .WithMany(pt => pt.Post_Tag)
                .HasForeignKey(t => t.TagId);

            modelBuilder.Entity<PostTag>()
                .HasOne(t => t.Tag)
                .WithMany(pt => pt.Post_Tag)
                .HasForeignKey(p => p.PostId);

            modelBuilder.Entity<CommentLikes>()
                .HasOne(c => c.Comment)
                .WithMany(cl => cl.CommentLikes)
                .HasForeignKey(u => u.UserId);

            modelBuilder.Entity<CommentLikes>()
                .HasOne(u => u.User)
                .WithMany(cl => cl.CommentLikes)
                .HasForeignKey(c => c.CommentId);

            modelBuilder.Entity<PostLikes>()
                .HasOne(p => p.Post)
                .WithMany(pl => pl.PostLikes)
                .HasForeignKey(u => u.UserId);

            modelBuilder.Entity<PostLikes>()
                .HasOne(u => u.User)
                .WithMany(pl => pl.PostLikes)
                .HasForeignKey(p => p.PostId);
        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Blocked> Blocks { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<CommentLikes> CommentLikes { get; set; }
        public DbSet<Follows> Follows { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostLikes> PostLikes { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<AlbumPost> Albums_Posts { get; set; }
        public DbSet<PostTag> Posts_Tags { get; set; }
    }
}
