using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class AlumnoDto
    {
        public int Id { get; set; }
        public int? legajo { get; set; }
        public string? Persona { get; set; }
        public string? Especialidad { get; set; }
        public string? Plan { get; set; }
        public string? nombre_usuario { get; set; }

    }
}