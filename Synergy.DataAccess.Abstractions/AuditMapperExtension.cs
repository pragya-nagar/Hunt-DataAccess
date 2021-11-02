using System;

using AutoMapper;

using Synergy.DataAccess.Abstractions.Models;
using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Abstractions
{
    public static class AuditMapperExtension
    {
        public static IMappingExpression<TSource, TDest> ApplyAuditMembers<TSource, TDest>(this IMappingExpression<TSource, TDest> expression)
            where TDest : AuditModel
            where TSource : IAuditEntity
        {
            expression.ForMember(e => e.CreatedOn, t => t.MapFrom(src => src.CreatedOn))
               .ForMember(e => e.CreatedBy, t => t.MapFrom(src => new FastEntityModel<Guid>
               {
                   Id = src.CreatedById,
                   Name = $"{src.CreatedBy.FirstName} {src.CreatedBy.LastName}",
               }))
               .ForMember(e => e.ModifiedOn, t => t.MapFrom(src => src.ModifiedOn))
               .ForMember(e => e.ModifiedBy, t => t.MapFrom(src => new FastEntityModel<Guid>
               {
                   Id = src.ModifiedById,
                   Name = $"{src.ModifiedBy.FirstName} {src.ModifiedBy.LastName}",
               }));
            return expression;
        }
    }
}
