using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Follows
    {
        public int Id { get; set; }
        public int? FollowedId { get; set; }
        public User Followed { get; set; }
        public int? FollowingId { get; set; }
        public User Following { get; set; }
    }
}
