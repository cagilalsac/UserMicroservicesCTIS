using Microsoft.EntityFrameworkCore;

namespace Users.APP.Domain
{
    public class UsersDb : DbContext
    {
        public DbSet<Group> Groups { get; set; }

        public UsersDb(DbContextOptions options) : base(options)
        {
        }
    }
}
