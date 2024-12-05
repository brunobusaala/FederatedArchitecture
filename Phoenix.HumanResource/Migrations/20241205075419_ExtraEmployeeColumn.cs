using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1._1._2_Phoenix.HumanResource.Migrations
{
    /// <inheritdoc />
    public partial class ExtraEmployeeColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "Employees");
        }
    }
}
