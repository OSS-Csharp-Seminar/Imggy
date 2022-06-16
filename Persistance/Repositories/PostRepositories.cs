using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistance.Repositories
{
    public class PostRepository : BaseRepository<Post>
    {
        public PostRepository(IdentityDbContext dbContext) : base(dbContext)
        {
        }
    }
}
