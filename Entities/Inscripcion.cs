    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    namespace Entities
    {
        public class Inscripcion
        {
            [Key]
            [Required]
            public int id_inscripcion { get; set; }
            public int id_usuario { get; set; }
            public int id_curso { get; set; }
            public string? condicion { get; set; }
            public int? nota { get; set; }

            [ForeignKey("id_usuario")] 
            public Usuario? Usuario { get; set; }

            [ForeignKey("id_curso")]
            public Curso? Curso { get; set; }
        }
    }
