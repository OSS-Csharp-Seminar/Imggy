using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User : IdentityUser
    {
        public DateTime DateOfCreation { get; set; }
        public List<PostLikes> PostLikes { get; set; }
        public List<CommentLikes> CommentLikes { get; set; }
    }
}
