using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RiskSolution.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccessibilityViolations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Threat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SourceOfThreat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AttackImplementation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessibilityViolations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConfidentialityViolations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Threat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SourceOfThreat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AttackImplementation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfidentialityViolations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IntegrityViolations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Threat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SourceOfThreat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AttackImplementation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntegrityViolations", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccessibilityViolations");

            migrationBuilder.DropTable(
                name: "ConfidentialityViolations");

            migrationBuilder.DropTable(
                name: "IntegrityViolations");
        }
    }
}
