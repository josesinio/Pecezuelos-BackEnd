namespace Aplicacion.Dominio;

public abstract class Usuario: EntidadConNombre
{
    public string Email {get; set;}
    public string Contraseña {get; set;}
    protected Usuario(byte _ID, string _nombre,string _email, string _contraseña ) : base(_ID,_nombre)
    {
        Email= _email;
        Contraseña= _contraseña;
    }

}
