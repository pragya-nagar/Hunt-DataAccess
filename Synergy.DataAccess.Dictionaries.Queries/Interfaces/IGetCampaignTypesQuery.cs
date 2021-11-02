using System.Collections.Generic;

using Synergy.DataAccess.Abstractions.Interfaces;
using Synergy.DataAccess.Dictionaries.Queries.Models;

namespace Synergy.DataAccess.Dictionaries.Queries.Interfaces
{
    public interface IGetCampaignTypesQuery : IQuery<IGetCampaignTypesQuery, IEnumerable<CampaignTypeModel>>,
                                              IHaveSearch<IGetCampaignTypesQuery>
    {
    }
}
