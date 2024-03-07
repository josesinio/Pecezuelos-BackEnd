namespace Aplicacion.Dominio;

public class Vendedor : Usuario
{
    public List<Producto> Productos = new List<Producto>();
    public Vendedor(byte _ID , string _nombre, string _email, string _contraseña) : base(_ID,_nombre, _email, _contraseña)
    {
    }

}
