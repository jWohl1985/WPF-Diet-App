using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DietApp.Migrations
{
    public partial class anothertestuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "BodyMeasurementsId", "Hips", "Neck", "UserId", "Waist", "Age", "Goal", "HeightFeetComponent", "HeightInchComponent", "HoursExercisePerWeek", "Name", "Sex", "WeightInLbs" },
                values: new object[] { 2, 41f, 15f, 2, 42f, 42, 0, 5, 6f, 0, "Jane", 1, 180f });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "BodyMeasurementsId",
                keyValue: 2);
        }
    }
}
