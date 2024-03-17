﻿// <auto-generated />
using System;
using Api.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Api.Persistencia.Migraciones
{
    [DbContext(typeof(PecezuelosDbContext))]
    [Migration("20240317215632_DataSeending2")]
    partial class DataSeending2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Aplicacion.Dominio.Carrito", b =>
                {
                    b.Property<Guid>("IDCarrito")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("IDCliente")
                        .HasColumnType("char(36)");

                    b.Property<int>("PrecioTotal")
                        .HasColumnType("int");

                    b.HasKey("IDCarrito");

                    b.ToTable("Carrito");

                    b.HasData(
                        new
                        {
                            IDCarrito = new Guid("1fc7b638-fe4f-4e45-9c66-0cacc3e8c657"),
                            IDCliente = new Guid("f7bfad7a-06d4-40c6-9636-877c28e9dd62"),
                            PrecioTotal = 0
                        });
                });

            modelBuilder.Entity("Aplicacion.Dominio.Cliente", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("CarritoIDCarrito")
                        .HasColumnType("char(36)");

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("ID");

                    b.HasIndex("CarritoIDCarrito");

                    b.ToTable("Cliente");

                    b.HasData(
                        new
                        {
                            ID = new Guid("d489f3d5-5859-49c7-8389-d806ca4789f1"),
                            Contraseña = "$2a$11$TqG.fqWGPFLSqdxINUzoC.NQvqlEcRqTGIex.oYDAlaQfGnSqsB8W",
                            Email = "Josep123@gmail.com",
                            Nombre = "Josep"
                        });
                });

            modelBuilder.Entity("Aplicacion.Dominio.Comentario", b =>
                {
                    b.Property<Guid>("IdComentario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("IDCliente")
                        .HasColumnType("char(36)");

                    b.Property<string>("Mensaje")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<Guid?>("ProductoID")
                        .HasColumnType("char(36)");

                    b.Property<int>("Valoracion")
                        .HasColumnType("int");

                    b.HasKey("IdComentario");

                    b.HasIndex("ProductoID");

                    b.ToTable("Comentario");

                    b.HasData(
                        new
                        {
                            IdComentario = new Guid("abc58c0d-6381-4e5e-91ef-2af76df26b63"),
                            IDCliente = new Guid("f7bfad7a-06d4-40c6-9636-877c28e9dd62"),
                            Mensaje = "una verga no estaba nada rica",
                            Valoracion = 2
                        });
                });

            modelBuilder.Entity("Aplicacion.Dominio.Producto", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("CarritoIDCarrito")
                        .HasColumnType("char(36)");

                    b.Property<int>("Categoria")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("IDVendedor")
                        .HasColumnType("char(36)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("Precio")
                        .HasColumnType("int");

                    b.Property<string>("RutaImagen")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<Guid?>("VendedorID")
                        .HasColumnType("char(36)");

                    b.HasKey("ID");

                    b.HasIndex("CarritoIDCarrito");

                    b.HasIndex("VendedorID");

                    b.ToTable("Producto");

                    b.HasData(
                        new
                        {
                            ID = new Guid("7ac3a473-5007-4876-9f2e-71668bde5bc0"),
                            Categoria = 3,
                            Descripcion = "comida para peces dorados",
                            IDVendedor = new Guid("cc2d5ff9-a268-43d9-934c-67a6721269a9"),
                            Nombre = "Alimento para peces",
                            Precio = 1000,
                            RutaImagen = "imagenes de alimento",
                            Stock = 32
                        });
                });

            modelBuilder.Entity("Aplicacion.Dominio.Promocion", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<decimal>("Descuento")
                        .HasColumnType("decimal(65,30)");

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<Guid?>("ProductoID")
                        .HasColumnType("char(36)");

                    b.HasKey("ID");

                    b.HasIndex("ProductoID");

                    b.ToTable("Promocion");

                    b.HasData(
                        new
                        {
                            ID = new Guid("04e58160-b176-48eb-9631-7e7fee01a281"),
                            Descripcion = "un descuento de 10 pesos por navidad",
                            Descuento = -15m,
                            FechaFin = new DateTime(2024, 3, 19, 18, 56, 31, 662, DateTimeKind.Local).AddTicks(5586),
                            FechaInicio = new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Especial navidad"
                        });
                });

            modelBuilder.Entity("Aplicacion.Dominio.Vendedor", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Vendedor");

                    b.HasData(
                        new
                        {
                            ID = new Guid("04e31f1d-feb0-4228-bb95-89303f5f31a5"),
                            Contraseña = "$2a$11$4NNk42NXjOVnsy8yEVwdGOGtvuCFJ8QSFGoUgm/vKBwrS6JiDl/NK",
                            Email = "Josue123@gmail.com",
                            Nombre = "Josue"
                        });
                });

            modelBuilder.Entity("Aplicacion.Dominio.Cliente", b =>
                {
                    b.HasOne("Aplicacion.Dominio.Carrito", "Carrito")
                        .WithMany()
                        .HasForeignKey("CarritoIDCarrito");

                    b.Navigation("Carrito");
                });

            modelBuilder.Entity("Aplicacion.Dominio.Comentario", b =>
                {
                    b.HasOne("Aplicacion.Dominio.Producto", null)
                        .WithMany("Comentarios")
                        .HasForeignKey("ProductoID");
                });

            modelBuilder.Entity("Aplicacion.Dominio.Producto", b =>
                {
                    b.HasOne("Aplicacion.Dominio.Carrito", null)
                        .WithMany("Productos")
                        .HasForeignKey("CarritoIDCarrito");

                    b.HasOne("Aplicacion.Dominio.Vendedor", null)
                        .WithMany("Productos")
                        .HasForeignKey("VendedorID");
                });

            modelBuilder.Entity("Aplicacion.Dominio.Promocion", b =>
                {
                    b.HasOne("Aplicacion.Dominio.Producto", null)
                        .WithMany("Promociones")
                        .HasForeignKey("ProductoID");
                });

            modelBuilder.Entity("Aplicacion.Dominio.Carrito", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("Aplicacion.Dominio.Producto", b =>
                {
                    b.Navigation("Comentarios");

                    b.Navigation("Promociones");
                });

            modelBuilder.Entity("Aplicacion.Dominio.Vendedor", b =>
                {
                    b.Navigation("Productos");
                });
#pragma warning restore 612, 618
        }
    }
}