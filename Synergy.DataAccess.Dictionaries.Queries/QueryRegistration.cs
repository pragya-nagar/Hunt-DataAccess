using Microsoft.Extensions.DependencyInjection;

using Synergy.DataAccess.Abstractions;
using Synergy.DataAccess.Dictionaries.Queries.Interfaces;
using Synergy.DataAccess.Dictionaries.Queries.Queries;

namespace Synergy.DataAccess.Dictionaries.Queries
{
    public static class QueryRegistration
    {
        public static void RegisterDictionariesQueries(this IServiceCollection serviceCollection, string connectionString, bool runMigration = true)
        {
            serviceCollection.RegisterSynergyContext(connectionString, runMigration);

            serviceCollection.AddTransient<IGetStatesDictionaryQuery, GetStatesDictionaryQuery>();
            serviceCollection.AddTransient<IGetUsersDictionaryQuery, GetUsersDictionaryQuery>();
            serviceCollection.AddTransient<IGetCampaignTypesQuery, GetCampaignTypesQuery>();
            serviceCollection.AddTransient<IGetInternalLandUseCodesQuery, GetInternalLandUseCodesQuery>();
            serviceCollection.AddTransient<IGetGeneralLandUseCodesQuery, GetGeneralLandUseCodesQuery>();
            serviceCollection.AddTransient<IGetPropertyDisplayStrategiesDictionaryQuery, GetPropertyDisplayStrategiesDictionaryQuery>();
        }
    }
}
