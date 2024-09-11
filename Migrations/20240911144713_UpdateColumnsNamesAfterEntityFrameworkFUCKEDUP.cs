using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERPDemoAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateColumnsNamesAfterEntityFrameworkFUCKEDUP : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EMail",
                table: "Companies",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "Telefonnummer",
                table: "Companies",
                newName: "Telephone");

            migrationBuilder.RenameColumn(
                name: "Straße",
                table: "Companies",
                newName: "Street");

            migrationBuilder.RenameColumn(
                name: "Postleitzahl",
                table: "Companies",
                newName: "PostalCode");

            migrationBuilder.RenameColumn(
                name: "Ort",
                table: "Companies",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "LandISOCode",
                table: "Companies",
                newName: "CountryCode");

            migrationBuilder.RenameColumn(
                name: "Land",
                table: "Companies",
                newName: "Country");

            migrationBuilder.RenameColumn(
                name: "Firma",
                table: "Companies",
                newName: "CompanyName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Companies",
                newName: "EMail");

            migrationBuilder.RenameColumn(
                name: "Telephone",
                table: "Companies",
                newName: "Telefonnummer");

            migrationBuilder.RenameColumn(
                name: "Street",
                table: "Companies",
                newName: "Straße");

            migrationBuilder.RenameColumn(
                name: "PostalCode",
                table: "Companies",
                newName: "Postleitzahl");

            migrationBuilder.RenameColumn(
                name: "CountryCode",
                table: "Companies",
                newName: "LandISOCode");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "Companies",
                newName: "Land");

            migrationBuilder.RenameColumn(
                name: "CompanyName",
                table: "Companies",
                newName: "Firma");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Companies",
                newName: "Ort");
        }
    }
}
