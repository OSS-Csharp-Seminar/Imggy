using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Persistance.Repositories;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostLikesController : BaseController<PostLikes>
    {
        public PostLikesController(PostLikesRepository Repository) : base(Repository)
        {
        }
    }
}
