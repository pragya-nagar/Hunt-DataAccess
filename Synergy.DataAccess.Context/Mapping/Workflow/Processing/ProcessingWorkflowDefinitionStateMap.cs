using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class ProcessingWorkflowDefinitionStateMap : IEntityTypeConfiguration<ProcessingWorkflowDefinitionState>
    {
        public void Configure(EntityTypeBuilder<ProcessingWorkflowDefinitionState> builder)
        {
        }
    }
}