using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Post
    {
        public int PostId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PicturePath { get; set; }
        public DateTime DateOfCreation { get; set; }
        public ICollection<AlbumPosts> AlbumPosts { get; set; }
        public List<PostLikes> PostLikes { get; set; }
        public ICollection<PostTags> PostTags { get; set; }
    }
}
