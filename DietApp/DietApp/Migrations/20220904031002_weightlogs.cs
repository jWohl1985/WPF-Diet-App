using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DietApp.Migrations
{
    public partial class weightlogs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WeightLogs",
                columns: table => new
                {
                    WeightLogEntryId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    User = table.Column<int>(type: "INTEGER", nullable: false),
                    WeightRecordedInLbs = table.Column<float>(type: "REAL", nullable: false),
                    DateRecorded = table.Column<DateOnly>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeightLogs", x => x.WeightLogEntryId);
                    table.ForeignKey(
                        name: "FK_WeightLogs_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "BodyMeasurementsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "WeightLogs",
                columns: new[] { "WeightLogEntryId", "DateRecorded", "User", "UserId", "WeightRecordedInLbs" },
                values: new object[] { 1, new DateOnly(2022, 3, 22), 0, 1, 160f });

            migrationBuilder.InsertData(
                table: "WeightLogs",
                columns: new[] { "WeightLogEntryId", "DateRecorded", "User", "UserId", "WeightRecordedInLbs" },
                values: new object[] { 2, new DateOnly(2022, 3, 23), 0, 1, 159.8f });

            migrationBuilder.InsertData(
                table: "WeightLogs",
                columns: new[] { "WeightLogEntryId", "DateRecorded", "User", "UserId", "WeightRecordedInLbs" },
                values: new object[] { 3, new DateOnly(2022, 3, 22), 0, 2, 160f });

            migrationBuilder.InsertData(
                table: "WeightLogs",
                columns: new[] { "WeightLogEntryId", "DateRecorded", "User", "UserId", "WeightRecordedInLbs" },
                values: new object[] { 4, new DateOnly(2022, 3, 23), 0, 2, 159.8f });

            migrationBuilder.CreateIndex(
                name: "IX_WeightLogs_UserId",
                table: "WeightLogs",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeightLogs");
        }
    }
}
