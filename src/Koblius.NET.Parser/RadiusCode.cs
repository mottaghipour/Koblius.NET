using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koblius.NET.Parser
{
    public struct RadiusCode
    {
        public byte Code { get; private set; }

        public RadiusCode(byte code)
        {
            Code = code;
        }
    }
}
