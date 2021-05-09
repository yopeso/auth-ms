using System.Security.Claims;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Yopeso.Auth.Lib.Models;

namespace Yopeso.Auth
{
    public abstract class BaseDbContext : IdentityDbContext<UserAccount, Role, string, UserClaim, UserRole, UserLogin,
        RoleClaim, UserToken>
    {
        public BaseDbContext(DbContextOptions op) : base(op)
        {
        }

        public BaseDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // overwriting table names 
            builder.Entity<UserAccount>(b => { b.ToTable("UserAccount"); });
            builder.Entity<Role>(b => { b.ToTable("Role"); });
            builder.Entity<UserClaim>(b => { b.ToTable("UserClaim"); });
            builder.Entity<UserRole>(b => { b.ToTable("UserRole"); });
            builder.Entity<UserLogin>(b => { b.ToTable("UserLogin"); });
            builder.Entity<RoleClaim>(b => { b.ToTable("RoleClaim"); });
            builder.Entity<UserToken>(b => { b.ToTable("UserToken"); });
        }
    }
}