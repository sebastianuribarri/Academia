using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Usuario
    {
        [Key][Required]
        public int id_usuario { get; set; }
        public string? nombre_usuario { get; set; }
        public string? clave { get; set; } 
        public int id_persona { get; set; }
        public int tipo_usuario { get; set; }
        public int? legajo { get; set; }
        public int? id_plan { get; set; }

        [ForeignKey("id_persona")]
        public Persona? Persona { get; set; }
        [ForeignKey("id_plan")]
        public Plan? Plan { get; set; }
        public bool activo { get; set; }

        public Usuario()
        {
            this.activo = true;
        }


    }
}