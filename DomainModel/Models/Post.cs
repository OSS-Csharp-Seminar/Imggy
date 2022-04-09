using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{
    public class Post
    {
        public int id { get; set; }
        public int userId { get; set; }
        public User user { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public byte[] picture { get; set; }
        public DateTime dateOfCreation { get; set; }
        public List<Album> albums { get; set; }
        public List<PostLikes> postLikes { get; set; }
        public List<Tag> tags { get; set; }
    }
}
