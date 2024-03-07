namespace Aplicacion.Dominio;

public class Comentario(byte _IdCliente,string _mensaje, Valoracion _valoracion)
{
    public byte IDCliente = _IdCliente;
    public string Mensaje = _mensaje;
    public Valoracion Valoracion = _valoracion;

}
