﻿// <auto-generated />
using System;
using Api.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Api.Persistencia.Migraciones
{
    [DbContext(typeof(PecezuelosDbContext))]
    partial class PecezuelosDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Aplicacion.Dominio.Carrito", b =>
                {
                    b.Property<byte>("IDCarrito")
                        .HasColumnType("tinyint unsigned");

                    b.Property<byte>("IDCliente")
                        .HasColumnType("tinyint unsigned");

                    b.Property<int>("PrecioTotal")
                        .HasColumnType("int");

                    b.HasKey("IDCarrito");

                    b.HasIndex("IDCliente")
                        .IsUnique();

                    b.ToTable("Carrito");
                });

            modelBuilder.Entity("Aplicacion.Dominio.Cliente", b =>
                {
                    b.Property<byte>("ID")
                        .HasColumnType("tinyint unsigned");

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Aplicacion.Dominio.Comentario", b =>
                {
                    b.Property<byte>("IdComentario")
                        .HasColumnType("tinyint unsigned");

                    b.Property<byte>("IDCliente")
                        .HasColumnType("tinyint unsigned");

                    b.Property<string>("Mensaje")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<byte?>("ProductoID")
                        .HasColumnType("tinyint unsigned");

                    b.Property<int>("Valoracion")
                        .HasColumnType("int");

                    b.HasKey("IdComentario");

                    b.HasIndex("ProductoID");

                    b.ToTable("Comentario");
                });

            modelBuilder.Entity("Aplicacion.Dominio.Producto", b =>
                {
                    b.Property<byte>("ID")
                        .HasColumnType("tinyint unsigned");

                    b.Property<byte?>("CarritoIDCarrito")
                        .HasColumnType("tinyint unsigned");

                    b.Property<int>("Categoria")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<byte>("IDVendedor")
                        .HasColumnType("tinyint unsigned");

                    b.Property<string>("Imagen")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("Precio")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<byte?>("VendedorID")
                        .HasColumnType("tinyint unsigned");

                    b.HasKey("ID");

                    b.HasIndex("CarritoIDCarrito");

                    b.HasIndex("VendedorID");

                    b.ToTable("Producto");
                });

            modelBuilder.Entity("Aplicacion.Dominio.Promocion", b =>
                {
                    b.Property<byte>("ID")
                        .HasColumnType("tinyint unsigned");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("Descuento")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<byte?>("ProductoID")
                        .HasColumnType("tinyint unsigned");

                    b.HasKey("ID");

                    b.HasIndex("ProductoID");

                    b.ToTable("Promocion");
                });

            modelBuilder.Entity("Aplicacion.Dominio.Vendedor", b =>
                {
                    b.Property<byte>("ID")
                        .HasColumnType("tinyint unsigned");

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

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
                });

            modelBuilder.Entity("Aplicacion.Dominio.Carrito", b =>
                {
                    b.HasOne("Aplicacion.Dominio.Cliente", "Cliente")
                        .WithOne("Carrito")
                        .HasForeignKey("Aplicacion.Dominio.Carrito", "IDCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
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

            modelBuilder.Entity("Aplicacion.Dominio.Cliente", b =>
                {
                    b.Navigation("Carrito");
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
