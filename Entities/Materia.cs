    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    namespace Entities
    {
        public class Materia
        {
            [Key]
            [Required]
            public int id_materia { get; set; }
            public int id_plan { get; set; }
            public string? desc_materia { get; set; } 
            public int hs_semanales { get; set; }
            public int hs_totales { get; set; }

            [ForeignKey("id_plan")]
            public Plan? Plan { get; set; }
            public bool activo { get; set; }

        public Materia()
        {
            this.activo = true;
        }

    }
}
