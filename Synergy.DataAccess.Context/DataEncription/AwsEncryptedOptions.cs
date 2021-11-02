using Amazon;

namespace Synergy.DataAccess.Context.DataEncription
{
    public class AwsEncryptedOptions
    {
        public RegionEndpoint Region { get; set; }

        public string MasterKeyId { get; set; }
    }
}