using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Album
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string Name { get; set; }
        public bool IsPublic { get; set; }
        public DateTime DateOfCreation { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}
