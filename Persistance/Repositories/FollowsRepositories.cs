using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistance.Repositories
{
    public class FollowsRepository : BaseRepository<Follows>
    {
        public FollowsRepository(IdentityDbContext dbContext) : base(dbContext)
        {
        }
    }
}
