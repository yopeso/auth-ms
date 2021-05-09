using NUnit.Framework;
using Yopeso.Auth.Lib.Contracts;

namespace Yopeso.Auth.Lib.Tests.Contracts
{
    public class RegisterRequestTests
    {
        private RegisterRequest _rr;

        [SetUp]
        public void Setup()
        {
            _rr = new();
        }
        
        [TestCase("a email")]
        [TestCase("something")]
        public void Should_have_RW_Email_property(string email)
        {
            _rr.Email = email;
            Assert.That(_rr.Email, Is.EqualTo(email));
        }

        [TestCase("a email")]
        [TestCase("something")]
        public void Should_have_RW_Username_property(string username)
        {
            _rr.Username = username;
            Assert.That(_rr.Username, Is.EqualTo(username));
        }
        
        [TestCase("a Password name")]
        [TestCase("*#(*HD)U)(*HD")]
        public void Should_have_RW_Password_property(string password)
        {
            _rr.Password = password;
            Assert.That(_rr.Password, Is.EqualTo(password));
        }
    }
}