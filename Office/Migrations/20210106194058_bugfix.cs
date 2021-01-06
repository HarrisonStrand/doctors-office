using Microsoft.EntityFrameworkCore.Migrations;

namespace Office.Migrations
{
    public partial class bugfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DoctorSpeciality",
                table: "Doctors",
                newName: "DoctorSpecialty");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DoctorSpecialty",
                table: "Doctors",
                newName: "DoctorSpeciality");
        }
    }
}
