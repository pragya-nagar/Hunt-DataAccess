﻿using System;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities.AuditModels;

namespace Synergy.DataAccess.Context.MappingAudit
{
    public class TemplateFileCountyAuditMap : AuditMap<TemplateFileCountyAudit, Guid>
    {
        public override void AdditionalMapping(EntityTypeBuilder<TemplateFileCountyAudit> builder)
        {
        }
    }
}