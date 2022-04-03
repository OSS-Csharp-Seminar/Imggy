using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImggyDomain.Entities
{
    public class Album
    {
        public Album()
        {
            this.posts = new HashSet<Post>();
        }
        public int id { get; set; }
        public int userId { get; set; }
        public User user { get; set; }
        public string name { get; set; }
        public bool isPublic { get; set; }
        public DateTime dateOfCreation { get; set; }
        public virtual ICollection<Post> posts { get; set; }
    }
}
