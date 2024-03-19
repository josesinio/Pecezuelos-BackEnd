using Api.Funcionalidades.Productos;
using Api.Persistencia;
using Aplicacion.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Api.Funcionalidades.Vendedores;

public interface IVendedorService{
    void AddProductoFromVendedor(Guid iDVendedor, Guid iDProducto);

    void CreateVendedor(VendedorDto vendedorDto);
    void DeleteVendedor(Guid IDVendedor);
    List<VendedorQueryDto> GetVendedores();
    void RemoveProductoFromVendedor(Guid iDVendedor, Guid iDProducto);

    void UpdateVendedor(Guid IDVendedor, VendedorDto vendedorDto);

}
public class VendedorService: IVendedorService
{
    public readonly PecezuelosDbContext context;
    public VendedorService(PecezuelosDbContext context)
    {
        this.context= context;
    }

    public void AddProductoFromVendedor(Guid iDVendedor, Guid iDProducto)
    {
        var Producto = context.Productos.FirstOrDefault(x=> x.ID == iDProducto);
        var vendedor = context.Vendedores.FirstOrDefault(x=> x.ID == iDProducto);

        if(Producto != null ! && vendedor != null)
        {
            vendedor.AgregarProducto(Producto);
            context.SaveChanges();
        }
    }


    public void CreateVendedor(VendedorDto vendedorDto)
    {
        context.Vendedores.Add(new Vendedor(new Guid(), vendedorDto.Nombre, vendedorDto.Email, vendedorDto.Contraseña));
        context.SaveChanges();
    }

    public void DeleteVendedor(Guid IDVendedor)
    {
        var vendedor = context.Vendedores.FirstOrDefault(x => x.ID == IDVendedor);
        
        if(vendedor != null){
            context.Vendedores.Remove(vendedor);
            context.SaveChanges();

        }
    }

    public List<VendedorQueryDto> GetVendedores()
    {
        return context.Vendedores
        .Include(x => x.Productos)
        .Select(x=> new VendedorQueryDto{
            ID = x.ID,
            Nombre = x.Nombre,
            Email = x.Email,
            Productos = x.Productos.Select(y => new ProductoQueryDto
            {
                Nombre = y.Nombre,
                Precio = y.Precio,
                RutaImagen = y.RutaImagen,
                Categoria = y.Categoria,
                Descripcion = y.Descripcion
            }).ToList()  
        }).ToList();
    }

    public void RemoveProductoFromVendedor(Guid iDVendedor, Guid iDProducto)
    {
        var Producto = context.Productos.FirstOrDefault(x=> x.ID == iDProducto);
        var vendedor = context.Vendedores.FirstOrDefault(x=> x.ID == iDVendedor);

        if(Producto != null ! && vendedor != null)
        {
            vendedor.EliminarProducto(Producto);
            context.SaveChanges();
        }
    }


    public void UpdateVendedor(Guid IDVendedor, VendedorDto vendedorDto)
    {
        var vendedor = context.Vendedores.FirstOrDefault(x => x.ID == IDVendedor);
        
        if(vendedor != null){
            
            vendedor.Nombre = vendedorDto.Nombre;
            vendedor.Email = vendedorDto.Email;
            vendedor.Contraseña = vendedorDto.Contraseña;

            context.SaveChanges();
        }
    }
}
