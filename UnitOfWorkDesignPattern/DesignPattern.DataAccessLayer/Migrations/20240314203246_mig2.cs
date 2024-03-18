using Microsoft.EntityFrameworkCore.Migrations;

namespace DesignPattern.DataAccessLayer.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "NewReceiverBalance",
                table: "Customers",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "NewSenderBalance",
                table: "Customers",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NewReceiverBalance",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "NewSenderBalance",
                table: "Customers");
        }
    }
}
