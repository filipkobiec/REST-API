using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFDataAccessLibrary.Migrations
{
    public partial class InitialCreate : Migration
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
                    { 1, new DateTime(2020, 4, 3, 13, 20, 0, 0, DateTimeKind.Unspecified), "Product1", 1m, "Very cool product1" },
                    { 2, new DateTime(2020, 5, 3, 11, 30, 33, 0, DateTimeKind.Unspecified), "Product2", 2m, "Very cool product2" },
                    { 3, new DateTime(2021, 5, 6, 8, 20, 0, 0, DateTimeKind.Unspecified), "Product3", 3m, "Very cool product3" },
                    { 4, new DateTime(2022, 1, 3, 15, 30, 0, 0, DateTimeKind.Unspecified), "Product4", 4m, "Very cool product4" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
