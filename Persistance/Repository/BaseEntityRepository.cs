﻿using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistance.Repository
{
    public class BaseEntityRepository : BaseRepository<BaseEntity>
    {
        public BaseEntityRepository(IdentityDbContext dbContext) : base(dbContext)
        {
        }
    }
}