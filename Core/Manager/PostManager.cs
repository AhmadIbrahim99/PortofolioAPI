using DAL.Data;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Manager.Interface;
using DAL.DTO.DTOResponse;
using DAL.DTO.DTORequest;
using AutoMapper;

namespace Core.Manager
{
    public class PostManager : 
        BaseManager<Post, PostDTOResponse, PostDTORequest, PostCreateDTORequest>
        , IPostManager
    {
        public PostManager(PortifolioDbContext context, IMapper map) 
            : base(context, map)
        {
        }

    }
}
