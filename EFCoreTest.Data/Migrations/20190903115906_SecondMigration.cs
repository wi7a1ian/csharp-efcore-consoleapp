using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreTest.Data.Migrations
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/operations
    /// </summary>
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "BackupServers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Url",
                table: "BackupServers");
        }
    }
}
