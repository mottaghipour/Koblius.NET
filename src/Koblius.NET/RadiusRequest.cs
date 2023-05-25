using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koblius.NET
{
    public sealed class RadiusRequest
    {
        public byte RadiusCode { get; private set; }
        public byte RadiusIdentifier { get; private set; }
        public RadiusLength RadiusLength { get; private set; }
    }
}
