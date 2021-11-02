using Synergy.DataAccess.Abstractions.Interfaces;

namespace Synergy.DataAccess.Abstractions.Models
{
    public class FastEntityModel<T> : IModel
    {
        public T Id { get; set; }

        public string Name { get; set; }
    }
}
