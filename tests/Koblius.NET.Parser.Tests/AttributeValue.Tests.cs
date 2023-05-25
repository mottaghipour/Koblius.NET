using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Koblius.NET.Parser.Tests
{
    public sealed class AttributeValue_Tests
    {
        [Fact]
        public void Create_New_AttributeValue_With_Valid_Arguments_Should_Returns_Object()
        {
            byte[] value = new byte[2] { 1, 2 };
            byte length = (byte)(1 + 1 + value.Length);
            AttributeLength attributeLength = new AttributeLength(length);

            AttributeValue attributeValue = new AttributeValue(attributeLength, value);

            Assert.True(value.SequenceEqual(attributeValue.Value));
            Assert.Equal(value.Length, attributeValue.Length);
        }

        [Fact]
        public void Create_New_AttributeValue_With_NullValue_Argument_Should_Returns_Object()
        {
            byte length = 1 + 1;
            AttributeLength attributeLength = new AttributeLength(length);

            AttributeValue attributeValue = new AttributeValue(attributeLength);

            Assert.Null(attributeValue.Value);
            Assert.True(attributeValue.Length == 0);
        }

        [Fact]
        public void Create_New_AttributeValue_With_InValidValueLength_Argument_Should_Throws_Exception()
        {
            byte[] value = new byte[3] { 1, 2, 3 };
            byte length = (byte)(1 + 1 + 2);
            AttributeLength attributeLength = new AttributeLength(length);

            Action action = () => new AttributeValue(attributeLength, value);

            Assert.Throws<ArgumentException>(action);
        }
    }
}
