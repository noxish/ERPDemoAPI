using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERPDemoAPI.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Firma = table.Column<string>(type: "TEXT", nullable: true),
                    Straße = table.Column<string>(type: "TEXT", nullable: true),
                    Postleitzahl = table.Column<int>(type: "INTEGER", nullable: true),
                    Ort = table.Column<string>(type: "TEXT", nullable: true),
                    Land = table.Column<string>(type: "TEXT", nullable: true),
                    LandISOCode = table.Column<string>(type: "TEXT", nullable: true),
                    Telefonnummer = table.Column<string>(type: "TEXT", nullable: true),
                    EMail = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
