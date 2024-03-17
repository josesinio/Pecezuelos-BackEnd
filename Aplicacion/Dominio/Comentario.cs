using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aplicacion.Dominio;
[Table("Comentario")]
public class Comentario
{
    [Key]
    [Required]
    public Guid IdComentario {get; set;}
    [ForeignKey("IdCliente")]
    [Required]
    public Guid IDCliente {get; set;}
    [Required]
    [StringLength(50)]
    public string Mensaje {get; set;}
    public Valoracion Valoracion {get; set;}

    public Comentario(Guid IdComentario,Guid IDCliente,string Mensaje, Valoracion Valoracion)
    {
        this.IdComentario= IdComentario;
        this.IDCliente = IDCliente;
        this.Mensaje =Mensaje;
        this.Valoracion= Valoracion;
    }

}
