using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Dictado
    {
        [Key]
        [Required]
        public int id_dictado { get; set; }

        public int id_curso { get; set; }
        [ForeignKey("id_curso")]
        public Curso? Curso { get; set; }

        public int id_docente { get; set; }
        [ForeignKey("id_docente")]
        public Usuario? Usuario { get; set; }

        public string? cargo { get; set; }

    }
}
