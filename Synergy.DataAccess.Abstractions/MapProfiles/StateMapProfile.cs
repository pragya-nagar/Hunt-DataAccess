using AutoMapper;

using Synergy.DataAccess.Abstractions.Models;
using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Abstractions.MapProfiles
{
    public class StateMapProfile : Profile
    {
        public StateMapProfile()
        {
            CreateMap<State, FastEntityModel<int>>()
                .ForMember(e => e.Id, t => t.MapFrom(src => src.Id))
                .ForMember(e => e.Name, t => t.MapFrom(src => src.Abbreviation))
                ;
        }
    }
}
