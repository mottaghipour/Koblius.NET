using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Koblius.NET.Parser.Tests
{
    public sealed class RadiusIdentifier_Tests
    {
        [Fact]
        public void Create_New_RdiusIdentifier_With_Valid_Arguments_Should_Returns_Object()
        {
            byte identifier = 1;

            RadiusIdentifier radiusIdentifier = new RadiusIdentifier(identifier);

            Assert.Equal(identifier, radiusIdentifier.Identifier);
        }
    }
}
