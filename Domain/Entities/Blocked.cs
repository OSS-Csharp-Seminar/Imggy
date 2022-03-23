using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Blocked
    {
        public int Id { get; set; }
        public int? BlockerId { get; set; }
        public User Blocker { get; set; }
        public int? BlockingId { get; set; }
        public User Blocking { get; set; }
    }
}
