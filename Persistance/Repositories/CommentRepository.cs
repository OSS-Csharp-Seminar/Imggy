﻿using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistance.Repositories
{
    public class CommentRepository : BaseRepository<Comment>
    {
        public CommentRepository(IdentityDbContext dbContext) : base(dbContext)
        {
        }
    }
}
