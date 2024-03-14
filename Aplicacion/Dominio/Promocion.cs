using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aplicacion.Dominio;
[Table("Promocion")]
public class Promocion: EntidadConNombre
{
    [Required]
    [StringLength(50)]
    public string Descripcion {get; set;}
    [Required]
    public int Descuento {get; set;}

    [Required]
    public DateTime FechaInicio {get; set;}

    [Required]
    public DateTime FechaFin {get; set;}


    public Promocion(byte ID, string Nombre, string Descripcion , int Descuento, DateTime FechaInicio, DateTime FechaFin) : base(ID, Nombre)
    {
        this.Descripcion =Descripcion;
        this.Descuento =Descuento;
        this.FechaInicio = FechaInicio;
        this.FechaFin= FechaFin;

    }

}
