using EFCoreTest.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreTest.Data.Design
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/dbcontext-creation
    /// </summary>
    public class NovaContextFactory : IDesignTimeDbContextFactory<NovaDbContext>
    {
        public NovaDbContext CreateDbContext(string[] args)
        {
            var options = new DbContextOptionsBuilder<NovaDbContext>()
            //.UseInMemoryDatabase(databaseName: "Add_writes_to_database")
            .UseSqlite("Data Source=test.db")
            .Options;

            return new NovaDbContext(options);
        }
    }
}
