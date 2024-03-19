using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Persistencia.Migraciones
{
    /// <inheritdoc />
    public partial class DataSeending3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "Carrito",
                columns: new[] { "IDCarrito", "IDCliente", "PrecioTotal" },
                values: new object[] { new Guid("3278ad53-acec-496f-ad83-540f0947b8d2"), new Guid("f7bfad7a-06d4-40c6-9636-877c28e9dd62"), 0 });

            migrationBuilder.InsertData(
                table: "Cliente",
                columns: new[] { "ID", "CarritoIDCarrito", "Contraseña", "Email", "Nombre" },
                values: new object[] { new Guid("35bc6f8a-3dc9-4cf7-804c-7d6ec385aed5"), null, "$2a$11$cwqZdxcXnOVu8kYDLKOikOmm3X5UEBLiBCdSmh7mFrZ/hPpRh.Fhe", "Josep123@gmail.com", "Josep" });

            migrationBuilder.InsertData(
                table: "Comentario",
                columns: new[] { "IdComentario", "IDCliente", "Mensaje", "ProductoID", "Valoracion" },
                values: new object[] { new Guid("6aab7f1b-aaca-4b49-9c9c-a6cd974cfa3a"), new Guid("f7bfad7a-06d4-40c6-9636-877c28e9dd62"), "una verga no estaba nada rica", null, 2 });

            migrationBuilder.InsertData(
                table: "Producto",
                columns: new[] { "ID", "CarritoIDCarrito", "Categoria", "Descripcion", "IDVendedor", "Nombre", "Precio", "RutaImagen", "Stock", "VendedorID" },
                values: new object[] { new Guid("9d490133-491e-411d-9147-5f6a28d4ace8"), null, 3, "comida para peces dorados", new Guid("cc2d5ff9-a268-43d9-934c-67a6721269a9"), "Alimento para peces", 1000, "imagenes de alimento", 32, null });

            migrationBuilder.InsertData(
                table: "Promocion",
                columns: new[] { "ID", "Descripcion", "Descuento", "FechaFin", "FechaInicio", "Nombre", "ProductoID" },
                values: new object[] { new Guid("76e2fb63-53af-4bbe-9f7a-01b764c0143a"), "un descuento de 10 pesos por navidad", -15m, new DateTime(2024, 3, 20, 17, 33, 12, 97, DateTimeKind.Local).AddTicks(2103), new DateTime(2024, 3, 18, 0, 0, 0, 0, DateTimeKind.Local), "Especial navidad", null });

            migrationBuilder.InsertData(
                table: "Vendedor",
                columns: new[] { "ID", "Contraseña", "Email", "Nombre" },
                values: new object[] { new Guid("a672c28c-4710-4efc-8abb-5acc2a5b3014"), "$2a$11$HO6RW1/bGA1M.O5nYgNjNejljEN9DEQAiz.hDuiR3eEx2snO4eYfu", "Josue123@gmail.com", "Josue" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Carrito",
                keyColumn: "IDCarrito",
                keyValue: new Guid("3278ad53-acec-496f-ad83-540f0947b8d2"));

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "ID",
                keyValue: new Guid("35bc6f8a-3dc9-4cf7-804c-7d6ec385aed5"));

            migrationBuilder.DeleteData(
                table: "Comentario",
                keyColumn: "IdComentario",
                keyValue: new Guid("6aab7f1b-aaca-4b49-9c9c-a6cd974cfa3a"));

            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "ID",
                keyValue: new Guid("9d490133-491e-411d-9147-5f6a28d4ace8"));

            migrationBuilder.DeleteData(
                table: "Promocion",
                keyColumn: "ID",
                keyValue: new Guid("76e2fb63-53af-4bbe-9f7a-01b764c0143a"));

            migrationBuilder.DeleteData(
                table: "Vendedor",
                keyColumn: "ID",
                keyValue: new Guid("a672c28c-4710-4efc-8abb-5acc2a5b3014"));

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
    }
}
