using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Company.Data.Migrations
{
    /// <inheritdoc />
    public partial class Update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatAt",
                table: "Employees",
                newName: "CreateAt");

            migrationBuilder.RenameColumn(
                name: "CreatAt",
                table: "Departments",
                newName: "CreateAt");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreateAt",
                table: "Employees",
                newName: "CreatAt");

            migrationBuilder.RenameColumn(
                name: "CreateAt",
                table: "Departments",
                newName: "CreatAt");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
