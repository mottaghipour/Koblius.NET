using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koblius.NET.Parser
{
    public struct AttributeCode
    {
        public byte Code { get; private set; }

        public AttributeCode(byte code)
        {
            Code = code;
        }
    }
}
