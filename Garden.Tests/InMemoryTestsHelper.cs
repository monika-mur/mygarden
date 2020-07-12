using Microsoft.EntityFrameworkCore;
using MyGarden.Infrastructure;
using System;

namespace Garden.Tests
{
    public static class InMemoryTestsHelper
    {
        public static GardenDbContext DbContext()
        {
            var options = new DbContextOptionsBuilder<GardenDbContext>()
                .UseInMemoryDatabase(databaseName: $"gardendbcontext_test_{Guid.NewGuid().ToString()}")
                .Options;

            return new GardenDbContext(options);
        }
    }
}
