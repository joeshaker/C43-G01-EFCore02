using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityAss2.Migrations
{
    /// <inheritdoc />
    public partial class ManyToManyRelationBetweenCourseandInstructors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Course_Ins_Ins_Id",
                table: "Course_Ins",
                column: "Ins_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Ins_Courses_Course_Id",
                table: "Course_Ins",
                column: "Course_Id",
                principalTable: "Courses",
                principalColumn: "Crs_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Ins_Instructors_Ins_Id",
                table: "Course_Ins",
                column: "Ins_Id",
                principalTable: "Instructors",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Ins_Courses_Course_Id",
                table: "Course_Ins");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Ins_Instructors_Ins_Id",
                table: "Course_Ins");

            migrationBuilder.DropIndex(
                name: "IX_Course_Ins_Ins_Id",
                table: "Course_Ins");
        }
    }
}
