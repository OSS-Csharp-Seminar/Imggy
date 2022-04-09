using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{
    public class CommentLikes
    {
        public int id { get; set; }
        public int commentId { get; set; }
        public Comment comment { get; set; }
        public int userId { get; set; }
        public User user { get; set; }
    }
}
