using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistance.Repository
{
    public class CommentLikesRepository : BaseRepository<CommentLikes>
    {
        public CommentLikesRepository(IdentityDbContext dbContext) : base(dbContext)
        {
        }
    }
}
