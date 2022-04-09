using DomainModel.Models;
using ImggyAPI.DatabaseContext;
using System.Collections.Generic;
using System.Linq;

namespace ImggyAPI.Repositories
{
    public class CommentRepository
    {
        private readonly ImggyDBContext _imggyDbContext;

        public CommentRepository(ImggyDBContext imggyDBContext)
        {
            _imggyDbContext = imggyDBContext;
        }

        public IEnumerable<Comment> GetComments()
        {
            return _imggyDbContext.comments.ToList();
        }
    }
}
