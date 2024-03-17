using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Persistencia.Migraciones
{
    /// <inheritdoc />
    public partial class DataSeending : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Carrito",
                columns: table => new
                {
                    IDCarrito = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IDCliente = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    PrecioTotal = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carrito", x => x.IDCarrito);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Vendedor",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Contraseña = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendedor", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CarritoIDCarrito = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Contraseña = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Cliente_Carrito_CarritoIDCarrito",
                        column: x => x.CarritoIDCarrito,
                        principalTable: "Carrito",
                        principalColumn: "IDCarrito");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IDVendedor = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Precio = table.Column<int>(type: "int", nullable: false),
                    RutaImagen = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Categoria = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CarritoIDCarrito = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    VendedorID = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Producto_Carrito_CarritoIDCarrito",
                        column: x => x.CarritoIDCarrito,
                        principalTable: "Carrito",
                        principalColumn: "IDCarrito");
                    table.ForeignKey(
                        name: "FK_Producto_Vendedor_VendedorID",
                        column: x => x.VendedorID,
                        principalTable: "Vendedor",
                        principalColumn: "ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Comentario",
                columns: table => new
                {
                    IdComentario = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IDCliente = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Mensaje = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Valoracion = table.Column<int>(type: "int", nullable: false),
                    ProductoID = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comentario", x => x.IdComentario);
                    table.ForeignKey(
                        name: "FK_Comentario_Producto_ProductoID",
                        column: x => x.ProductoID,
                        principalTable: "Producto",
                        principalColumn: "ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Promocion",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Descripcion = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descuento = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ProductoID = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promocion", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Promocion_Producto_ProductoID",
                        column: x => x.ProductoID,
                        principalTable: "Producto",
                        principalColumn: "ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Cliente",
                columns: new[] { "ID", "CarritoIDCarrito", "Contraseña", "Email", "Nombre" },
                values: new object[] { new Guid("dbc2e4a5-ad05-4d63-9857-f0f2fe61445a"), null, "$2a$11$TN//oztqzCmguyuMtjDBxeZbD1rsUUVBpxnY/5zbnF63fiP/8veXa", "Josep123@gmail.com", "Josep" });

            migrationBuilder.InsertData(
                table: "Promocion",
                columns: new[] { "ID", "Descripcion", "Descuento", "FechaFin", "FechaInicio", "Nombre", "ProductoID" },
                values: new object[] { new Guid("fd032618-a572-46b1-8842-ca194063c32d"), "un descuento de 10 pesos por navidad", -15m, new DateTime(2024, 3, 19, 18, 52, 37, 677, DateTimeKind.Local).AddTicks(3395), new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Local), "Especial navidad", null });

            migrationBuilder.InsertData(
                table: "Vendedor",
                columns: new[] { "ID", "Contraseña", "Email", "Nombre" },
                values: new object[] { new Guid("a3c68f24-1187-489c-8380-e584d8c2ba5f"), "$2a$11$rwhLoDTdcYkFiKGDePKu/O5OkyHQyaBwm2dGzLG9WnDB1x1HZ5xq.", "Josue123@gmail.com", "Josue" });

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_CarritoIDCarrito",
                table: "Cliente",
                column: "CarritoIDCarrito");

            migrationBuilder.CreateIndex(
                name: "IX_Comentario_ProductoID",
                table: "Comentario",
                column: "ProductoID");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_CarritoIDCarrito",
                table: "Producto",
                column: "CarritoIDCarrito");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_VendedorID",
                table: "Producto",
                column: "VendedorID");

            migrationBuilder.CreateIndex(
                name: "IX_Promocion_ProductoID",
                table: "Promocion",
                column: "ProductoID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Comentario");

            migrationBuilder.DropTable(
                name: "Promocion");

            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.DropTable(
                name: "Carrito");

            migrationBuilder.DropTable(
                name: "Vendedor");
        }
    }
}
