using System.ComponentModel.DataAnnotations;

namespace Aplicacion.Dominio;

public abstract class Usuario: EntidadConNombre
{
    [Required]
    [StringLength(50)]
    public string Email {get; set;}
    [Required]
    [StringLength(50)]
    
    private string _Contraseña;
    public string Contraseña
    {
        get { return _Contraseña; }
        set { _Contraseña = BCrypt.Net.BCrypt.HashPassword(value); }
    }

    public bool VerificarContrasena(string contrasenaTest)
    {
        return BCrypt.Net.BCrypt.Verify(contrasenaTest, this._Contraseña);
    }
    protected Usuario(byte ID, string Nombre,string Email, string Contraseña ) : base(ID, Nombre)
    {
        this.Email= Email;
        this.Contraseña= Contraseña;
    }

}
