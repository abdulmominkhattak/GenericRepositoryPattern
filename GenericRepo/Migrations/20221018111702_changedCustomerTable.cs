using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GenericRepo.Migrations
{
    public partial class changedCustomerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Customers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MyProperty",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
