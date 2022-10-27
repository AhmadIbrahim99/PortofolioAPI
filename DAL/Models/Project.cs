using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Project : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;

    }
}
