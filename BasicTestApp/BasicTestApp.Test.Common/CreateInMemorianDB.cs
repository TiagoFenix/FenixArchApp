using BasicTestApp.DataStore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicTestApp.Test.Common
{
    public class CreateInMemorianDB
    {
        public static BasicTestAppDbContext CreateFreshInMemory()
        {
            // Create a fresh service provider, and therefore a fresh 
            // InMemory database instance.
            // We had to do this to avoid the InMemory DB from being dirty after a test added/deleted something.
            var serviceProvider = new ServiceCollection()
              .AddEntityFrameworkInMemoryDatabase()
              .BuildServiceProvider();

            BasicTestAppDbContext context = new BasicTestAppDbContext(new DbContextOptionsBuilder<BasicTestAppDbContext>()
              .UseInMemoryDatabase()
              .UseInternalServiceProvider(serviceProvider)
              .Options);

            context.EnsureSeedDataForTest();

            return context;
        }
    }
}
