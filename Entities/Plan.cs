using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Plan
    {
        [Key]
        [Required]
        public int id_plan { get; set; }
        public int id_especialidad { get; set; }

        [ForeignKey("id_especialidad")]
        public Especialidad? Especialidad { get; set; }

        public string desc_plan { get; set; }
        public bool activo { get; set; }
        public Plan()
        {
            this.activo = true;
        }

    }
}
