using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentGradeManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class StudentTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentsStudentId",
                table: "Course",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentsStudentId1",
                table: "Course",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Course_StudentsStudentId",
                table: "Course",
                column: "StudentsStudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Course_StudentsStudentId1",
                table: "Course",
                column: "StudentsStudentId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Students_StudentsStudentId",
                table: "Course",
                column: "StudentsStudentId",
                principalTable: "Students",
                principalColumn: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Students_StudentsStudentId1",
                table: "Course",
                column: "StudentsStudentId1",
                principalTable: "Students",
                principalColumn: "StudentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Students_StudentsStudentId",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Students_StudentsStudentId1",
                table: "Course");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Course_StudentsStudentId",
                table: "Course");

            migrationBuilder.DropIndex(
                name: "IX_Course_StudentsStudentId1",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "StudentsStudentId",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "StudentsStudentId1",
                table: "Course");
        }
    }
}
