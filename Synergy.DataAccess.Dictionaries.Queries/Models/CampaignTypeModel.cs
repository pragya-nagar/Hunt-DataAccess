using System.Collections.Generic;

using Synergy.DataAccess.Abstractions.Models;

namespace Synergy.DataAccess.Dictionaries.Queries.Models
{
    public class CampaignTypeModel : FastEntityModel<int>
    {
        public List<FastEntityModel<int>> CampaingSubType { get; set; }
    }
}
