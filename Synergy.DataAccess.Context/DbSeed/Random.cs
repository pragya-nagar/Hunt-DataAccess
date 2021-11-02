using System;
using System.Security.Cryptography;
using System.Text;

namespace Synergy.DataAccess.Context.DbSeed
{
    internal class Random
    {
        private static readonly RandomNumberGenerator _random = new RNGCryptoServiceProvider();

        public static int Next(int min, int max)
        {
            uint scale = uint.MaxValue;
            while (scale == uint.MaxValue)
            {
                byte[] four_bytes = new byte[4];
                _random.GetBytes(four_bytes);
                scale = BitConverter.ToUInt32(four_bytes, 0);
            }

            return (int)(min + ((max - min) * (scale / (double)uint.MaxValue)));
        }
    }
}
