using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Koblius.NET.Parser.Tests
{
    public sealed class RadiusAuthenticator_Tests
    {
        [Fact]
        public void Create_New_RdiusAuthenticator_With_Valid_Arguments_Should_Returns_Object()
        {
            byte[] authenticator = new byte[16] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };

            RadiusAuthenticator radiusAuthenticator = new RadiusAuthenticator(authenticator);

            Assert.True(authenticator.SequenceEqual(radiusAuthenticator.Authenticator));
        }

        [Fact]
        public void Create_New_RdiusAuthenticator_With_Null_Arguments_Should_Throws_Exception()
        {
            byte[] authenticator = null;

            Action action = () => new RadiusAuthenticator(authenticator);

            Assert.Throws<ArgumentNullException>(action);
        }

        [Fact]
        public void Create_New_RdiusAuthenticator_With_1Indexes_Arguments_Should_Throws_Exception()
        {
            byte[] authenticator = new byte[1] { 1 };

            Action action = () => new RadiusAuthenticator(authenticator);

            Assert.Throws<ArgumentException>(action);
        }
    }
}
