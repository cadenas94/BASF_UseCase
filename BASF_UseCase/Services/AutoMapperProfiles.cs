using AutoMapper;
using BASF_UseCase.Entities;
using BASF_UseCase.Models;

namespace BASF_UseCase.Services
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {

            //Definition of the mapping between the entitites and the DTOs
            CreateMap<Material, MaterialViewModel>();
            CreateMap<List<Material>, MaterialListViewModel>()
                .ForMember(dest => dest.MaterialList, opt => opt.MapFrom(src => src));

        }
    }
}
