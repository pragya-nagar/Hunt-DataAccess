using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Synergy.Common.Aws.Extensions;
using Synergy.DataAccess.Context.DataEncription;

namespace Synergy.DataAccess.Abstractions
{
    public static class SynergyEncriptionRegistration
    {
        public static void RegisterSynergyEncriptionService(this IServiceCollection serviceCollection,
            bool isDevelopment,
            IConfiguration configuration)
        {
            if (isDevelopment)
            {
                serviceCollection.AddSingleton<IEncryptedConverter>(provider => new LocalEncryptedConverter());
            }
            else
            {
                var region = configuration.GetRegionEndPoint();

                serviceCollection.Configure<AwsEncryptedOptions>(o =>
                {
                    o.Region = region;
                    configuration.Bind("Encryption", o);
                });

                serviceCollection.AddSingleton<IEncryptedConverter, AwsEncryptedConverter>();
            }
        }
    }
}
