using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotTours.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tours",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Direction = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AmountOfDays = table.Column<long>(type: "bigint", nullable: false),
                    PriceForMan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmountOfMan = table.Column<long>(type: "bigint", nullable: false),
                    WiFi = table.Column<bool>(type: "bit", nullable: false),
                    Surcharge = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tours", x => x.Guid);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tours");
        }
    }
}
