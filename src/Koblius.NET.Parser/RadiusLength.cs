using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koblius.NET.Parser
{
    public struct RadiusLength
    {
        public byte[] Length { get; private set; }

        public RadiusLength(byte[] length)
        {
            Length = ValidateLength(length);
        }

        private static byte[] ValidateLength(byte[] length)
        {
            return ChainValidation(length);
        }

        private static byte[] ChainValidation(byte[] length)
        {
            return IsNotNull(length);
        }

        private static byte[] IsNotNull(byte[] length)
        {
            if (length != null)
                return HasTwoIndexes(length);

            throw new ArgumentNullException(nameof(length));
        }

        private static byte[] HasTwoIndexes(byte[] length)
        {
            if (length.Length == 2)
                return length;

            throw new ArgumentException(nameof(length));
        }
    }
}
