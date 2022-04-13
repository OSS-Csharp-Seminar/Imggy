using Microsoft.EntityFrameworkCore;
using Persistence.DbInfrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
