using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BASF_UseCase.Migrations
{
    public partial class InputMaterialUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Material",
                table: "InputMaterials",
                newName: "MaterialValue");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MaterialValue",
                table: "InputMaterials",
                newName: "Material");
        }
    }
}
