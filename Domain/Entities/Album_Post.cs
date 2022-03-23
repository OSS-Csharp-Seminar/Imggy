using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Album_Post
    {
        public int Id { get; set; }
        public int? AlbumId { get; set; }
        public Album Album { get; set; }
        public int? PostId { get; set; }
        public Album Post { get; set; }
    }
}
