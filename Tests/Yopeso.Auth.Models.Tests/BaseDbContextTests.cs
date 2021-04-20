using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace Yopeso.Auth.Models.Tests
{
    public class BaseDbContextTests
    {
        public class BaseDbContextExt: BaseDbContext
        {
            
        }
        
        private BaseDbContext dbCtx; 
        
        [SetUp]
        public void Setup()
        {
            dbCtx = new BaseDbContextExt();
        }

        [Test]
        public void Should_have_UserAccounts_DbSet()
        {
            Assert.That(dbCtx.UserAccounts, Is.InstanceOf<DbSet<UserAccount>>());
        }
        
        [Test]
        public void Should_have_Roles_DbSet()
        {
            Assert.That(dbCtx.Roles, Is.InstanceOf<DbSet<Role>>());
        }
    }
}