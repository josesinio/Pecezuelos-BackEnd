namespace Aplicacion.Dominio;

public class Promocion(byte _ID,string _nombre, string _descripcion , int _descuento, DateTime _Fechainicio, DateTime _FechaFin) : EntidadConNombre(_ID,_nombre)
{
    public string Descripcion = _descripcion;
    public int Descuento = _descuento;
    public DateTime FechaInicio = _Fechainicio;
    public DateTime FechaFin = _FechaFin;

}
