using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWebMvc.Migrations
{
    public partial class DepartmentForeignkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sellers_Department_DepartmentId",
                table: "Sellers");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Sellers",
                newName: "DepartmentID");

            migrationBuilder.RenameIndex(
                name: "IX_Sellers_DepartmentId",
                table: "Sellers",
                newName: "IX_Sellers_DepartmentID");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentID",
                table: "Sellers",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Sellers_Department_DepartmentID",
                table: "Sellers",
                column: "DepartmentID",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sellers_Department_DepartmentID",
                table: "Sellers");

            migrationBuilder.RenameColumn(
                name: "DepartmentID",
                table: "Sellers",
                newName: "DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Sellers_DepartmentID",
                table: "Sellers",
                newName: "IX_Sellers_DepartmentId");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Sellers",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Sellers_Department_DepartmentId",
                table: "Sellers",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
