using NUnit.Framework;
using Yopeso.Auth.Lib.Contracts;

namespace Yopeso.Auth.Lib.Tests.Contracts
{
    public class ResponseTests
    {
        private Response _resp;

        [SetUp]
        public void Setup()
        {
            _resp = new();
        }
        
        [TestCase("Success")]
        [TestCase("Error")]
        public void Should_have_RW_Status_property(string status)
        {
            // add enum
            _resp.Status = status;
            Assert.That(_resp.Status, Is.EqualTo(status));
        }

        [TestCase("a message")]
        [TestCase("something")]
        public void Should_have_RW_Message_property(string message)
        {
            _resp.Message = message;
            Assert.That(_resp.Message, Is.EqualTo(message));
        }
    }
}