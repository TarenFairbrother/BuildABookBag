﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace BuildABookBag.Migrations
{
    public partial class InitialDbBuild : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookBagRequests",
                columns: table => new
                {
                    BookBagId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardHolderName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LibraryCardNumber = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgeLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PickUpLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalComments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookBagRequests", x => x.BookBagId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookBagRequests");
        }
    }
}
