using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Dtos
{
    internal class CommentDto
    {
        public int UserId { get; set; }
        public int PostId { get; set; }
        public DateTime DateOfCreation { get; set; }
        public string Body { get; set; }
    }
}
