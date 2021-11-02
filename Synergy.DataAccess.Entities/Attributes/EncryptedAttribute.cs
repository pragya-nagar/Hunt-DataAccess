using System;

namespace Synergy.DataAccess.Context.Attributes
{
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public sealed class EncryptedAttribute : Attribute
    {
        public EncryptedAttribute()
        {
        }
    }
}
