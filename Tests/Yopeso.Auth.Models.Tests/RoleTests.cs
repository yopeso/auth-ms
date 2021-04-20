using NUnit.Framework;

namespace Yopeso.Auth.Models.Tests
{
    public class RoleTests
    {
        private Role _role;

        [SetUp]
        public void Setup()
        {
            _role = new();
        }

        [Test]
        public void Should_extend_the_BaseModel()
        {
            Assert.That(_role, Is.InstanceOf<BaseModel>());
            Assert.That(_role.CreatedAt, Is.Not.Null);
            Assert.That(_role.LastEdit, Is.Not.Null);
        }

        [TestCase("UserManagement")]
        [TestCase("Admin")]
        public void Should_have_a_friendly_name(string name)
        {
            _role.Name = name;

            Assert.That(_role.Name, Is.EqualTo(name));
        }
        
        [TestCase("Does something ...")]
        [TestCase("Dummy role")]
        public void Should_have_a_description(string description)
        {
            _role.Description = description;

            Assert.That(_role.Description, Is.EqualTo(description));
        }
    }
}