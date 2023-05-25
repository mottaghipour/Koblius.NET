using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Koblius.NET.Parser.Tests
{
    public sealed class AttributeCode_Tests
    {
        [Fact]
        public void Create_New_AttributeCode_With_Valid_Arguments_Should_Returns_Object()
        {
            byte code = 1;

            AttributeCode attributeCode = new AttributeCode(code);

            Assert.Equal(code, attributeCode.Code);
        }
    }
}
