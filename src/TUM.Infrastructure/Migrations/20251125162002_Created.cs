using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TUM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Created : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "fechaCreacion",
                table: "Productos",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "fechaActualizacion",
                table: "Productos",
                newName: "CreatedAt");

            migrationBuilder.AddColumn<string>(
                name: "LastModified",
                table: "Productos",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedAt",
                table: "Productos",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Clientes",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Clientes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastModified",
                table: "Clientes",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedAt",
                table: "Clientes",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "LastModifiedAt",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "LastModifiedAt",
                table: "Clientes");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Productos",
                newName: "fechaCreacion");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Productos",
                newName: "fechaActualizacion");
        }
    }
}
