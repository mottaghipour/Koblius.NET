using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Koblius.NET.Parser.Tests
{
    public sealed class RadiusCode_Tests
    {
        [Fact]
        public void Create_New_RadiusCode_With_Valid_Arguments_Should_Returns_Object()
        {
            byte code = 1;

            RadiusCode radiusCode = new RadiusCode(code);

            Assert.Equal(code, radiusCode.Code);
        }
    }
}
