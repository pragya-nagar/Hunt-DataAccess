using AutoMapper;

using Synergy.DataAccess.Abstractions.Models;
using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Abstractions.MapProfiles
{
    public class InternalLandUseCodeMapProfile : Profile
    {
        public InternalLandUseCodeMapProfile()
        {
            CreateMap<InternalLandUseCode, FastEntityModel<int>>()
                .ForMember(d => d.Name, src => src.MapFrom(s => s.Description))
                ;
        }
    }
}
