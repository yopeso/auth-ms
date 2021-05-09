using Microsoft.EntityFrameworkCore;

namespace Yopeso.Auth
{
    public class AppDbContext: BaseDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> op) : base(op)
        {
        }
    }
}