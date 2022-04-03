using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImggyDomain.Entities
{
    public class Tag
    {
        public Tag()
        {
            this.posts = new HashSet<Post>();
        }
        public int id { get; set; }
        public string name { get; set; }
        public virtual ICollection<Post> posts { get; set; }
    }
}
