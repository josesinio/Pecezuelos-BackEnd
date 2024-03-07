using Aplicacion.Dominio;

namespace Api.Funcionalidades.Productos;

public interface IProductoService{
    List<Producto> GetProductos();
}
public class ProductoService : IProductoService
{
    List<Producto> productos;

    public ProductoService()
    {
        productos= new List<Producto>(){
            new Producto(1,"Pecera", 1, 122, "Pecera de dos metros.img",Categoria.Pecera,12, null, "Pecera que mide 2x2 metros con capacidad de 2 peces  grandes")
        };
    }
    public List<Producto> GetProductos()
    {
        return productos;
    }

}
