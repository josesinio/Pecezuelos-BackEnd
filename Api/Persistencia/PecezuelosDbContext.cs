using Aplicacion.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

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
            new Promocion(Guid.NewGuid(), "Especial navidad", "un descuento de 10 pesos por navidad", 0-15,  DateTime.Today, DateTime.Now.AddDays(2))
        );
        modelBuilder.Entity<Vendedor>().HasData(
            new Vendedor(Guid.NewGuid(), "Josue", "Josue123@gmail.com", "12enPassword")
        );
        modelBuilder.Entity<Producto>().HasData(
            new Producto(Guid.NewGuid(),"Alimento para peces", new Guid("cc2d5ff9-a268-43d9-934c-67a6721269a9"), 1000, "imagenes de alimento",Categoria.Comida, 32, "comida para peces dorados")
        );
        modelBuilder.Entity<Cliente>().HasData(
            
            new Cliente(Guid.NewGuid(), "Josep", "Josep123@gmail.com", "12encotrasenia")
        );
        modelBuilder.Entity<Carrito>().HasData(
            new Carrito(Guid.NewGuid(), new Guid("f7bfad7a-06d4-40c6-9636-877c28e9dd62"))
        );
        modelBuilder.Entity<Comentario>().HasData(
            new Comentario(Guid.NewGuid(),new Guid("f7bfad7a-06d4-40c6-9636-877c28e9dd62"), "una verga no estaba nada rica", Valoracion.Malo)
        );
    }
}

