﻿using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistance.Repository
{
    public class AlbumRepository : BaseRepository<Album>
    {
        public AlbumRepository(IdentityDbContext dbContext) : base(dbContext)
        {
        }
    }
}
