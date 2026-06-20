using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class DictadoDto
    {
        [Key]
        [Required]
        public int id_dictado { get; set; }
        public string? desc_especialidad { get; set; }
        public string? desc_plan { get; set; }
        public string? desc_materia { get; set; }
        public int legajo { get; set; }
        public string? nombre_apellido { get; set; }

        public string? cargo { get; set;}

    }
}
