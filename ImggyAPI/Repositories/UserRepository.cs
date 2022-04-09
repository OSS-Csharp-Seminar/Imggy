using DomainModel.Models;
using ImggyAPI.DatabaseContext;
using System.Collections.Generic;
using System.Linq;

namespace ImggyAPI.Repositories
{
    public class UserRepository
    {
        private readonly ImggyDBContext _imggyDbContext;

        public UserRepository(ImggyDBContext imggyDBContext)
        {
            _imggyDbContext = imggyDBContext;
        }

        public IEnumerable<User> GetUsers()
        {
            return _imggyDbContext.users.ToList();
        }

    }
}
