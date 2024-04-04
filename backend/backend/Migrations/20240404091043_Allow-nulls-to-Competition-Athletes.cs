using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class AllownullstoCompetitionAthletes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Competitions_WinnerId",
                table: "Competitions");

            migrationBuilder.AlterColumn<int>(
                name: "WinnerId",
                table: "Competitions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Competitions_WinnerId",
                table: "Competitions",
                column: "WinnerId",
                unique: true,
                filter: "[WinnerId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Competitions_WinnerId",
                table: "Competitions");

            migrationBuilder.AlterColumn<int>(
                name: "WinnerId",
                table: "Competitions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Competitions_WinnerId",
                table: "Competitions",
                column: "WinnerId",
                unique: true);
        }
    }
}
