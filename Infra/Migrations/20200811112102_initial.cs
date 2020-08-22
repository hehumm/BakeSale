using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CurrencyData",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    BanknotesAndCoinsInStringFormat = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrencyData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MoneyData",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Amount = table.Column<float>(nullable: false),
                    CurrencyId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoneyData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MoneyData_CurrencyData_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "CurrencyData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductData",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    PriceId = table.Column<string>(nullable: true),
                    Image = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductData_MoneyData_PriceId",
                        column: x => x.PriceId,
                        principalTable: "MoneyData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MoneyData_CurrencyId",
                table: "MoneyData",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductData_PriceId",
                table: "ProductData",
                column: "PriceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductData");

            migrationBuilder.DropTable(
                name: "MoneyData");

            migrationBuilder.DropTable(
                name: "CurrencyData");
        }
    }
}
