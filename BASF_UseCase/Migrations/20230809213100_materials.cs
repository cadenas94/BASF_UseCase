using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BASF_UseCase.Migrations
{
    public partial class materials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_InputMaterials",
                table: "InputMaterials");

            migrationBuilder.RenameTable(
                name: "InputMaterials",
                newName: "Materials");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Materials",
                table: "Materials",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Materials",
                table: "Materials");

            migrationBuilder.RenameTable(
                name: "Materials",
                newName: "InputMaterials");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InputMaterials",
                table: "InputMaterials",
                column: "Id");
        }
    }
}
