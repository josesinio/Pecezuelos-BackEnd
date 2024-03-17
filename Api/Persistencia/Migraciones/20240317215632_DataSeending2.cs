using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Persistencia.Migraciones
{
    /// <inheritdoc />
    public partial class DataSeending2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "ID",
                keyValue: new Guid("dbc2e4a5-ad05-4d63-9857-f0f2fe61445a"));

            migrationBuilder.DeleteData(
                table: "Promocion",
                keyColumn: "ID",
                keyValue: new Guid("fd032618-a572-46b1-8842-ca194063c32d"));

            migrationBuilder.DeleteData(
                table: "Vendedor",
                keyColumn: "ID",
                keyValue: new Guid("a3c68f24-1187-489c-8380-e584d8c2ba5f"));

            migrationBuilder.InsertData(
                table: "Carrito",
                columns: new[] { "IDCarrito", "IDCliente", "PrecioTotal" },
                values: new object[] { new Guid("1fc7b638-fe4f-4e45-9c66-0cacc3e8c657"), new Guid("f7bfad7a-06d4-40c6-9636-877c28e9dd62"), 0 });

            migrationBuilder.InsertData(
                table: "Cliente",
                columns: new[] { "ID", "CarritoIDCarrito", "Contraseña", "Email", "Nombre" },
                values: new object[] { new Guid("d489f3d5-5859-49c7-8389-d806ca4789f1"), null, "$2a$11$TqG.fqWGPFLSqdxINUzoC.NQvqlEcRqTGIex.oYDAlaQfGnSqsB8W", "Josep123@gmail.com", "Josep" });

            migrationBuilder.InsertData(
                table: "Comentario",
                columns: new[] { "IdComentario", "IDCliente", "Mensaje", "ProductoID", "Valoracion" },
                values: new object[] { new Guid("abc58c0d-6381-4e5e-91ef-2af76df26b63"), new Guid("f7bfad7a-06d4-40c6-9636-877c28e9dd62"), "una verga no estaba nada rica", null, 2 });

            migrationBuilder.InsertData(
                table: "Producto",
                columns: new[] { "ID", "CarritoIDCarrito", "Categoria", "Descripcion", "IDVendedor", "Nombre", "Precio", "RutaImagen", "Stock", "VendedorID" },
                values: new object[] { new Guid("7ac3a473-5007-4876-9f2e-71668bde5bc0"), null, 3, "comida para peces dorados", new Guid("cc2d5ff9-a268-43d9-934c-67a6721269a9"), "Alimento para peces", 1000, "imagenes de alimento", 32, null });

            migrationBuilder.InsertData(
                table: "Promocion",
                columns: new[] { "ID", "Descripcion", "Descuento", "FechaFin", "FechaInicio", "Nombre", "ProductoID" },
                values: new object[] { new Guid("04e58160-b176-48eb-9631-7e7fee01a281"), "un descuento de 10 pesos por navidad", -15m, new DateTime(2024, 3, 19, 18, 56, 31, 662, DateTimeKind.Local).AddTicks(5586), new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Local), "Especial navidad", null });

            migrationBuilder.InsertData(
                table: "Vendedor",
                columns: new[] { "ID", "Contraseña", "Email", "Nombre" },
                values: new object[] { new Guid("04e31f1d-feb0-4228-bb95-89303f5f31a5"), "$2a$11$4NNk42NXjOVnsy8yEVwdGOGtvuCFJ8QSFGoUgm/vKBwrS6JiDl/NK", "Josue123@gmail.com", "Josue" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Carrito",
                keyColumn: "IDCarrito",
                keyValue: new Guid("1fc7b638-fe4f-4e45-9c66-0cacc3e8c657"));

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "ID",
                keyValue: new Guid("d489f3d5-5859-49c7-8389-d806ca4789f1"));

            migrationBuilder.DeleteData(
                table: "Comentario",
                keyColumn: "IdComentario",
                keyValue: new Guid("abc58c0d-6381-4e5e-91ef-2af76df26b63"));

            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "ID",
                keyValue: new Guid("7ac3a473-5007-4876-9f2e-71668bde5bc0"));

            migrationBuilder.DeleteData(
                table: "Promocion",
                keyColumn: "ID",
                keyValue: new Guid("04e58160-b176-48eb-9631-7e7fee01a281"));

            migrationBuilder.DeleteData(
                table: "Vendedor",
                keyColumn: "ID",
                keyValue: new Guid("04e31f1d-feb0-4228-bb95-89303f5f31a5"));

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
        }
    }
}
