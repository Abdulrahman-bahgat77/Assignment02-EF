using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment02_EF.Migrations
{
    public partial class NullableTopicId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Topices_TopicId",
                table: "Courses");

            migrationBuilder.AlterColumn<int>(
                name: "TopicId",
                table: "Courses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Topices_TopicId",
                table: "Courses",
                column: "TopicId",
                principalTable: "Topices",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Topices_TopicId",
                table: "Courses");

            migrationBuilder.AlterColumn<int>(
                name: "TopicId",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Topices_TopicId",
                table: "Courses",
                column: "TopicId",
                principalTable: "Topices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
