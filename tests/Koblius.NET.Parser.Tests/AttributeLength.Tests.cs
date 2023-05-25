using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Koblius.NET.Parser.Tests
{
    public sealed class AttributeLength_Tests
    {
        [Fact]
        public void Create_New_AttributeLength_With_Valid_Arguments_Should_Returns_Object()
        {
            byte length = 1;

            AttributeLength attributeLength = new AttributeLength(length);

            Assert.Equal(length, attributeLength.Length);
        }
    }
}
