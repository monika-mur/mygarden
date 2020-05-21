using Microsoft.EntityFrameworkCore.Migrations;

namespace MyGarden.Web.Migrations
{
    public partial class ColumnNameForUserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Garden_UserId_UserIdId",
                table: "Garden");

            migrationBuilder.DropTable(
                name: "UserId");

            migrationBuilder.DropIndex(
                name: "IX_Garden_UserIdId",
                table: "Garden");

            migrationBuilder.DropColumn(
                name: "UserIdId",
                table: "Garden");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Garden",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Garden");

            migrationBuilder.AddColumn<int>(
                name: "UserIdId",
                table: "Garden",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UserId",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserId", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Garden_UserIdId",
                table: "Garden",
                column: "UserIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Garden_UserId_UserIdId",
                table: "Garden",
                column: "UserIdId",
                principalTable: "UserId",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
