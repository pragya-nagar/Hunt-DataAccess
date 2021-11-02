using AutoMapper;

using Synergy.DataAccess.Abstractions.Models;
using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Abstractions.MapProfiles
{
    public class CampaignTypeMapProfile : Profile
    {
        public CampaignTypeMapProfile()
        {
            CreateMap<CampaignType, FastEntityModel<int>>()
                .ForMember(x => x.Name, t => t.MapFrom(x => x.Description))
                ;
        }
    }
}
