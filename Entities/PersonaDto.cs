using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class PersonaDto
    {
        [Key]
        [Required]
        public int id_persona { get; set; } 
        public string? nombre { get; set; } 
        public string? apellido { get; set; }
        public string? direccion { get; set; } 
        public string? email { get; set; }
        public string? telefono { get; set; } 
        public DateTime fecha_nac { get; set; }

    }

    
}
