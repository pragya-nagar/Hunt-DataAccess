using AutoMapper;

using Synergy.DataAccess.Abstractions.Models;
using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Dictionaries.Queries.MapProfiles
{
    public class PropertyDisplayStrategyMapProfile : Profile
    {
        public PropertyDisplayStrategyMapProfile()
        {
            CreateMap<PropertyDisplayStrategy, FastEntityModel<int>>()
                .ForMember(d => d.Name, src => src.MapFrom(s => s.Description))
                ;
        }
    }
}
