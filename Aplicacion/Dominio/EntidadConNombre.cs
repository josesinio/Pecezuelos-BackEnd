using System.Data.Common;

namespace Aplicacion.Dominio;

public abstract class  EntidadConNombre
{
    public byte ID {get; set;}

    public string Nombre {get; set;}

    public EntidadConNombre(byte _ID,string _nombre){
        ID = _ID;
        Nombre = _nombre;
    }

    public void CambiarNombre(string NuevoNombre){
        Nombre = NuevoNombre;
    }
}
