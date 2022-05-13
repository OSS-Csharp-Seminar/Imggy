using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class AlbumPosts
    {
        public int AlbumId { get; set; }
        public Album Album { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
