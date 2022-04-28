using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFDataAccessLibrary.Migrations
{
    public partial class dateMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 4, 27, 3, 17, 26, 521, DateTimeKind.Local).AddTicks(5927), "Product1", 1m, "Very cool product1" },
                    { 2, new DateTime(2022, 4, 27, 3, 17, 26, 521, DateTimeKind.Local).AddTicks(5954), "Product2", 2m, "Very cool product2" },
                    { 3, new DateTime(2022, 4, 27, 3, 17, 26, 521, DateTimeKind.Local).AddTicks(5957), "Product3", 3m, "Very cool product3" },
                    { 4, new DateTime(2022, 4, 27, 3, 17, 26, 521, DateTimeKind.Local).AddTicks(5959), "Product4", 4m, "Very cool product4" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
