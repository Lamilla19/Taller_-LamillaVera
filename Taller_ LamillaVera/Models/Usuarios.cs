using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Taller__LamillaVera.Models
{
    public class Usuarios
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "Varchar(20)")]
        public String NombreUser { get; set; }
        [Required]
        [Column(TypeName = "Varchar(20)")]
        public String clave { get; set; }
        public Boolean estado { get; set; }
        public int GeneroId { get; set; } // FK con la tabla Genero
        public Genero Genero { get; set; }
        public List<HistorialAcceso> ListHistorialAcceso { get; set; }
    }
}
