namespace Aplicacion.Dominio;

public class Carrito(byte _IdCarrito, byte _Idcliente, int _precioTotal)
{
    public byte IDCarrito = _IdCarrito;
    public byte IDCliente = _Idcliente;
    public int PrecioTotal = _precioTotal;
    public List<Producto> Productos = new List<Producto>();

}
