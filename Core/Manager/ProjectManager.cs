using Core.Manager.Interface;
using DAL.Data;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Manager
{
    public class ProjectManager : BaseManager<Project>, IProjectManager
    {
        public ProjectManager(PortifolioDbContext context) : base(context)
        {
        }
    }
}
