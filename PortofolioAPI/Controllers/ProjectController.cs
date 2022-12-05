using Core.Manager.Interface;
using DAL.DTO.DTORequest;
using DAL.DTO.DTOResponse;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PortofolioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController :
        BaseController<Project, ProjectDTOResponse, ProjectDTORequest, ProjectCreateDTORequest>
    {
        public ProjectController(IProjectManager manager) : base(manager)
        {
        }
    }
}
