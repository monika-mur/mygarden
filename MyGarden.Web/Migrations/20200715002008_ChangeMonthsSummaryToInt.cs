using Microsoft.EntityFrameworkCore.Migrations;

namespace MyGarden.Web.Migrations
{
    public partial class ChangeMonthsSummaryToInt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SowingDate_MonthsSummary",
                table: "Sowing",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FloweringTime_MonthsSummary",
                table: "PlantCharacteristics",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Time_MonthsSummary",
                table: "GardenAction",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "SowingDate_MonthsSummary",
                table: "Sowing",
                type: "float",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "FloweringTime_MonthsSummary",
                table: "PlantCharacteristics",
                type: "float",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Time_MonthsSummary",
                table: "GardenAction",
                type: "float",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
