using Microsoft.EntityFrameworkCore;

namespace Yopeso.Auth.Models
{
    public abstract class BaseDbContext: DbContext
    {
        public virtual DbSet<UserAccount> UserAccounts { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        
    }
}