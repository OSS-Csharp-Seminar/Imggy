using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PostLikes
    {
        public int Id { get; set; }
        public int? PostId { get; set; }
        public Post Post{ get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }
        public bool IsLiked { get; set; }
    }
}
