using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace GamesTore.Repository.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_TheaterRoom_Theater_Id", table: "TheaterRoom");
            migrationBuilder.DropForeignKey(name: "FK_User_Theater_Id", table: "User");
            migrationBuilder.AddForeignKey(
                name: "FK_TheaterRoom_Theater_Id",
                table: "TheaterRoom",
                column: "Id",
                principalTable: "Theater",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_User_Theater_Id",
                table: "User",
                column: "Id",
                principalTable: "Theater",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_TheaterRoom_Theater_Id", table: "TheaterRoom");
            migrationBuilder.DropForeignKey(name: "FK_User_Theater_Id", table: "User");
            migrationBuilder.AddForeignKey(
                name: "FK_TheaterRoom_Theater_Id",
                table: "TheaterRoom",
                column: "Id",
                principalTable: "Theater",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_User_Theater_Id",
                table: "User",
                column: "Id",
                principalTable: "Theater",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
