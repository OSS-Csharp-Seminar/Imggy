using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Dtos
{
    internal class PostDto
    {
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public DateTime DateOfCreation { get; set; }
        public int TagId { get; set; }
    }
}
