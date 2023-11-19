using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeliveryBreadWebApi.Migrations
{
    public partial class addGateName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Gates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Gates");
        }
    }
}
