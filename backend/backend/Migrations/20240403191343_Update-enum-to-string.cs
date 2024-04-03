using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class Updateenumtostring : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AthleteCompetition_Athletes_competitorsID",
                table: "AthleteCompetition");

            migrationBuilder.DropForeignKey(
                name: "FK_AthleteCompetition_Competitions_competitionsID",
                table: "AthleteCompetition");

            migrationBuilder.RenameColumn(
                name: "competitorsID",
                table: "AthleteCompetition",
                newName: "CompetitorsID");

            migrationBuilder.RenameColumn(
                name: "competitionsID",
                table: "AthleteCompetition",
                newName: "CompetitionsID");

            migrationBuilder.RenameIndex(
                name: "IX_AthleteCompetition_competitorsID",
                table: "AthleteCompetition",
                newName: "IX_AthleteCompetition_CompetitorsID");

            migrationBuilder.AlterColumn<string>(
                name: "Rang",
                table: "Competitions",
                type: "nvarchar(255)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Region",
                table: "Athletes",
                type: "nvarchar(255)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_AthleteCompetition_Athletes_CompetitorsID",
                table: "AthleteCompetition",
                column: "CompetitorsID",
                principalTable: "Athletes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AthleteCompetition_Competitions_CompetitionsID",
                table: "AthleteCompetition",
                column: "CompetitionsID",
                principalTable: "Competitions",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AthleteCompetition_Athletes_CompetitorsID",
                table: "AthleteCompetition");

            migrationBuilder.DropForeignKey(
                name: "FK_AthleteCompetition_Competitions_CompetitionsID",
                table: "AthleteCompetition");

            migrationBuilder.RenameColumn(
                name: "CompetitorsID",
                table: "AthleteCompetition",
                newName: "competitorsID");

            migrationBuilder.RenameColumn(
                name: "CompetitionsID",
                table: "AthleteCompetition",
                newName: "competitionsID");

            migrationBuilder.RenameIndex(
                name: "IX_AthleteCompetition_CompetitorsID",
                table: "AthleteCompetition",
                newName: "IX_AthleteCompetition_competitorsID");

            migrationBuilder.AlterColumn<int>(
                name: "Rang",
                table: "Competitions",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Region",
                table: "Athletes",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_AthleteCompetition_Athletes_competitorsID",
                table: "AthleteCompetition",
                column: "competitorsID",
                principalTable: "Athletes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AthleteCompetition_Competitions_competitionsID",
                table: "AthleteCompetition",
                column: "competitionsID",
                principalTable: "Competitions",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
