using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Curso
    {
        [Key][Required]
        public int id_curso { get; set; }
        public int? id_materia { get; set; }
        public int? id_comision { get; set; }
        public int? anio_calendario { get; set; }
        public int? cupo { get; set; }

        [ForeignKey("id_materia")]
        public Materia? Materia { get; set; }
        [ForeignKey("id_comision")]
        public Comision? Comision { get; set; }
    }
}