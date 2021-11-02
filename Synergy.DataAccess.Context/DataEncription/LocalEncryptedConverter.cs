using System;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Synergy.DataAccess.Context.DataEncription
{
    public class LocalEncryptedConverter : ValueConverter<string, string>, IEncryptedConverter
    {
        private static Expression<Func<string, string>> decryptExpression = x => Decrypt(x);
        private static Expression<Func<string, string>> encryptExpression = x => Encrypt(x);

        public LocalEncryptedConverter(ConverterMappingHints mappingHints = default)
            : base(encryptExpression, decryptExpression, mappingHints)
        {
        }

        private static string Decrypt(string data)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(data));
        }

        private static string Encrypt(string data)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(data));
        }
    }
}
