using DomainModel.Models;
using ImggyAPI.DatabaseContext;
using System.Collections.Generic;
using System.Linq;

namespace ImggyAPI.Repositories
{
    public class TagRepository
    {
        private readonly ImggyDBContext _imggyDbContext;

        public TagRepository(ImggyDBContext imggyDBContext)
        {
            _imggyDbContext = imggyDBContext;
        }

        public IEnumerable<Tag> GetTags()
        {
            return _imggyDbContext.tags.ToList();
        }
    }
}
