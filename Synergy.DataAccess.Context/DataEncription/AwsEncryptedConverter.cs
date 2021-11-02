using System;
using System.IO;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using Amazon.KeyManagementService;
using Amazon.KeyManagementService.Model;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Extensions.Options;

namespace Synergy.DataAccess.Context.DataEncription
{
    public class AwsEncryptedConverter : ValueConverter<string, string>, IEncryptedConverter
    {
        private static IOptions<AwsEncryptedOptions> _options;

        private static Expression<Func<string, string>> decryptExpression = x => Decrypt(x);
        private static Expression<Func<string, string>> encryptExpression = x => Encrypt(x);

        public AwsEncryptedConverter(
            IOptions<AwsEncryptedOptions> options,
            ConverterMappingHints mappingHints = default)
            : base(encryptExpression, decryptExpression, mappingHints)
        {
            _options = options;
        }

        private static string Decrypt(string data)
        {
            using (var msDecrypt = new MemoryStream(Convert.FromBase64String(data)))
            {
                var lBytes = new byte[4];
                msDecrypt.Read(lBytes, 0, 4);
                var length = BitConverter.ToInt32(lBytes, 0);

                var buffer = new byte[length];
                msDecrypt.Read(buffer, 0, length);

                using (var dataKeyCipher = DecryptDataKey(new MemoryStream(buffer)))
                {
                    using (var algorithm = Aes.Create())
                    {
                        algorithm.Key = dataKeyCipher.ToArray();

                        var iv = algorithm.IV;
                        msDecrypt.Read(iv, 0, iv.Length);
                        algorithm.IV = iv;

                        var decryptor = algorithm.CreateDecryptor(algorithm.Key, algorithm.IV);

                        using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        {
                            using (var srDecrypt = new MemoryStream())
                            {
                                csDecrypt.CopyTo(srDecrypt);

                                return Encoding.UTF8.GetString(srDecrypt.ToArray());
                            }
                        }
                    }
                }
            }
        }

        private static string Encrypt(string data)
        {
            using (var algorithm = Aes.Create())
            {
                using (var msEncrypt = new MemoryStream())
                {
                    using (var kmsClient = new AmazonKeyManagementServiceClient(_options.Value.Region))
                    {
                        GenerateDataKeyResponse dataKey = null;
                        try
                        {
                            dataKey = kmsClient.GenerateDataKeyAsync(new GenerateDataKeyRequest
                            {
                                KeyId = _options.Value.MasterKeyId,
                                KeySpec = DataKeySpec.AES_256,
                            }).Result;

                            var cipherTextBlobLength = BitConverter.GetBytes((int)dataKey.CiphertextBlob.Length);
                            msEncrypt.Write(cipherTextBlobLength, 0, 4);
                            dataKey.CiphertextBlob.CopyTo(msEncrypt);

                            algorithm.Key = dataKey.Plaintext.ToArray();

                            msEncrypt.Write(algorithm.IV, 0, algorithm.IV.Length);
                        }
                        finally
                        {
                            dataKey?.Plaintext?.Dispose();
                            dataKey?.CiphertextBlob?.Dispose();
                        }
                    }

                    var encryptor = algorithm.CreateEncryptor(algorithm.Key, algorithm.IV);

                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        var dataBytes = Encoding.UTF8.GetBytes(data);

                        using (var input = new MemoryStream(dataBytes))
                        {
                            input.CopyTo(csEncrypt);
                            csEncrypt.FlushFinalBlock();
                        }

                        return Convert.ToBase64String(msEncrypt.ToArray());
                    }
                }
            }
        }

        private static MemoryStream DecryptDataKey(MemoryStream ciphertext)
        {
            using (var kmsClient = new AmazonKeyManagementServiceClient(_options.Value.Region))
            {
                var decryptionResponse = kmsClient.DecryptAsync(new DecryptRequest
                {
                    CiphertextBlob = ciphertext,
                }).Result;

                return decryptionResponse.Plaintext;
            }
        }
    }
}
