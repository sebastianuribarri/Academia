using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class EspecialidadDto
    {
        public int id_especialidad { get; set; } 
        public string desc_especialidad { get; set; } = string.Empty;

    }
}
