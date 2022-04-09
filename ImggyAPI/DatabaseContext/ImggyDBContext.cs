using DomainModel.Models;
using Microsoft.EntityFrameworkCore;

namespace ImggyAPI.DatabaseContext
{
    public class ImggyDBContext : DbContext
    {
        public ImggyDBContext(DbContextOptions<ImggyDBContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<User> users { get; set; }
        public DbSet<Tag> tags { get; set; }
        public DbSet<PostLikes> postLikes { get; set; }
        public DbSet<Post> posts { get; set; }
        public DbSet<Follows> follows { get; set; }
        public DbSet<CommentLikes> commentLikes { get; set; }
        public DbSet<Comment> comments { get; set; }
        public DbSet<Blocked> blocks { get; set; }
        public DbSet<Album> albums { get; set; }
    }
}
