using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace library.Migrations
{
    public partial class InitialMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Members_member_id",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_member_id",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "dob",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "member_id",
                table: "Books");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "dob",
                table: "Members",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "member_id",
                table: "Books",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_member_id",
                table: "Books",
                column: "member_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Members_member_id",
                table: "Books",
                column: "member_id",
                principalTable: "Members",
                principalColumn: "member_id");
        }
    }
}
