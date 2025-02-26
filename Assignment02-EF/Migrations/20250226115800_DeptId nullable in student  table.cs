using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment02_EF.Migrations
{
    public partial class DeptIdnullableinstudenttable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Studentes_Departmentes_DepartmentId",
                table: "Studentes");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Studentes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Studentes_Departmentes_DepartmentId",
                table: "Studentes",
                column: "DepartmentId",
                principalTable: "Departmentes",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Studentes_Departmentes_DepartmentId",
                table: "Studentes");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Studentes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Studentes_Departmentes_DepartmentId",
                table: "Studentes",
                column: "DepartmentId",
                principalTable: "Departmentes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
