using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class AlbumPost
    {
        public int id { get; set; }
        public int albumId { get; set; }
        public Album album { get; set; }
        public int postId { get; set; }
        public Post post { get; set; }
    }
}
