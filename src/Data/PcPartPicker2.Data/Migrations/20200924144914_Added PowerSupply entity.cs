using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PcPartPicker2.Data.Migrations
{
    public partial class AddedPowerSupplyentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PowerSupplies",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    FormFactor = table.Column<string>(nullable: true),
                    Wattage = table.Column<double>(nullable: false),
                    Length = table.Column<int>(nullable: false),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PowerSupplies", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PowerSupplies_IsDeleted",
                table: "PowerSupplies",
                column: "IsDeleted");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PowerSupplies");
        }
    }
}
