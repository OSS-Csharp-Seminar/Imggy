using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
        public DateTime DateOfCreation { get; set; }
        public List<Album_Post> Album_Post { get; set; }
        public List<PostLikes> PostLikes { get; set; }
        public List<Post_Tag> Post_Tag { get; set; }
    }
}
