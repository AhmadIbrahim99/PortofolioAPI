using DAL.DTO.DTORequest.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO.DTORequest
{
    public class PostCreateDTORequest : IBaseDTORequest
    {
        public string Name { get; set; } = string.Empty;
    }
}
