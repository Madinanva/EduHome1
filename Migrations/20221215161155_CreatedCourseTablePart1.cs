using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Eduhome.Migrations
{
    public partial class CreatedCourseTablePart1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    Subject = table.Column<string>(maxLength: 50, nullable: true),
                    CourseImage = table.Column<string>(nullable: true),
                    Description = table.Column<string>(maxLength: 2000, nullable: true),
                    CourseName = table.Column<string>(maxLength: 200, nullable: true),
                    Content = table.Column<string>(maxLength: 2000, nullable: true),
                    AboutCourse = table.Column<string>(maxLength: 2000, nullable: true),
                    Apply = table.Column<string>(maxLength: 2000, nullable: true),
                    Certification = table.Column<string>(maxLength: 2000, nullable: true),
                    FeaturesName = table.Column<string>(maxLength: 2000, nullable: true),
                    Starts = table.Column<string>(maxLength: 50, nullable: true),
                    Duration = table.Column<string>(maxLength: 30, nullable: true),
                    ClassDuration = table.Column<string>(maxLength: 30, nullable: true),
                    SkillLevel = table.Column<string>(maxLength: 50, nullable: true),
                    Students = table.Column<string>(maxLength: 2000, nullable: true),
                    Assesments = table.Column<string>(maxLength: 2000, nullable: true),
                    Price = table.Column<string>(maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
