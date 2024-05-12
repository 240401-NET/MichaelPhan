using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Workouts.Data.Migrations
{
    /// <inheritdoc />
    public partial class junctionTable2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExercisesUsers");

            migrationBuilder.AddColumn<int>(
                name: "UsersId",
                table: "Exercises",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_UsersId",
                table: "Exercises",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exercises_Users_UsersId",
                table: "Exercises",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exercises_Users_UsersId",
                table: "Exercises");

            migrationBuilder.DropIndex(
                name: "IX_Exercises_UsersId",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "Exercises");

            migrationBuilder.CreateTable(
                name: "ExercisesUsers",
                columns: table => new
                {
                    ExerciseId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExercisesUsers", x => new { x.ExerciseId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_ExercisesUsers_Exercises_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExercisesUsers_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExercisesUsers_UsersId",
                table: "ExercisesUsers",
                column: "UsersId");
        }
    }
}
