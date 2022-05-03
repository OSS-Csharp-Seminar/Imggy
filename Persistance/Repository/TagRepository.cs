using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistance.Repository
{
    public class TagRepository : BaseRepository<Tag>
    {
        public TagRepository(IdentityDbContext dbContext) : base(dbContext)
        {
        }
    }
}
