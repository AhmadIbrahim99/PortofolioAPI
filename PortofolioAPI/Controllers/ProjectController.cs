using Core.Manager.Interface;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PortofolioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : BaseController<Project>
    {
        public ProjectController(IProjectManager manager) : base(manager)
        {
        }
    }
}
