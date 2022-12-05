//using DAL.DTO.DTORequest;
//using DAL.DTO.DTOResponse;
//using DAL.Models;
//using Mapster;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Core.Mapper
//{
//    public class RegisterMapConfig : IRegister
//    {
//        public void Register(TypeAdapterConfig config)
//        {
//            config.NewConfig<Post, PostDTOResponse>().
//                Map(dest => dest.Name, src=> src.Title).
//                Map(dest => dest.Content, src=> src.Body).
//                Map(dest => dest.CreatedAt, src=> src.CreatedAt).
//                TwoWays();

//            config.NewConfig<Post, PostDTORequest>().
//                Map(dest => dest.Name, src=> src.Title).
//                TwoWays();

//            config.NewConfig<PostDTOResponse, PostDTORequest>().
//                Map(dest => dest.Name, src => src.Name).
//                TwoWays();


//            config.NewConfig<Project, ProjectDTOResponse>().
//                Map(dest => dest.Name, src => src.Title).
//                Map(dest => dest.Content, src => src.Body).
//                Map(dest => dest.CreatedAt, src => src.CreatedAt).
//                TwoWays();

//            config.NewConfig<Project, ProjectDTORequest>().
//                Map(dest => dest.Name, src => src.Title).
//                TwoWays();

//            config.NewConfig<ProjectDTOResponse, ProjectDTORequest>().
//                Map(dest => dest.Name, src => src.Name).
//                TwoWays();
//        }
//    }
//}
