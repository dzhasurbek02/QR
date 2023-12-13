using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QR.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StaticQrs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ConstValue = table.Column<string>(type: "text", nullable: false),
                    StatQr = table.Column<string>(type: "text", nullable: false),
                    IdEQMS_Address = table.Column<string>(type: "text", nullable: false),
                    Category = table.Column<string>(type: "text", nullable: false),
                    CurrencyCode = table.Column<string>(type: "text", nullable: false),
                    CountryCode = table.Column<string>(type: "text", nullable: false),
                    CompanyName = table.Column<string>(type: "text", nullable: false),
                    CityWhereLocated = table.Column<string>(type: "text", nullable: false),
                    TradeServiceId_TerminalId = table.Column<string>(type: "text", nullable: false),
                    CRC = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaticQrs", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StaticQrs");
        }
    }
}
