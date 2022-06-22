using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public Comment Parent { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
        public string Body { get; set; }
        public DateTime DateOfCreation { get; set; }
        public List<CommentLikes> CommentLikes { get; set; }
    }
}
