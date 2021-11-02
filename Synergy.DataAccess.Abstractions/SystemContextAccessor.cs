using System;
using Synergy.Common.Abstracts;

namespace Synergy.DataAccess.Abstractions
{
    internal class SystemContextAccessor : IOperationContextAccessor, IOperationContext
    {
        public IOperationContext Current => new SystemContextAccessor
        {
            CorrelationId = Guid.NewGuid(),
            UserId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
            UserName = "System",
        };

        public Guid CorrelationId { get; private set; }

        public Guid UserId { get; private set; }

        public string UserName { get; private set; }
    }
}