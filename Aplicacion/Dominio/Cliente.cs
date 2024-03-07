namespace Aplicacion.Dominio;

public class Cliente : Usuario
{
    public byte IdCarrito{get; set;}
    public Cliente( byte _ID,string _nombre, string _email, string _contraseña, byte carrito) : base(_ID,_nombre, _email, _contraseña)
    {
        IdCarrito = carrito;
    }

}
