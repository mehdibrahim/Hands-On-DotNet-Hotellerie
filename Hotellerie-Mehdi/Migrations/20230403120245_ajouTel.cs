﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotellerie_Mehdi.Migrations
{
    /// <inheritdoc />
    public partial class ajouTel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Tel",
                table: "Hotels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tel",
                table: "Hotels");
        }
    }
}
