using Microsoft.EntityFrameworkCore;
using System;

namespace EFCoreTest.Data
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/ef/core/miscellaneous/configuring-dbcontext#constructor-argument
    /// </summary>
    public class NovaDbContext : DbContext
    {
        public NovaDbContext(DbContextOptions<NovaDbContext> options)
            : base(options)
        {
            // nop
        }

        public DbSet<BackupServer> BackupServers { get; set; }
    }
}
