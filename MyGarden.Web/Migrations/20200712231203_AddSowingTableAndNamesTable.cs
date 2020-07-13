using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyGarden.Web.Migrations
{
    public partial class AddSowingTableAndNamesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompletedAction_Plant_PlantGardenId_PlantId",
                table: "CompletedAction");

            migrationBuilder.DropForeignKey(
                name: "FK_Plant_Garden_GardenId",
                table: "Plant");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Plant",
                table: "Plant");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CompletedAction",
                table: "CompletedAction");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "PlantCharacteristics");

            migrationBuilder.DropColumn(
                name: "Spacing_Maximal",
                table: "PlantCharacteristics");

            migrationBuilder.DropColumn(
                name: "Spacing_Measure",
                table: "PlantCharacteristics");

            migrationBuilder.DropColumn(
                name: "Spacing_Minimal",
                table: "PlantCharacteristics");

            migrationBuilder.DropColumn(
                name: "GardenId",
                table: "Plant");

            migrationBuilder.DropColumn(
                name: "PlantGardenId",
                table: "CompletedAction");

            migrationBuilder.AddColumn<double>(
                name: "FloweringTime_MonthsSummary",
                table: "PlantCharacteristics",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "GardenModelId",
                table: "Plant",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<double>(
                name: "Time_MonthsSummary",
                table: "GardenAction",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PlantGardenModelId",
                table: "CompletedAction",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Plant",
                table: "Plant",
                columns: new[] { "GardenModelId", "Id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompletedAction",
                table: "CompletedAction",
                columns: new[] { "PlantGardenModelId", "PlantId", "Id" });

            migrationBuilder.CreateTable(
                name: "PlantNames",
                columns: table => new
                {
                    PlantCharacteristicsId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    PlantCharacteristicsId1 = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlantNames", x => x.PlantCharacteristicsId);
                    table.ForeignKey(
                        name: "FK_PlantNames_PlantCharacteristics_PlantCharacteristicsId1",
                        column: x => x.PlantCharacteristicsId1,
                        principalTable: "PlantCharacteristics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sowing",
                columns: table => new
                {
                    PlantCharacteristicsId = table.Column<Guid>(nullable: false),
                    SowingDate_MonthsSummary = table.Column<double>(nullable: true),
                    Spacing_Minimal = table.Column<int>(nullable: true),
                    Spacing_Maximal = table.Column<int>(nullable: true),
                    Spacing_Measure = table.Column<int>(nullable: true),
                    Depth = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sowing", x => x.PlantCharacteristicsId);
                    table.ForeignKey(
                        name: "FK_Sowing_PlantCharacteristics_PlantCharacteristicsId",
                        column: x => x.PlantCharacteristicsId,
                        principalTable: "PlantCharacteristics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlantNames_PlantCharacteristicsId1",
                table: "PlantNames",
                column: "PlantCharacteristicsId1");

            migrationBuilder.AddForeignKey(
                name: "FK_CompletedAction_Plant_PlantGardenModelId_PlantId",
                table: "CompletedAction",
                columns: new[] { "PlantGardenModelId", "PlantId" },
                principalTable: "Plant",
                principalColumns: new[] { "GardenModelId", "Id" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Plant_Garden_GardenModelId",
                table: "Plant",
                column: "GardenModelId",
                principalTable: "Garden",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompletedAction_Plant_PlantGardenModelId_PlantId",
                table: "CompletedAction");

            migrationBuilder.DropForeignKey(
                name: "FK_Plant_Garden_GardenModelId",
                table: "Plant");

            migrationBuilder.DropTable(
                name: "PlantNames");

            migrationBuilder.DropTable(
                name: "Sowing");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Plant",
                table: "Plant");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CompletedAction",
                table: "CompletedAction");

            migrationBuilder.DropColumn(
                name: "FloweringTime_MonthsSummary",
                table: "PlantCharacteristics");

            migrationBuilder.DropColumn(
                name: "GardenModelId",
                table: "Plant");

            migrationBuilder.DropColumn(
                name: "Time_MonthsSummary",
                table: "GardenAction");

            migrationBuilder.DropColumn(
                name: "PlantGardenModelId",
                table: "CompletedAction");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "PlantCharacteristics",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Spacing_Maximal",
                table: "PlantCharacteristics",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Spacing_Measure",
                table: "PlantCharacteristics",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Spacing_Minimal",
                table: "PlantCharacteristics",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "GardenId",
                table: "Plant",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "PlantGardenId",
                table: "CompletedAction",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Plant",
                table: "Plant",
                columns: new[] { "GardenId", "Id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompletedAction",
                table: "CompletedAction",
                columns: new[] { "PlantGardenId", "PlantId", "Id" });

            migrationBuilder.AddForeignKey(
                name: "FK_CompletedAction_Plant_PlantGardenId_PlantId",
                table: "CompletedAction",
                columns: new[] { "PlantGardenId", "PlantId" },
                principalTable: "Plant",
                principalColumns: new[] { "GardenId", "Id" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Plant_Garden_GardenId",
                table: "Plant",
                column: "GardenId",
                principalTable: "Garden",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
