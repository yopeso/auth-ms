using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using Yopeso.Auth.Lib.Models;

namespace Yopeso.Auth.Tests
{
    public class BaseDbContextTests
    {
        public class BaseDbContextExt : BaseDbContext
        {
            public BaseDbContextExt()
            {
            }

            public BaseDbContextExt(DbContextOptions<BaseDbContext> op) : base(op)
            {
            }
        }

        private BaseDbContext _dbCtx;

        [SetUp]
        public void Setup()
        {
            _dbCtx = new BaseDbContextExt();
        }

        [Test]
        public void Should_extend_IdentityDbContext()
        {
            Assert.That(_dbCtx,
                Is.InstanceOf<IdentityDbContext<UserAccount, Role, string, UserClaim, UserRole, UserLogin, RoleClaim,
                    UserToken>>());
        }

        // [Test]
        // public void Should_have_UserAccounts_DbSet()
        // {
        //     Assert.That(_dbCtx.Users, Is.InstanceOf<DbSet<UserAccount>>());
        // }
        //
        // [Test]
        // public void Should_have_Roles_DbSet()
        // {
        //     Assert.That(_dbCtx.Roles, Is.InstanceOf<DbSet<Role>>());
        // }
    }
}