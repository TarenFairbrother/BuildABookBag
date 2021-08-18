using Microsoft.EntityFrameworkCore.Migrations;

namespace BuildABookBag.Migrations
{
    public partial class ChangeMonthName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BookBagRequestMonth",
                table: "BookBagRequests",
                newName: "RequestMonth");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RequestMonth",
                table: "BookBagRequests",
                newName: "BookBagRequestMonth");
        }
    }
}
