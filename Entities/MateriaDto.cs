    using System.ComponentModel.DataAnnotations;

    namespace Entities
    {
        public class MateriaDto
        {
            public int Id { get; set; }
            public string? Especialidad { get; set; }
            public string? Plan { get; set; }
            public string? Descripcion { get; set; } 
            public int hs_semanales { get; set; }
            public int hs_totales { get; set; }
            
        }
    }
