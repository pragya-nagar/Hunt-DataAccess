using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class UnderwritingWorkflowDefinitionStateMap : IEntityTypeConfiguration<UnderwritingWorkflowDefinitionState>
    {
        public void Configure(EntityTypeBuilder<UnderwritingWorkflowDefinitionState> builder)
        {
        }
    }
}
