using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koblius.NET.Parser
{
    public struct RadiusAttribute
    {
        public AttributeCode AttributeCode { get; private set; }
        public AttributeLength AttributeLength { get; private set; }
        public AttributeValue AttributeValue { get; private set; }

        public RadiusAttribute(AttributeCode attributeCode, AttributeLength attributeLength, AttributeValue attributeValue)
        {
            AttributeCode = attributeCode;
            AttributeLength = attributeLength;
            AttributeValue = attributeValue;
        }
    }
}
