using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DietApp.Migrations
{
    public partial class userseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "BodyMeasurementsId", "Hips", "Neck", "UserId", "Waist", "Age", "Goal", "HeightFeetComponent", "HeightInchComponent", "HoursExercisePerWeek", "Name", "Sex", "WeightInLbs" },
                values: new object[] { 1, 36.2f, 13.5f, 1, 34.75f, 25, 0, 5, 10.5f, 3, "John", 0, 160f });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "BodyMeasurementsId",
                keyValue: 1);
        }
    }
}
