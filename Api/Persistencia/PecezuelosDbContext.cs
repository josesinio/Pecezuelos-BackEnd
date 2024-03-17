using Aplicacion.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Api.Persistencia;

public class PecezuelosDbContext(DbContextOptions<PecezuelosDbContext> options) : DbContext(options)
{
    public DbSet<Producto> Productos {get; set;}
    public DbSet<Cliente> Clientes {get; set;}
    public DbSet<Carrito> Carritos {get; set;}
    public DbSet<Vendedor> Vendedores {get; set;}
    public DbSet<Promocion> Promociones {get; set;}
    public DbSet<Comentario> Comentarios {get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Promocion>().HasData(
            new Promocion(1, "Especial navidad", "un descuento de 10 pesos por navidad", 0-15,  DateTime.Today, DateTime.Now.AddDays(2))
        );
        modelBuilder.Entity<Vendedor>().HasData(
            new Vendedor(1, "Josue", "Josue123@gmail.com", "12enPassword")
        );
        modelBuilder.Entity<Producto>().HasData(
            new Producto(1,"Alimento para peces", 1, 1000, "imagenes de alimento",Categoria.Comida, 32, "comida para peces dorados")
        );
        modelBuilder.Entity<Cliente>().HasData(
            new Cliente(1, "Josep", "Josep123@gmail.com", "12encotrasenia")
        );
        modelBuilder.Entity<Carrito>().HasData(
            new Carrito(1, 1, 1000)
        );
        modelBuilder.Entity<Comentario>().HasData(
            new Comentario(1, 1, "una verga no estaba nada rica", Valoracion.Malo)
        );
    }
}

