using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImggyDomain.Entities
{
    public class User : IdentityUser
    {
        public DateTime dateOfCreation { get; set; }
        public List<PostLikes> postLikes { get; set; }
        public List<CommentLikes> commentLikes { get; set; }
    }
}
