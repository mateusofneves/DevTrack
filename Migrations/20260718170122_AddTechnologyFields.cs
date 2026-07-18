using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevTrack.Migrations
{
    /// <inheritdoc />
    public partial class AddTechnologyFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LearningStatus",
                table: "Technologies",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "StartedAt",
                table: "Technologies",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LearningStatus",
                table: "Technologies");

            migrationBuilder.DropColumn(
                name: "StartedAt",
                table: "Technologies");
        }
    }
}
