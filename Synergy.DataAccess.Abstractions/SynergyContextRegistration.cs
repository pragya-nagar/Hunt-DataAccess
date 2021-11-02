using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Synergy.Common.Abstracts;
using Synergy.DataAccess.Context;
using Synergy.DataAccess.Context.DataEncription;

namespace Synergy.DataAccess.Abstractions
{
    public static class SynergyContextRegistration
    {
        public static void RegisterSynergyContext(this IServiceCollection serviceCollection, string connectionString, bool runMigration = true)
        {
            serviceCollection.AddScoped<ISynergyContext>(provider => new SynergyContext(provider.GetService<ILoggerFactory>(), provider.GetService<IOperationContextAccessor>(), connectionString, provider.GetService<IEncryptedConverter>()));

            if (runMigration)
            {
#pragma warning disable CA2000 // Dispose objects before losing scope
                using (var synergyContext = new SynergyContext(new NullLoggerFactory(), new SystemContextAccessor(), connectionString, new LocalEncryptedConverter()))
#pragma warning restore CA2000 // Dispose objects before losing scope
                {
                    synergyContext.CreateOrUpdateDb();
                    synergyContext.EnsureSeedData();
                }
            }
        }
    }
}
