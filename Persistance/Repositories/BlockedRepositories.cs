﻿using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistance.Repositories
{
    public class BlockedRepository : BaseRepository<Blocked>
    {
        public BlockedRepository(IdentityDbContext dbContext) : base(dbContext)
        {
        }
    }
}
