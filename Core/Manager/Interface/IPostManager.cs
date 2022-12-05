using DAL.DTO.DTORequest;
using DAL.DTO.DTOResponse;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Manager.Interface
{
    public interface IPostManager :
        IBaseManager<Post, PostDTOResponse, PostDTORequest, PostCreateDTORequest>
    {
    }
}
