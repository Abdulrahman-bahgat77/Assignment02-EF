using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment02_EF.Migrations
{
    public partial class DeptIdnullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Departmentes_ManagerId",
                table: "Departmentes");

            migrationBuilder.AlterColumn<int>(
                name: "ManagerId",
                table: "Departmentes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Departmentes_ManagerId",
                table: "Departmentes",
                column: "ManagerId",
                unique: true,
                filter: "[ManagerId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Departmentes_ManagerId",
                table: "Departmentes");

            migrationBuilder.AlterColumn<int>(
                name: "ManagerId",
                table: "Departmentes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Departmentes_ManagerId",
                table: "Departmentes",
                column: "ManagerId",
                unique: true);
        }
    }
}
