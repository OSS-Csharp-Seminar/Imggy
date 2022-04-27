using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Blocked
    {
        public int id { get; set; }
        public int blockerId { get; set; }
        public User blocker { get; set; }
        public int blockingId { get; set; }
        public User blocking { get; set; }
    }
}
