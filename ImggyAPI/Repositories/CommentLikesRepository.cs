using DomainModel.Models;
using ImggyAPI.DatabaseContext;
using System.Collections.Generic;
using System.Linq;

namespace ImggyAPI.Repositories
{
    public class CommentLikesRepository
    {
        private readonly ImggyDBContext _imggyDbContext;

        public CommentLikesRepository(ImggyDBContext imggyDBContext)
        {
            _imggyDbContext = imggyDBContext;
        }

        public IEnumerable<CommentLikes> GetCommentLikes()
        {
            return _imggyDbContext.commentLikes.ToList();
        }
    }
}
