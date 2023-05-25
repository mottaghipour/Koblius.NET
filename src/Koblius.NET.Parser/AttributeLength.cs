using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koblius.NET.Parser
{
    public struct AttributeLength
    {
        public byte Length { get; private set; }

        public AttributeLength(byte length)
        {
            Length = length;
        }
    }
}
