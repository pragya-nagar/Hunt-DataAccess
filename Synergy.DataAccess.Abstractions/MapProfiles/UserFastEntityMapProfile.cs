using System;
using AutoMapper;
using Synergy.DataAccess.Abstractions.Models;
using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Abstractions.MapProfiles
{
    public class UserFastEntityMapProfile : Profile
    {
        public UserFastEntityMapProfile()
        {
            CreateMap<User, FastEntityModel<Guid>>()
                  .ForMember(x => x.Id, exp => exp.MapFrom(x => x.Id))
                  .ForMember(x => x.Name, exp => exp.MapFrom(s => $"{s.FirstName} {s.LastName}"));
        }
    }
}
