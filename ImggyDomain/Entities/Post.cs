using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImggyDomain.Entities
{
    public class Post
    {
        public Post()
        {
            this.albums = new HashSet<Album>();
            this.tags = new HashSet<Tag>();
        }
        public int id { get; set; }
        public int userId { get; set; }
        public User user { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public byte[] picture { get; set; }
        public DateTime dateOfCreation { get; set; }
        public ICollection<Album> albums{ get; set; }
        public List<PostLikes> postLikes { get; set; }
        public ICollection<Tag> tags { get; set; }
    }
}
