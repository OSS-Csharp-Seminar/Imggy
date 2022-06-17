using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistance.Repository
{
    public class UserRepository : BaseRepository<User>
    {
        public UserRepository(IdentityDbContext dbContext) : base(dbContext)
        {
        }
    }
}
