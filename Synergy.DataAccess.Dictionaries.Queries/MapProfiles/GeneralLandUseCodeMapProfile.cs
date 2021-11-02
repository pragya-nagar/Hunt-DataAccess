using AutoMapper;

using Synergy.DataAccess.Abstractions.Models;
using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Dictionaries.Queries.MapProfiles
{
    public class GeneralLandUseCodeMapProfile : Profile
    {
        public GeneralLandUseCodeMapProfile()
        {
            CreateMap<GeneralLandUseCode, FastEntityModel<int>>();
        }
    }
}
