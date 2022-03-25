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
        public DateTime dateOfCreation { get; set; }
        public List<PostLikes> postLikes { get; set; }
        public List<CommentLikes> commentLikes { get; set; }
    }
}
