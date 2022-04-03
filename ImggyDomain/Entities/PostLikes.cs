using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImggyDomain.Entities
{
    public class PostLikes
    {
        public int id { get; set; }
        public int postId { get; set; }
        public Post post{ get; set; }
        public int userId { get; set; }
        public User user { get; set; }
    }
}
