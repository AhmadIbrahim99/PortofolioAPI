using AutoMapper;
using Core.Manager.Interface;
using DAL.Data;
using DAL.DTO.DTORequest;
using DAL.DTO.DTOResponse;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Manager
{
    public class ProjectManager :
        BaseManager<Project, ProjectDTOResponse, ProjectDTORequest, ProjectCreateDTORequest>
        , IProjectManager
    {
        public ProjectManager(PortifolioDbContext context, IMapper map) : base(context, map)
        {
        }
    }
}
