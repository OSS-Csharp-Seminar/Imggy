using DomainModel.Models;
using ImggyAPI.DatabaseContext;
using System.Collections.Generic;
using System.Linq;

namespace ImggyAPI.Repositories
{
    public class FollowsRepository
    {
        private readonly ImggyDBContext _imggyDbContext;

        public FollowsRepository(ImggyDBContext imggyDBContext)
        {
            _imggyDbContext = imggyDBContext;
        }

        public IEnumerable<Follows> GetFollows()
        {
            return _imggyDbContext.follows.ToList();
        }
    }
}
