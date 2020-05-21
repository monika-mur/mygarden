using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyGarden.Web.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlantCharacteristics",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    LatinName = table.Column<string>(nullable: true),
                    Spacing_Minimal = table.Column<int>(nullable: true),
                    Spacing_Maximal = table.Column<int>(nullable: true),
                    Spacing_Measure = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlantCharacteristics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserId",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserId", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Garden",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserIdId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Garden", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Garden_UserId_UserIdId",
                        column: x => x.UserIdId,
                        principalTable: "UserId",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Plant",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GardenId = table.Column<Guid>(nullable: false),
                    PlantCharacteristicsId = table.Column<Guid>(nullable: true),
                    PlantingDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plant", x => new { x.GardenId, x.Id });
                    table.ForeignKey(
                        name: "FK_Plant_Garden_GardenId",
                        column: x => x.GardenId,
                        principalTable: "Garden",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Plant_PlantCharacteristics_PlantCharacteristicsId",
                        column: x => x.PlantCharacteristicsId,
                        principalTable: "PlantCharacteristics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompletedAction",
                columns: table => new
                {
                    PlantGardenId = table.Column<Guid>(nullable: false),
                    PlantId = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Action_Description = table.Column<string>(nullable: true),
                    Action_ActionType = table.Column<int>(nullable: true),
                    ActionDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompletedAction", x => new { x.PlantGardenId, x.PlantId, x.Id });
                    table.ForeignKey(
                        name: "FK_CompletedAction_Plant_PlantGardenId_PlantId",
                        columns: x => new { x.PlantGardenId, x.PlantId },
                        principalTable: "Plant",
                        principalColumns: new[] { "GardenId", "Id" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Garden_UserIdId",
                table: "Garden",
                column: "UserIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Plant_PlantCharacteristicsId",
                table: "Plant",
                column: "PlantCharacteristicsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompletedAction");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Plant");

            migrationBuilder.DropTable(
                name: "Garden");

            migrationBuilder.DropTable(
                name: "PlantCharacteristics");

            migrationBuilder.DropTable(
                name: "UserId");
        }
    }
}
