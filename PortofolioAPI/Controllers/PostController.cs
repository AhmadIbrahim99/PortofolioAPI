using Core.Manager.Interface;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PortofolioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : BaseController<Post>
    {
        public PostController(IPostManager manager) : base(manager)
        {
        }

    }
}
