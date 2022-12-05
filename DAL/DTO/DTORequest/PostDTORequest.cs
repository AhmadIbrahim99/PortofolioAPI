using DAL.DTO.DTORequest.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO.DTORequest
{
    public class PostDTORequest : PostCreateDTORequest
    {
        public int Id { get; set; }
        public string Content { get; set; } = string.Empty;
    }
}
