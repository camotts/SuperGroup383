using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace GamesTore.Repository.Migrations
{
    public partial class Init5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Theater",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ManagerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Theater", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Theater_User_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });
            migrationBuilder.AddColumn<int>(
                name: "TheaterId",
                table: "User",
                nullable: true);
            migrationBuilder.AddColumn<int>(
                name: "TheaterId",
                table: "Ticket",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "SeatsJSON",
                table: "TheaterRoom",
                nullable: true);
            migrationBuilder.AddColumn<int>(
                name: "TheaterId",
                table: "TheaterRoom",
                nullable: true);
            migrationBuilder.AddForeignKey(
                name: "FK_TheaterRoom_Theater_TheaterId",
                table: "TheaterRoom",
                column: "TheaterId",
                principalTable: "Theater",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Theater_TheaterId",
                table: "Ticket",
                column: "TheaterId",
                principalTable: "Theater",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_User_Theater_TheaterId",
                table: "User",
                column: "TheaterId",
                principalTable: "Theater",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_TheaterRoom_Theater_TheaterId", table: "TheaterRoom");
            migrationBuilder.DropForeignKey(name: "FK_Ticket_Theater_TheaterId", table: "Ticket");
            migrationBuilder.DropForeignKey(name: "FK_User_Theater_TheaterId", table: "User");
            migrationBuilder.DropColumn(name: "TheaterId", table: "User");
            migrationBuilder.DropColumn(name: "TheaterId", table: "Ticket");
            migrationBuilder.DropColumn(name: "SeatsJSON", table: "TheaterRoom");
            migrationBuilder.DropColumn(name: "TheaterId", table: "TheaterRoom");
            migrationBuilder.DropTable("Theater");
        }
    }
}
