using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class UsuarioDto
    {
        public int id_usuario { get; set; }
        public string? nombre_usuario { get; set; }
        public string? Persona { get; set; }

    }
}