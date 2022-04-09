using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{
    public class Tag
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Post> posts { get; set; }
    }
}
