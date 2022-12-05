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
    public class PostController : 
        BaseController<Post, PostDTOResponse, PostDTORequest, PostCreateDTORequest>
    {
        public PostController(IPostManager manager) : base(manager)
        {
        }

    }
}
