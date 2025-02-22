using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityAss2.Migrations
{
    /// <inheritdoc />
    public partial class ManyToManyRelationBetweenCourseandStudents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Std_Courses_Course_Id",
                table: "Std_Courses",
                column: "Course_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Std_Courses_Courses_Course_Id",
                table: "Std_Courses",
                column: "Course_Id",
                principalTable: "Courses",
                principalColumn: "Crs_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Std_Courses_Students_Std_Id",
                table: "Std_Courses",
                column: "Std_Id",
                principalTable: "Students",
                principalColumn: "StdId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Std_Courses_Courses_Course_Id",
                table: "Std_Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Std_Courses_Students_Std_Id",
                table: "Std_Courses");

            migrationBuilder.DropIndex(
                name: "IX_Std_Courses_Course_Id",
                table: "Std_Courses");
        }
    }
}
