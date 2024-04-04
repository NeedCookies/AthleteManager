using AutoMapper;
using backend.Core.Dtos.Competition;
using backend.Core.Dtos.Sport;
using backend.Core.Entities;
namespace backend.Core.AutoMapperConfig
{
    public class AutoMapperConfigProfile : Profile
    {
        public AutoMapperConfigProfile() 
        {
            CreateMap<SportCreateDto, Sport>();
            CreateMap<Sport, SportGetDto>();

            CreateMap<CompetitionCreateDto, Competition>();
            CreateMap<Competition, CompetitionGetDto>()
                .ForMember(c => c.SportName, opt => opt.MapFrom(src => src.Sport.Name));
        }
    }
}
