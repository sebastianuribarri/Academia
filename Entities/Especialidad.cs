using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Especialidad
    {
        [Key]
        [Required]
        public int id_especialidad { get; set; } 
        public string desc_especialidad { get; set; } = string.Empty;
        public bool activo { get; set; }

        public Especialidad()
        {
            this.activo = true;
        }

    }
}
