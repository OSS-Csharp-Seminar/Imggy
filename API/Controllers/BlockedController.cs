using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Persistance.Repositories;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlockedController : BaseController<Blocked>
    {
        public BlockedController(BlockedRepository Repository) : base(Repository)
        {
        }
    }
}
