using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class CursoDto
    {
        public int id_curso { get; set; }
        public string? Especialidad { get; set; }
        public string? Plan { get; set; }
        public string? Materia { get; set; }
        public string? Comision { get; set; }
        public int? anio_calendario { get; set; }
        public int? cupo { get; set; }

    }
}