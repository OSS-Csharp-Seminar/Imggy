using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Follows
    {
        public int id { get; set; }
        public int followedId { get; set; }
        public User followed { get; set; }
        public int followingId { get; set; }
        public User following { get; set; }
    }
}
