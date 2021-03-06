using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Persistance.Repositories;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : BaseController<Post>
    {
        public PostController(PostRepository Repository) : base(Repository)
        {
        }
    }
}
