using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistance.Repository
{
    public class FollowsRepository : BaseRepository<Follows>
    {
        public FollowsRepository(IdentityDbContext dbContext) : base(dbContext)
        {
        }
    }
}
