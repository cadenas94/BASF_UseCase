using AutoMapper;
using BASF_UseCase.Entities;
using BASF_UseCase.Models;

namespace BASF_UseCase.Services
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {

            //CreateMap<Material, MaterialListViewModel>();//.ForMember(dto => dto.MaterialList, ent => ent.MapFrom(prop => prop..Select(s => s.Cine)))
            CreateMap<Material, MaterialViewModel>();
            CreateMap<List<Material>, MaterialListViewModel>()
                .ForMember(dest => dest.MaterialList, opt => opt.MapFrom(src => src));

        }
    }
}
