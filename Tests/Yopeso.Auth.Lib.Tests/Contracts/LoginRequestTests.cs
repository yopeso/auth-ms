using NUnit.Framework;
using Yopeso.Auth.Lib.Contracts;

namespace Yopeso.Auth.Lib.Tests.Contracts
{
    public class LoginRequestTests
    {
        private LoginRequest _lr;

        [SetUp]
        public void Setup()
        {
            _lr = new();
        }

        [TestCase("a user name")]
        [TestCase("another")]
        public void Should_have_RW_username_property(string username)
        {
            _lr.Username = username;
            Assert.That(_lr.Username, Is.EqualTo(username));
        }

        [TestCase("a Password name")]
        [TestCase("*#(*HD)U)(*HD")]
        public void Should_have_RW_Password_property(string password)
        {
            _lr.Password = password;
            Assert.That(_lr.Password, Is.EqualTo(password));
        }
    }
}