using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityAss2.Migrations
{
    /// <inheritdoc />
    public partial class FullRelationBetweenInstructorandDepartment0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instructors_Ins_Id",
                table: "Departments");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_Dept_Id",
                table: "Instructors",
                column: "Dept_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructors_Ins_Id",
                table: "Departments",
                column: "Ins_Id",
                principalTable: "Instructors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_Dept_Id",
                table: "Instructors",
                column: "Dept_Id",
                principalTable: "Departments",
                principalColumn: "DeptId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instructors_Ins_Id",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_Dept_Id",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_Dept_Id",
                table: "Instructors");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructors_Ins_Id",
                table: "Departments",
                column: "Ins_Id",
                principalTable: "Instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
