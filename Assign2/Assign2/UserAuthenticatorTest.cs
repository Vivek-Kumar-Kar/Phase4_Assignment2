using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign2
{
    [TestFixture]
    public class UserAuthenticatorTest
    {
        private UserAuthenticator userAuthenticator;

        [SetUp]
        public void SetUp()
        {
            userAuthenticator = new UserAuthenticator();

        }
        [Test]
        public void TestUserLogin()
        {
            userAuthenticator.RegisterUser("Michael", "Jordan");

            Assert.IsTrue(userAuthenticator.Login("Michael", "Jordan"));
            Assert.IsFalse(userAuthenticator.Login("Mich", "Jorda"));
            Assert.IsFalse(userAuthenticator.Login("Jord", "Mich"));
        }

        [Test]
        public void TestPasswordReset()
        {
            userAuthenticator.RegisterUser("Michael", "Jordan");

            userAuthenticator.ResetPassword("Michael", "Michael");

            Assert.IsTrue(userAuthenticator.Login("Michael", "Michael"));
        }
    }
}
