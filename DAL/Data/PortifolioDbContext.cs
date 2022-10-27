using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data
{
    public class PortifolioDbContext : DbContext
    {
        public PortifolioDbContext(DbContextOptions<PortifolioDbContext> options)
            : base(options)
        {

        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Project> Projects { get; set; }
    }
}
