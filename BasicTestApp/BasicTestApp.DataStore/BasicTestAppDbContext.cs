using BasicTestApp.DataStore.Schema;
using Microsoft.EntityFrameworkCore;

namespace BasicTestApp.DataStore
{
    public class BasicTestAppDbContext : DbContext
    {
        public BasicTestAppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<AccountDataModel> Accounts { get; set; }
    }
}
