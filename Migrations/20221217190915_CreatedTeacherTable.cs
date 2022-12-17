using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Eduhome.Migrations
{
    public partial class CreatedTeacherTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teachers",
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
                    Fullname = table.Column<string>(maxLength: 2000, nullable: true),
                    TeachersImage = table.Column<string>(nullable: true),
                    Profession = table.Column<string>(maxLength: 2000, nullable: true),
                    AboutTeacher = table.Column<string>(maxLength: 2000, nullable: true),
                    Degree = table.Column<string>(maxLength: 2000, nullable: true),
                    Experience = table.Column<string>(maxLength: 2000, nullable: true),
                    Hobbies = table.Column<string>(maxLength: 2000, nullable: true),
                    Faculty = table.Column<string>(maxLength: 2000, nullable: true),
                    ContactInfo = table.Column<string>(maxLength: 2000, nullable: true),
                    Mail = table.Column<string>(maxLength: 2000, nullable: true),
                    Phone = table.Column<string>(maxLength: 2000, nullable: true),
                    Skype = table.Column<string>(maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
