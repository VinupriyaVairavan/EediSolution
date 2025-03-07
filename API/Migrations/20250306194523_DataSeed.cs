using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class DataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "QuestionOptions",
                columns: new[] { "Id", "Description", "IsCorrectOption", "Label", "QuestionId" },
                values: new object[,]
                {
                    { 17, "I think you have counted down rather than up. You can use a number line to help you.", false, "A", 12 },
                    { 18, "Incorrect due to...", false, "B", 12 },
                    { 19, "Try Again", false, "C", 12 },
                    { 20, "Correct", true, "D", 12 }
                });

            migrationBuilder.InsertData(
                table: "StudentAssignments",
                columns: new[] { "QuestionId", "StudentId", "ChosenOptionId", "IsValid" },
                values: new object[] { 12, 1, 19, false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "StudentAssignments",
                keyColumns: new[] { "QuestionId", "StudentId" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: 19);
        }
    }
}
