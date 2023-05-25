using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Koblius.NET.Parser.Tests
{
    public sealed class RadiusLength_Tests
    {
        [Fact]
        public void Create_New_RadiusLength_With_Valid_Arguments_Should_Returns_Object()
        {
            byte[] length = new byte[2] { 1, 2 };

            RadiusLength radiusLength = new RadiusLength(length);

            Assert.True(length.SequenceEqual(radiusLength.Length));
        }

        [Fact]
        public void Create_New_RadiusLength_With_Null_Arguments_Should_Throws_Exception()
        {
            byte[] length = null;

            Action action = () => new RadiusLength(length);

            Assert.Throws<ArgumentNullException>(action);
        }        
        
        [Fact]
        public void Create_New_RadiusLength_With_1Index_Arguments_Should_Throws_Exception()
        {
            byte[] length = new byte[1] { 1 };

            Action action = () => new RadiusLength(length);

            Assert.Throws<ArgumentException>(action);
        }
    }
}
