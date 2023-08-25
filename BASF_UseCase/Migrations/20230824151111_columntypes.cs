using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BASF_UseCase.Migrations
{
    public partial class columntypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Quantity",
                table: "Materials",
                type: "decimal(8,3)",
                precision: 8,
                scale: 3,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)",
                oldPrecision: 5,
                oldScale: 2);

            migrationBuilder.AlterColumn<string>(
                name: "MaterialValue",
                table: "Materials",
                type: "char(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Quantity",
                table: "Materials",
                type: "decimal(5,2)",
                precision: 5,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8,3)",
                oldPrecision: 8,
                oldScale: 3);

            migrationBuilder.AlterColumn<string>(
                name: "MaterialValue",
                table: "Materials",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(150)",
                oldMaxLength: 150);
        }
    }
}
