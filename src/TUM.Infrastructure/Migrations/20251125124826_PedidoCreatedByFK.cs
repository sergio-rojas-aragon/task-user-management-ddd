using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TUM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class PedidoCreatedByFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetallePedido_Pedido_PedidoId",
                table: "DetallePedido");

            migrationBuilder.DropForeignKey(
                name: "FK_DetallePedido_Producto_ProductoId",
                table: "DetallePedido");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Cliente_ClienteId",
                table: "Pedido");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Usuario_UsuarioId",
                table: "Pedido");

            migrationBuilder.DropForeignKey(
                name: "FK_Tarea_Cliente_ClienteId",
                table: "Tarea");

            migrationBuilder.DropForeignKey(
                name: "FK_Tarea_EstadosTarea_EstadoTareaId",
                table: "Tarea");

            migrationBuilder.DropForeignKey(
                name: "FK_Tarea_EstadosTarea_EstadoTareaId1",
                table: "Tarea");

            migrationBuilder.DropForeignKey(
                name: "FK_Tarea_Pedido_PedidoId",
                table: "Tarea");

            migrationBuilder.DropForeignKey(
                name: "FK_Tarea_Usuario_UsuarioId",
                table: "Tarea");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Rol");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tarea",
                table: "Tarea");

            migrationBuilder.DropIndex(
                name: "IX_Tarea_EstadoTareaId1",
                table: "Tarea");

            migrationBuilder.DropIndex(
                name: "IX_Tarea_UsuarioId",
                table: "Tarea");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Producto",
                table: "Producto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pedido",
                table: "Pedido");

            migrationBuilder.DropIndex(
                name: "IX_Pedido_UsuarioId",
                table: "Pedido");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DetallePedido",
                table: "DetallePedido");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "EstadoTareaId1",
                table: "Tarea");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Tarea");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Pedido");

            migrationBuilder.RenameTable(
                name: "Tarea",
                newName: "Tareas");

            migrationBuilder.RenameTable(
                name: "Producto",
                newName: "Productos");

            migrationBuilder.RenameTable(
                name: "Pedido",
                newName: "Pedidos");

            migrationBuilder.RenameTable(
                name: "DetallePedido",
                newName: "DetallePedidos");

            migrationBuilder.RenameTable(
                name: "Cliente",
                newName: "Clientes");

            migrationBuilder.RenameIndex(
                name: "IX_Tarea_PedidoId",
                table: "Tareas",
                newName: "IX_Tareas_PedidoId");

            migrationBuilder.RenameIndex(
                name: "IX_Tarea_EstadoTareaId",
                table: "Tareas",
                newName: "IX_Tareas_EstadoTareaId");

            migrationBuilder.RenameIndex(
                name: "IX_Tarea_ClienteId",
                table: "Tareas",
                newName: "IX_Tareas_ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Pedido_ClienteId",
                table: "Pedidos",
                newName: "IX_Pedidos_ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_DetallePedido_ProductoId",
                table: "DetallePedidos",
                newName: "IX_DetallePedidos_ProductoId");

            migrationBuilder.RenameIndex(
                name: "IX_DetallePedido_PedidoId",
                table: "DetallePedidos",
                newName: "IX_DetallePedidos_PedidoId");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Tareas",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Tareas",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastModified",
                table: "Tareas",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedAt",
                table: "Tareas",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Pedidos",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Pedidos",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastModified",
                table: "Pedidos",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedAt",
                table: "Pedidos",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tareas",
                table: "Tareas",
                column: "TareaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Productos",
                table: "Productos",
                column: "ProductoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pedidos",
                table: "Pedidos",
                column: "PedidoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DetallePedidos",
                table: "DetallePedidos",
                column: "DetallePedidoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_CreatedBy",
                table: "Pedidos",
                column: "CreatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_DetallePedidos_Pedidos_PedidoId",
                table: "DetallePedidos",
                column: "PedidoId",
                principalTable: "Pedidos",
                principalColumn: "PedidoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetallePedidos_Productos_ProductoId",
                table: "DetallePedidos",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "ProductoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_AspNetUsers_CreatedBy",
                table: "Pedidos",
                column: "CreatedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Clientes_ClienteId",
                table: "Pedidos",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "ClienteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tareas_Clientes_ClienteId",
                table: "Tareas",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "ClienteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tareas_EstadosTarea_EstadoTareaId",
                table: "Tareas",
                column: "EstadoTareaId",
                principalTable: "EstadosTarea",
                principalColumn: "EstadoTareaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tareas_Pedidos_PedidoId",
                table: "Tareas",
                column: "PedidoId",
                principalTable: "Pedidos",
                principalColumn: "PedidoId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetallePedidos_Pedidos_PedidoId",
                table: "DetallePedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_DetallePedidos_Productos_ProductoId",
                table: "DetallePedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_AspNetUsers_CreatedBy",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Clientes_ClienteId",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Tareas_Clientes_ClienteId",
                table: "Tareas");

            migrationBuilder.DropForeignKey(
                name: "FK_Tareas_EstadosTarea_EstadoTareaId",
                table: "Tareas");

            migrationBuilder.DropForeignKey(
                name: "FK_Tareas_Pedidos_PedidoId",
                table: "Tareas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tareas",
                table: "Tareas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Productos",
                table: "Productos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pedidos",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_CreatedBy",
                table: "Pedidos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DetallePedidos",
                table: "DetallePedidos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Tareas");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Tareas");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "Tareas");

            migrationBuilder.DropColumn(
                name: "LastModifiedAt",
                table: "Tareas");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "LastModifiedAt",
                table: "Pedidos");

            migrationBuilder.RenameTable(
                name: "Tareas",
                newName: "Tarea");

            migrationBuilder.RenameTable(
                name: "Productos",
                newName: "Producto");

            migrationBuilder.RenameTable(
                name: "Pedidos",
                newName: "Pedido");

            migrationBuilder.RenameTable(
                name: "DetallePedidos",
                newName: "DetallePedido");

            migrationBuilder.RenameTable(
                name: "Clientes",
                newName: "Cliente");

            migrationBuilder.RenameIndex(
                name: "IX_Tareas_PedidoId",
                table: "Tarea",
                newName: "IX_Tarea_PedidoId");

            migrationBuilder.RenameIndex(
                name: "IX_Tareas_EstadoTareaId",
                table: "Tarea",
                newName: "IX_Tarea_EstadoTareaId");

            migrationBuilder.RenameIndex(
                name: "IX_Tareas_ClienteId",
                table: "Tarea",
                newName: "IX_Tarea_ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Pedidos_ClienteId",
                table: "Pedido",
                newName: "IX_Pedido_ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_DetallePedidos_ProductoId",
                table: "DetallePedido",
                newName: "IX_DetallePedido_ProductoId");

            migrationBuilder.RenameIndex(
                name: "IX_DetallePedidos_PedidoId",
                table: "DetallePedido",
                newName: "IX_DetallePedido_PedidoId");

            migrationBuilder.AddColumn<int>(
                name: "EstadoTareaId1",
                table: "Tarea",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Tarea",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Pedido",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tarea",
                table: "Tarea",
                column: "TareaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Producto",
                table: "Producto",
                column: "ProductoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pedido",
                table: "Pedido",
                column: "PedidoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DetallePedido",
                table: "DetallePedido",
                column: "DetallePedidoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente",
                column: "ClienteId");

            migrationBuilder.CreateTable(
                name: "Rol",
                columns: table => new
                {
                    RolId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rol", x => x.RolId);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RolId = table.Column<int>(type: "INTEGER", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "BLOB", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "BLOB", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioId);
                    table.ForeignKey(
                        name: "FK_Usuario_Rol_RolId",
                        column: x => x.RolId,
                        principalTable: "Rol",
                        principalColumn: "RolId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tarea_EstadoTareaId1",
                table: "Tarea",
                column: "EstadoTareaId1");

            migrationBuilder.CreateIndex(
                name: "IX_Tarea_UsuarioId",
                table: "Tarea",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_UsuarioId",
                table: "Pedido",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_RolId",
                table: "Usuario",
                column: "RolId");

            migrationBuilder.AddForeignKey(
                name: "FK_DetallePedido_Pedido_PedidoId",
                table: "DetallePedido",
                column: "PedidoId",
                principalTable: "Pedido",
                principalColumn: "PedidoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetallePedido_Producto_ProductoId",
                table: "DetallePedido",
                column: "ProductoId",
                principalTable: "Producto",
                principalColumn: "ProductoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Cliente_ClienteId",
                table: "Pedido",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "ClienteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Usuario_UsuarioId",
                table: "Pedido",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tarea_Cliente_ClienteId",
                table: "Tarea",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "ClienteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tarea_EstadosTarea_EstadoTareaId",
                table: "Tarea",
                column: "EstadoTareaId",
                principalTable: "EstadosTarea",
                principalColumn: "EstadoTareaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tarea_EstadosTarea_EstadoTareaId1",
                table: "Tarea",
                column: "EstadoTareaId1",
                principalTable: "EstadosTarea",
                principalColumn: "EstadoTareaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tarea_Pedido_PedidoId",
                table: "Tarea",
                column: "PedidoId",
                principalTable: "Pedido",
                principalColumn: "PedidoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tarea_Usuario_UsuarioId",
                table: "Tarea",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
