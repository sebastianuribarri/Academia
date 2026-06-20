using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Comision
    {
        [Key]
        [Required]
        public int id_comision { get; set; }
        public int id_plan { get; set; }

        [ForeignKey("id_plan")]
        public Plan? Plan { get; set; }
        public string? desc_comision { get; set; }
        public int anio_especialidad { get; set; }
        public bool activo { get; set; }

        public Comision()
        {
            this.activo = true;
        }
    }
}