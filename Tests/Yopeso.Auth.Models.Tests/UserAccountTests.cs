using NUnit.Framework;

namespace Yopeso.Auth.Models.Tests
{
    public class UserAccountTests
    {
        private UserAccount _ua;

        [SetUp]
        public void Setup()
        {
            _ua = new();
        }

        [Test]
        public void Should_extend_the_BaseModel()
        {
            Assert.That(_ua, Is.InstanceOf<BaseModel>());
            // stating the obvious, but better to ensure the base ctor is not overriden. 
            Assert.That(_ua.CreatedAt, Is.Not.Null);
            Assert.That(_ua.LastEdit, Is.Not.Null);
        }

        [TestCase(234)]
        [TestCase(2)]
        public void Should_have_an_Id_prop(long id)
        {
            _ua.Id = id;

            Assert.That(_ua.Id, Is.EqualTo(id));
        }

        [TestCase("a name")]
        [TestCase("another name")]
        public void Should_have_an_alias_as_username_prop(string username)
        {
            _ua.Username = username;

            Assert.That(_ua.Username, Is.EqualTo(username));
        }

        [TestCase("somethin@something.com")]
        [TestCase("just a string, no validation ")]
        public void Should_have_an_email_prop(string email)
        {
            _ua.Email = email;

            Assert.That(_ua.Email, Is.EqualTo(email));
        }

        [TestCase("aPass")]
        [TestCase("another1")]
        public void Should_have_a_password(string password)
        {
            _ua.Password = password;

            Assert.That(_ua.Password, Is.EqualTo(password));
        }

        [TestCase("qewfqwef89-h-h-h-sha8")]
        [TestCase("anotherString1235#$%")]
        public void Should_have_a_password_salt_for_encoding_the_password(string salt)
        {
            _ua.PasswordSalt = salt;

            Assert.That(_ua.PasswordSalt, Is.EqualTo(salt));
        }

        public void Should_have_a_multitude_of_roles()
        {
            _ua.Roles.Add(new Role() {Id = 1000, Name = "test"});
        }
    }
}