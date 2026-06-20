using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class DocenteDto
    {
        public int Id { get; set; }
        public int? legajo { get; set; }
        public string? Persona { get; set; }
        public string? nombre_usuario { get; set; }
        public bool cambia_clave { get; set; }
        

    }
}