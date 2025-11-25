using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TUM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class EstadosTarea : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tareas_EstadosTarea_EstadoTareaId",
                table: "Tareas");

            migrationBuilder.RenameColumn(
                name: "EstadoTareaId",
                table: "Tareas",
                newName: "EstadosTareaId");

            migrationBuilder.RenameIndex(
                name: "IX_Tareas_EstadoTareaId",
                table: "Tareas",
                newName: "IX_Tareas_EstadosTareaId");

            migrationBuilder.RenameColumn(
                name: "EstadoTareaId",
                table: "EstadosTarea",
                newName: "EstadosTareaId");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "EstadosTarea",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "EstadosTarea",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastModified",
                table: "EstadosTarea",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedAt",
                table: "EstadosTarea",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tareas_EstadosTarea_EstadosTareaId",
                table: "Tareas",
                column: "EstadosTareaId",
                principalTable: "EstadosTarea",
                principalColumn: "EstadosTareaId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tareas_EstadosTarea_EstadosTareaId",
                table: "Tareas");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "EstadosTarea");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "EstadosTarea");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "EstadosTarea");

            migrationBuilder.DropColumn(
                name: "LastModifiedAt",
                table: "EstadosTarea");

            migrationBuilder.RenameColumn(
                name: "EstadosTareaId",
                table: "Tareas",
                newName: "EstadoTareaId");

            migrationBuilder.RenameIndex(
                name: "IX_Tareas_EstadosTareaId",
                table: "Tareas",
                newName: "IX_Tareas_EstadoTareaId");

            migrationBuilder.RenameColumn(
                name: "EstadosTareaId",
                table: "EstadosTarea",
                newName: "EstadoTareaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tareas_EstadosTarea_EstadoTareaId",
                table: "Tareas",
                column: "EstadoTareaId",
                principalTable: "EstadosTarea",
                principalColumn: "EstadoTareaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
