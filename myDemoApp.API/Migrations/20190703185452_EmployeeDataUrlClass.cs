using Microsoft.EntityFrameworkCore.Migrations;

namespace myDemoApp.API.Migrations
{
    public partial class EmployeeDataUrlClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "EmployeeDatas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Url",
                table: "EmployeeDatas");
        }
    }
}
