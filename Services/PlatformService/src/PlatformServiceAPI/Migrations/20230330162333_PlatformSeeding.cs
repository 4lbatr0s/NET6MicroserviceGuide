using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlatformServiceAPI.Migrations
{
    public partial class PlatformSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "CompanyId", "Cost", "Name", "Publisher" },
                values: new object[,]
                {
                    { new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), "Free", "Kubernetes", "Cloud Native Computing" },
                    { new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), "Free", "Dotnet", "Microsoft" },
                    { new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"), "Free", "SQL Server Express", "Microsoft" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "CompanyId",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "CompanyId",
                keyValue: new Guid("80abbca8-664d-4b20-b5de-024705497d4a"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "CompanyId",
                keyValue: new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"));
        }
    }
}
