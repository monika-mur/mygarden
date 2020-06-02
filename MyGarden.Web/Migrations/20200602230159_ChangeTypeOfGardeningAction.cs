using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyGarden.Web.Migrations
{
    public partial class ChangeTypeOfGardeningAction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Action_ActionType",
                table: "CompletedAction");

            migrationBuilder.DropColumn(
                name: "Action_Description",
                table: "CompletedAction");

            migrationBuilder.AddColumn<Guid>(
                name: "ActionId",
                table: "CompletedAction",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "GardenAction",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ActionType = table.Column<int>(nullable: false),
                    PlantCharacteristicsId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GardenAction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GardenAction_PlantCharacteristics_PlantCharacteristicsId",
                        column: x => x.PlantCharacteristicsId,
                        principalTable: "PlantCharacteristics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompletedAction_ActionId",
                table: "CompletedAction",
                column: "ActionId");

            migrationBuilder.CreateIndex(
                name: "IX_GardenAction_PlantCharacteristicsId",
                table: "GardenAction",
                column: "PlantCharacteristicsId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompletedAction_GardenAction_ActionId",
                table: "CompletedAction",
                column: "ActionId",
                principalTable: "GardenAction",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompletedAction_GardenAction_ActionId",
                table: "CompletedAction");

            migrationBuilder.DropTable(
                name: "GardenAction");

            migrationBuilder.DropIndex(
                name: "IX_CompletedAction_ActionId",
                table: "CompletedAction");

            migrationBuilder.DropColumn(
                name: "ActionId",
                table: "CompletedAction");

            migrationBuilder.AddColumn<int>(
                name: "Action_ActionType",
                table: "CompletedAction",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Action_Description",
                table: "CompletedAction",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
