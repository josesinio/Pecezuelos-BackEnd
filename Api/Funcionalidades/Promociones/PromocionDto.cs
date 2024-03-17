namespace Api.Funcionalidades.Promociones;

public class PromocionDto
{
    public required byte ID {get; set;}
    public required string Nombre {get; set;}
    public required string Descripcion {get; set;}
    public required decimal Descuento {get; set;}
    public required DateTime FechaInicio {get; set;}
    public required DateTime FechaFin {get; set;}
}
