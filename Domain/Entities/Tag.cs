using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Tag
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<PostTag> postTag { get; set; }
    }
}
