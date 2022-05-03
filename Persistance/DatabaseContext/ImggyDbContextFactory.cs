using Persistance.DbInfrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.DatabaseContext
{
    class ImggyDbContextFactory : DesignTimeDbContextFactoryBase<ImggyDbContext>
    {
        protected override ImggyDbContext CreateNewInstance(DbContextOptions<ImggyDbContext> options)
        {
            return new ImggyDbContext(options);
        }
    }
}
