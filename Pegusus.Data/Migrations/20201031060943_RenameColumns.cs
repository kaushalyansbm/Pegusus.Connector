using Microsoft.EntityFrameworkCore.Migrations;

namespace Pegusus.Data.Migrations
{
    public partial class RenameColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isDeleted",
                table: "Users",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "isActive",
                table: "Users",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "isDeleted",
                table: "Questions",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "isActive",
                table: "Questions",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "isDeleted",
                table: "Posts",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "isActive",
                table: "Posts",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "isDeleted",
                table: "Answers",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "isActive",
                table: "Answers",
                newName: "IsActive");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Users",
                newName: "isDeleted");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Users",
                newName: "isActive");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Questions",
                newName: "isDeleted");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Questions",
                newName: "isActive");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Posts",
                newName: "isDeleted");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Posts",
                newName: "isActive");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Answers",
                newName: "isDeleted");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Answers",
                newName: "isActive");
        }
    }
}
