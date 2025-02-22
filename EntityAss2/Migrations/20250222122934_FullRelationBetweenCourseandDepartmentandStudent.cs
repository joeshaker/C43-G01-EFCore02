using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityAss2.Migrations
{
    /// <inheritdoc />
    public partial class FullRelationBetweenCourseandDepartmentandStudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Students_Dep_Id",
                table: "Students",
                column: "Dep_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Top_Id",
                table: "Courses",
                column: "Top_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Topics_Top_Id",
                table: "Courses",
                column: "Top_Id",
                principalTable: "Topics",
                principalColumn: "TopicId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_Dep_Id",
                table: "Students",
                column: "Dep_Id",
                principalTable: "Departments",
                principalColumn: "DeptId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Topics_Top_Id",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_Dep_Id",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_Dep_Id",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Courses_Top_Id",
                table: "Courses");
        }
    }
}
