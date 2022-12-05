using AutoMapper;
using DAL.DTO.DTORequest;
using DAL.DTO.DTOResponse;
using DAL.Models;

namespace Core.Mapper
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Post, PostCreateDTORequest>().
                ForMember(x => x.Name, c => c.MapFrom(e => e.Title)).
                ReverseMap();

            CreateMap<Post, PostDTORequest>().
                ForMember(x=> x.Name, c=> c.MapFrom(e=> e.Title)).
                ForMember(x=> x.Content, c=> c.MapFrom(e=> e.Body)).
                ReverseMap();

            CreateMap<Post, PostDTOResponse>().
                ForMember(x => x.Name, c => c.MapFrom(e => e.Title)).
                ForMember(x => x.Content, c => c.MapFrom(e => e.Body)).
                ReverseMap();

            CreateMap<Project, ProjectDTORequest>().
                ForMember(x => x.Name, c => c.MapFrom(e => e.Title)).
                ForMember(x=> x.Content, c=> c.MapFrom(e=> e.Body)).
                ReverseMap();
            
            CreateMap<Project, ProjectCreateDTORequest>().
                ForMember(x => x.Name, c => c.MapFrom(e => e.Title)).
                ReverseMap();
            
            CreateMap<Project, ProjectDTOResponse>().
                ForMember(x => x.Name, c => c.MapFrom(e => e.Title)).
                ForMember(x => x.Content, c => c.MapFrom(e => e.Body)).
                ReverseMap();

        }
    }
}
