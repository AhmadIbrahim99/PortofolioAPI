using DAL.Data;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Manager.Interface;

namespace Core.Manager
{
    public class PostManager : BaseManager<Post> ,IPostManager
    {
        public PostManager(PortifolioDbContext context) : base(context)
        {
        }
    }
}
