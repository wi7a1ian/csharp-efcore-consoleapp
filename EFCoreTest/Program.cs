using EFCoreTest.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreTest
{
    class Program
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/projects
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/providers
            var options = new DbContextOptionsBuilder<NovaDbContext>()
                .UseInMemoryDatabase(databaseName: "testdb")
                .Options;

            // TODO: Use built in DI container instead: serviceProvider.GetService<NovaDbContext>()
            using (var dbContext = new NovaDbContext(options)) 
            {
                dbContext.BackupServers.Add(new BackupServer { Id = 1, Name = "MszaguGraWGry" });
                dbContext.SaveChanges();

                var a = dbContext.BackupServers.Where(x => x.Name.StartsWith("Mszagu"));
                Console.WriteLine(a.FirstOrDefault().Name);
            }
        }
    }
}
