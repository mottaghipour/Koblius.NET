using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Koblius.NET.Parser.Tests
{
    public sealed class RadiusAttribute_Tests
    {
        [Fact]
        public void Create_New_RdiusAttribute_With_Valid_Arguments_Should_Returns_Object()
        {
            var attributeCode = new AttributeCode(1);
            var attributeLength = new AttributeLength(4);
            byte[] value = new byte[2] { 1, 2 };
            var attributeValue = new AttributeValue(attributeLength, value);

            RadiusAttribute radiusAttribute = new RadiusAttribute(attributeCode, attributeLength, attributeValue);

            Assert.Equivalent(attributeCode, radiusAttribute.AttributeCode);
            Assert.Equivalent(attributeLength, radiusAttribute.AttributeLength);
            Assert.Equivalent(attributeValue, radiusAttribute.AttributeValue);
            Assert.True(attributeValue.Length == radiusAttribute.AttributeLength.Length - 2);
        }
    }
}
