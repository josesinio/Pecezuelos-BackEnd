namespace Aplicacion.Dominio;

public class Producto(byte _ID,string _nombre, byte _IDVendedor, int _precio, string _imagen, Categoria _categoria, int _stock, Promocion? _promocion, string _descripcion) : EntidadConNombre(_ID ,_nombre)
{
    public byte IDVendedor= _IDVendedor;
    public int Precio = _precio;
    public string Imagen = _imagen;
    public Categoria Categoria = _categoria;
    public int Stock = _stock;
    public Promocion? Promocion= _promocion;
    public string Descripcion = _descripcion;
    public List<Comentario> Comentarios= new List<Comentario>();

}