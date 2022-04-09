using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{
    public class Comment
    {
        public int id { get; set; }
        public int? parentId { get; set; }
        public Comment Parent { get; set; }
        public int userId { get; set; }
        public User user { get; set; }
        public int postId { get; set; }
        public Post post { get; set; }
        public DateTime dateOfCreation { get; set; }
        public List<CommentLikes> commentLikes { get; set; }
    }
}
