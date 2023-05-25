using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koblius.NET.Parser
{
    public struct RadiusAuthenticator
    {
        public byte[] Authenticator { get; set; }

        public RadiusAuthenticator(byte[] authenticator)
        {
            Authenticator = ValidateAuthenticator(authenticator);
        }

        private static byte[] ValidateAuthenticator(byte[] authenticator)
        {
            return ChainValidation(authenticator);
        }

        private static byte[] ChainValidation(byte[] authenticator)
        {
            return IsNotNull(authenticator);
        }

        private static byte[] IsNotNull(byte[] authenticator)
        {
            if (authenticator != null)
                return HasSixTeenIndexes(authenticator);

            throw new ArgumentNullException(nameof(authenticator));
        }

        private static byte[] HasSixTeenIndexes(byte[] authenticator)
        {
            if (authenticator.Length == 16)
                return authenticator;

            throw new ArgumentException(nameof(authenticator));
        }
    }
}
