using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PostTag
    {
        public int id { get; set; }
        public int postId { get; set; }
        public Post post { get; set; }
        public int tagId { get; set; }
        public Tag tag { get; set; }
    }
}
