using DomainModel.Models;
using ImggyAPI.DatabaseContext;
using System.Collections.Generic;
using System.Linq;

namespace ImggyAPI.Repositories
{
    public class PostRepository
    {
        private readonly ImggyDBContext _imggyDbContext;

        public PostRepository(ImggyDBContext imggyDBContext)
        {
            _imggyDbContext = imggyDBContext;
        }

        public IEnumerable<Post> GetPosts()
        {
            return _imggyDbContext.posts.ToList();
        }
    }
}
