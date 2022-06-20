using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Dtos
{
    public class PostDto
    {
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        //link za sliku treba biti ovdi
        public string Picture { get; set; }
        public DateTime DateOfCreation { get; set; }
        public int TagId { get; set; }
    }
}
