using System;
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


    public static class BasicTestAppDbContextExtensions
    {
        public static void EnsureSeedDataForTest(this BasicTestAppDbContext context)
        {
            CallSeeder(context);
        }

        private static void CallSeeder(BasicTestAppDbContext context)
        {
            AccountDataModel account = new AccountDataModel()
            {
                AccountId = 1,
                Created = new DateTime(2017, 10, 10),
                AccountName = "Test",
                CreatedBy = "Fenix"
            };
            context.Accounts.Add(account);
            context.SaveChanges();
        }

    }
}
