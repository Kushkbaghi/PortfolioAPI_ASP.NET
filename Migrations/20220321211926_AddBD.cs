using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddBD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    Prograssion = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: true),
                    End = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    Place = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: true),
                    End = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Url = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    ImageName = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    ImageLink = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    Tags = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
