using AutoMapper;

using Synergy.DataAccess.Dictionaries.Queries.Models;
using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Dictionaries.Queries.MapProfiles
{
    public class CampaignTypeMapProfile : Profile
    {
        public CampaignTypeMapProfile()
        {
            CreateMap<CampaignType, CampaignTypeModel>()
                .ForMember(d => d.CampaingSubType, src => src.MapFrom(s => s.ChaildTypes))
                .ForMember(d => d.Name, src => src.MapFrom(s => s.Description))
                ;
        }
    }
}
