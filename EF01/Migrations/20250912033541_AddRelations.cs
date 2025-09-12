using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF01.Migrations
{
    /// <inheritdoc />
    public partial class AddRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dept_Id",
                table: "Instructors");

            migrationBuilder.RenameColumn(
                name: "Dept_id",
                table: "Students",
                newName: "DepartmentId");

            migrationBuilder.RenameColumn(
                name: "Course_Id",
                table: "Stud_Courses",
                newName: "CourseId");

            migrationBuilder.RenameColumn(
                name: "Stud_Id",
                table: "Stud_Courses",
                newName: "StudentId");

            migrationBuilder.RenameColumn(
                name: "Ins_Id",
                table: "Departments",
                newName: "ManagerId");

            migrationBuilder.RenameColumn(
                name: "Inst_Id",
                table: "Course_Insts",
                newName: "InstructorId");

            migrationBuilder.RenameColumn(
                name: "Course_Id",
                table: "Course_Insts",
                newName: "CourseId");

            migrationBuilder.AddColumn<int>(
                name: "WorkForId",
                table: "Instructors",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_DepartmentId",
                table: "Students",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Stud_Courses_CourseId",
                table: "Stud_Courses",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_WorkForId",
                table: "Instructors",
                column: "WorkForId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_ManagerId",
                table: "Departments",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Top_ID",
                table: "Courses",
                column: "Top_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Course_Insts_InstructorId",
                table: "Course_Insts",
                column: "InstructorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Insts_Courses_CourseId",
                table: "Course_Insts",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Crs_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Insts_Instructors_InstructorId",
                table: "Course_Insts",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Topics_Top_ID",
                table: "Courses",
                column: "Top_ID",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructors_ManagerId",
                table: "Departments",
                column: "ManagerId",
                principalTable: "Instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_WorkForId",
                table: "Instructors",
                column: "WorkForId",
                principalTable: "Departments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Courses_Courses_CourseId",
                table: "Stud_Courses",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Crs_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Courses_Students_StudentId",
                table: "Stud_Courses",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_DepartmentId",
                table: "Students",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Insts_Courses_CourseId",
                table: "Course_Insts");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Insts_Instructors_InstructorId",
                table: "Course_Insts");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Topics_Top_ID",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instructors_ManagerId",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_WorkForId",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Courses_Courses_CourseId",
                table: "Stud_Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Courses_Students_StudentId",
                table: "Stud_Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_DepartmentId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_DepartmentId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Stud_Courses_CourseId",
                table: "Stud_Courses");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_WorkForId",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Departments_ManagerId",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Courses_Top_ID",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Course_Insts_InstructorId",
                table: "Course_Insts");

            migrationBuilder.DropColumn(
                name: "WorkForId",
                table: "Instructors");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Students",
                newName: "Dept_id");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "Stud_Courses",
                newName: "Course_Id");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Stud_Courses",
                newName: "Stud_Id");

            migrationBuilder.RenameColumn(
                name: "ManagerId",
                table: "Departments",
                newName: "Ins_Id");

            migrationBuilder.RenameColumn(
                name: "InstructorId",
                table: "Course_Insts",
                newName: "Inst_Id");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "Course_Insts",
                newName: "Course_Id");

            migrationBuilder.AddColumn<int>(
                name: "Dept_Id",
                table: "Instructors",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
