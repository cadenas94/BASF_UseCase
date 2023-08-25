using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BASF_UseCase.Migrations
{
    public partial class char40 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MaterialValue",
                table: "Materials",
                type: "char(40)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(150)",
                oldMaxLength: 150);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MaterialValue",
                table: "Materials",
                type: "char(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(40)");
        }
    }
}
