using Castle.Core.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NSubstitute;
using NUnit.Framework;
using IConfiguration = Microsoft.Extensions.Configuration.IConfiguration;

// TODO: follow: https://geeklearning.io/how-to-test-your-asp-net-core-mvc-stack/
namespace Yopeso.Auth.Tests
{
    public class AppSetupTests
    {
        private IConfiguration _confMock;
        private Startup _startup;
        
        [SetUp]
        public void Setup()
        {
            _confMock = Substitute.For<IConfiguration>();
            _startup = new Startup(_confMock);
        }

        [Test]
        public void Should_have_configuration_field_acessable()
        {
            Assert.That(_startup.Configuration, Is.SameAs(_confMock));
        }
    }
}