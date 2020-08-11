using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Migrations
{
    public partial class AddedSimpleVendorData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VendorData",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ProductIdsAndQuantities = table.Column<string>(nullable: true),
                    AccountBalanceString = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendorData", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VendorData");
        }
    }
}
