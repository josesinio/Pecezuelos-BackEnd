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
        modelBuilder.Entity<Cliente>()
            .HasOne(c => c.Carrito)
            .WithOne(i => i.Cliente)
            .HasForeignKey<Carrito>(b => b.IDCliente);
    }
}

