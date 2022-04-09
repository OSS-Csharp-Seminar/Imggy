using DomainModel.Models;
using ImggyAPI.DatabaseContext;
using System.Collections.Generic;
using System.Linq;

namespace ImggyAPI.Repositories
{
    public class BlockedRepository
    {
        private readonly ImggyDBContext _imggyDbContext;

        public BlockedRepository(ImggyDBContext imggyDBContext)
        {
            _imggyDbContext = imggyDBContext;
        }

        public IEnumerable<Blocked> GetBlocks()
        {
            return _imggyDbContext.blocks.ToList();
        }
    }
}
