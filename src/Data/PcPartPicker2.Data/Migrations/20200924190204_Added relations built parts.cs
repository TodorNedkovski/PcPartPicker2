using Microsoft.EntityFrameworkCore.Migrations;

namespace PcPartPicker2.Data.Migrations
{
    public partial class Addedrelationsbuiltparts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CaseId",
                table: "Builds",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CpuCoolerId",
                table: "Builds",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CpuId",
                table: "Builds",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MemoryId",
                table: "Builds",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MotherboardId",
                table: "Builds",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PowerSupplyId",
                table: "Builds",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StorageId",
                table: "Builds",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoCardId",
                table: "Builds",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Builds_CaseId",
                table: "Builds",
                column: "CaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Builds_CpuCoolerId",
                table: "Builds",
                column: "CpuCoolerId");

            migrationBuilder.CreateIndex(
                name: "IX_Builds_CpuId",
                table: "Builds",
                column: "CpuId");

            migrationBuilder.CreateIndex(
                name: "IX_Builds_MemoryId",
                table: "Builds",
                column: "MemoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Builds_MotherboardId",
                table: "Builds",
                column: "MotherboardId");

            migrationBuilder.CreateIndex(
                name: "IX_Builds_PowerSupplyId",
                table: "Builds",
                column: "PowerSupplyId");

            migrationBuilder.CreateIndex(
                name: "IX_Builds_StorageId",
                table: "Builds",
                column: "StorageId");

            migrationBuilder.CreateIndex(
                name: "IX_Builds_VideoCardId",
                table: "Builds",
                column: "VideoCardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Builds_Cases_CaseId",
                table: "Builds",
                column: "CaseId",
                principalTable: "Cases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Builds_CpuCoolers_CpuCoolerId",
                table: "Builds",
                column: "CpuCoolerId",
                principalTable: "CpuCoolers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Builds_Cpus_CpuId",
                table: "Builds",
                column: "CpuId",
                principalTable: "Cpus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Builds_Memories_MemoryId",
                table: "Builds",
                column: "MemoryId",
                principalTable: "Memories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Builds_Motherboards_MotherboardId",
                table: "Builds",
                column: "MotherboardId",
                principalTable: "Motherboards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Builds_PowerSupplies_PowerSupplyId",
                table: "Builds",
                column: "PowerSupplyId",
                principalTable: "PowerSupplies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Builds_Storages_StorageId",
                table: "Builds",
                column: "StorageId",
                principalTable: "Storages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Builds_VideoCards_VideoCardId",
                table: "Builds",
                column: "VideoCardId",
                principalTable: "VideoCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Builds_Cases_CaseId",
                table: "Builds");

            migrationBuilder.DropForeignKey(
                name: "FK_Builds_CpuCoolers_CpuCoolerId",
                table: "Builds");

            migrationBuilder.DropForeignKey(
                name: "FK_Builds_Cpus_CpuId",
                table: "Builds");

            migrationBuilder.DropForeignKey(
                name: "FK_Builds_Memories_MemoryId",
                table: "Builds");

            migrationBuilder.DropForeignKey(
                name: "FK_Builds_Motherboards_MotherboardId",
                table: "Builds");

            migrationBuilder.DropForeignKey(
                name: "FK_Builds_PowerSupplies_PowerSupplyId",
                table: "Builds");

            migrationBuilder.DropForeignKey(
                name: "FK_Builds_Storages_StorageId",
                table: "Builds");

            migrationBuilder.DropForeignKey(
                name: "FK_Builds_VideoCards_VideoCardId",
                table: "Builds");

            migrationBuilder.DropIndex(
                name: "IX_Builds_CaseId",
                table: "Builds");

            migrationBuilder.DropIndex(
                name: "IX_Builds_CpuCoolerId",
                table: "Builds");

            migrationBuilder.DropIndex(
                name: "IX_Builds_CpuId",
                table: "Builds");

            migrationBuilder.DropIndex(
                name: "IX_Builds_MemoryId",
                table: "Builds");

            migrationBuilder.DropIndex(
                name: "IX_Builds_MotherboardId",
                table: "Builds");

            migrationBuilder.DropIndex(
                name: "IX_Builds_PowerSupplyId",
                table: "Builds");

            migrationBuilder.DropIndex(
                name: "IX_Builds_StorageId",
                table: "Builds");

            migrationBuilder.DropIndex(
                name: "IX_Builds_VideoCardId",
                table: "Builds");

            migrationBuilder.DropColumn(
                name: "CaseId",
                table: "Builds");

            migrationBuilder.DropColumn(
                name: "CpuCoolerId",
                table: "Builds");

            migrationBuilder.DropColumn(
                name: "CpuId",
                table: "Builds");

            migrationBuilder.DropColumn(
                name: "MemoryId",
                table: "Builds");

            migrationBuilder.DropColumn(
                name: "MotherboardId",
                table: "Builds");

            migrationBuilder.DropColumn(
                name: "PowerSupplyId",
                table: "Builds");

            migrationBuilder.DropColumn(
                name: "StorageId",
                table: "Builds");

            migrationBuilder.DropColumn(
                name: "VideoCardId",
                table: "Builds");
        }
    }
}
