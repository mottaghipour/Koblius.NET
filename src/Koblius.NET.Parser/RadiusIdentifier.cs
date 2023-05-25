using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koblius.NET.Parser
{
    public struct RadiusIdentifier
    {
        public byte Identifier { get; private set; }

        public RadiusIdentifier(byte identifier)
        {
            Identifier = identifier;
        }
    }
}
