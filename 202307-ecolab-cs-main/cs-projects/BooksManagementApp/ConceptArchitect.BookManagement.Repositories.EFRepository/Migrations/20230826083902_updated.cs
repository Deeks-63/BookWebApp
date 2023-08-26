using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConceptArchitect.BookManagement.Repositories.EFRepository.Migrations
{
    /// <inheritdoc />
    public partial class updated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_AuthorId",
                table: "Books");

            migrationBuilder.AddColumn<string>(
                name: "AuthorId",
                table: "Users",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AuthorId",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.CreateIndex(
                name: "IX_Users_AuthorId",
                table: "Users",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Authors_AuthorId",
                table: "Users",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Authors_AuthorId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_AuthorId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "AuthorId",
                table: "Books",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
