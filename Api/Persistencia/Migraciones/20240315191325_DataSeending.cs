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
            migrationBuilder.InsertData(
                table: "Carrito",
                columns: new[] { "IDCarrito", "IDCliente", "PrecioTotal" },
                values: new object[] { (byte)2, (byte)2, 1000 });

            migrationBuilder.InsertData(
                table: "Cliente",
                columns: new[] { "ID", "CarritoIDCarrito", "Contraseña", "Email", "Nombre" },
                values: new object[] { (byte)2, null, "12encotrasenia", "Josep123@gmail.com", "Josep" });

            migrationBuilder.InsertData(
                table: "Comentario",
                columns: new[] { "IdComentario", "IDCliente", "Mensaje", "ProductoID", "Valoracion" },
                values: new object[] { (byte)2, (byte)1, "una verga no estaba nada rica", null, 2 });

            migrationBuilder.InsertData(
                table: "Producto",
                columns: new[] { "ID", "CarritoIDCarrito", "Categoria", "Descripcion", "IDVendedor", "Imagen", "Nombre", "Precio", "Stock", "VendedorID" },
                values: new object[] { (byte)2, null, 3, "comida para peces dorados", (byte)1, "imagenes de alimento", "Alimento para peces", 1000, 32, null });

            migrationBuilder.InsertData(
                table: "Promocion",
                columns: new[] { "ID", "Descripcion", "Descuento", "FechaFin", "FechaInicio", "Nombre", "ProductoID" },
                values: new object[] { (byte)2, "este descuento se aplica al total del producto con un descuento de 10 pesos por navidad", 10, new DateTime(2024, 3, 17, 16, 13, 25, 152, DateTimeKind.Local).AddTicks(3042), new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Local), "Especial navidad", null });

            migrationBuilder.InsertData(
                table: "Vendedor",
                columns: new[] { "ID", "Contraseña", "Email", "Nombre" },
                values: new object[] { (byte)2, "12enPassword", "Josue123@gmail.com", "Josue" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Carrito",
                keyColumn: "IDCarrito",
                keyValue: (byte)2);

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "ID",
                keyValue: (byte)2);

            migrationBuilder.DeleteData(
                table: "Comentario",
                keyColumn: "IdComentario",
                keyValue: (byte)2);

            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "ID",
                keyValue: (byte)2);

            migrationBuilder.DeleteData(
                table: "Promocion",
                keyColumn: "ID",
                keyValue: (byte)2);

            migrationBuilder.DeleteData(
                table: "Vendedor",
                keyColumn: "ID",
                keyValue: (byte)2);
        }
    }
}
