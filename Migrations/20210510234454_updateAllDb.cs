using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DSS_MVC.Migrations
{
    public partial class updateAllDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Loans",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Loans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Loans",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Loans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Borrowers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Borrowers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Borrowers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Borrowers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Borrowers");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Borrowers");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Borrowers");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Borrowers");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Books");
        }
    }
}
