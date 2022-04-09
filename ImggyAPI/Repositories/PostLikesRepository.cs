using DomainModel.Models;
using ImggyAPI.DatabaseContext;
using System.Collections.Generic;
using System.Linq;

namespace ImggyAPI.Repositories
{
    public class PostLikesRepository
    {
        private readonly ImggyDBContext _imggyDbContext;

        public PostLikesRepository(ImggyDBContext imggyDBContext)
        {
            _imggyDbContext = imggyDBContext;
        }

        public IEnumerable<PostLikes> GetPostLikes()
        {
            return _imggyDbContext.postLikes.ToList();
        }
    }
}
