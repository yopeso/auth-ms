using System;
using NUnit.Framework;
using Yopeso.Auth.Lib.Models;

namespace Yopeso.Auth.Lib.Tests
{
    public class BaseModelTests
    {
        public class BaseModelTestable : BaseModel
        {
        }
        
        private BaseModel _bm;

        [SetUp]
        public void Setup()
        {
            _bm = new BaseModelTestable();
        }

        [Test]
        public void Should_autopopulate_the_CreatedAt_and_LastEdit_on_init()
        {
            Assert.That(_bm.CreatedAt, Is.Not.Null);
            Assert.That(_bm.LastEdit, Is.Not.Null);
        }

        [TestCase("19 Jan, 2019")]
        [TestCase("19 Jan, 2019 00:01:01")]
        public void Should_have_LastEdit_prop_editable(string stringDate)
        {
            var expected = DateTime.Parse(stringDate);
            _bm.LastEdit = expected;

            Assert.That(_bm.LastEdit, Is.EqualTo(expected));
        }
    }
}