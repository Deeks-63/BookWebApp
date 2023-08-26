using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConceptArchitect.BookManagement.Repositories.EFRepository.Migrations
{
    /// <inheritdoc />
    public partial class UserEmail_Foreign_key_AddedTo_Favorites : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserEmail",
                table: "Favorites",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_UserEmail",
                table: "Favorites",
                column: "UserEmail");

            migrationBuilder.AddForeignKey(
                name: "FK_Favorites_Users_UserEmail",
                table: "Favorites",
                column: "UserEmail",
                principalTable: "Users",
                principalColumn: "Email",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Favorites_Users_UserEmail",
                table: "Favorites");

            migrationBuilder.DropIndex(
                name: "IX_Favorites_UserEmail",
                table: "Favorites");

            migrationBuilder.AlterColumn<string>(
                name: "UserEmail",
                table: "Favorites",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
