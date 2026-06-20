using Domain.Validations;
using Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Domain.Services
{
    public class CursoService
    {
        public void Add(Curso curso)
        {

            using var context = new AcademiaContext();
            if(CursoValidation.isValid(curso))
            {
                context.Cursos.Add(curso);

                context.SaveChanges();
            }
            
        }

        public void Delete(int id)
        {
            using var context = new AcademiaContext();
            Curso? cursoToDelete = context.Cursos.Find(id);

            if (cursoToDelete != null)
            {
                context.Cursos.Remove(cursoToDelete);
                context.SaveChanges();
            }
        }

        public Curso? Get(int id)
        {
            using var context = new AcademiaContext();
            return context.Cursos.Find(id);
        }

        public List<CursoDto> GetAll()
        {
            using var context = new AcademiaContext();
            var cursos = context.Cursos
                .Include(c => c.Comision)
                .Include(c => c.Materia)
                .ThenInclude(m => m.Plan)
                .ThenInclude(p => p.Especialidad);

            return cursos.Select(cursos => CursoService.ToDto(cursos)).ToList();
        }

        public List<Curso> GetByUsuario(int usuarioId)
        {
            using var context = new AcademiaContext();

            int anioActual = DateTime.Now.Year;

            Usuario? usuario = context.Usuarios
                           .FirstOrDefault(u => u.id_usuario == usuarioId);

            if (usuario?.id_plan == null)
            {
                // Si el usuario no tiene un plan asociado, no hay cursos disponibles
                return new List<Curso>();
            }

            // Materias del plan del usuario
            var materiasPlan = context.Materias
                                       .Where(m => m.id_plan == usuario.id_plan)
                                       .ToList();

            // Materias aprobadas o con inscripción regular
            var materiasAprobadas = context.Inscripciones
                                           .Where(i => i.id_usuario == usuarioId &&
                                                       (i.condicion == "Regular" || i.condicion == "Aprobado" || i.condicion == "Cursando"))
                                           .Select(i => i.Curso.id_materia)
                                           .Distinct()
                                           .ToList();

            // Filtrar las materias que el usuario no ha aprobado
            var materiasNoAprobadas = materiasPlan
                                      .Where(m => !materiasAprobadas.Contains(m.id_materia))
                                      .Select(m => m.id_materia)
                                      .ToList();

            // Buscar los cursos disponibles para las materias no aprobadas
            var cursosDisponibles = context.Cursos
                                           .Where(c => c.anio_calendario == anioActual &&
                                                       materiasNoAprobadas.Contains(c.id_materia ?? 0))
                                           .Include(c => c.Materia)  
                                           .Include(c => c.Comision) 
                                           .ToList();

            return cursosDisponibles;
        }

        public void Update(Curso curso)
        {
            using var context = new AcademiaContext();
            Curso? cursoToUpdate = context.Cursos.Find(curso.id_curso);

            if (cursoToUpdate != null && CursoValidation.isValid(curso))
            {
                cursoToUpdate.cupo = curso.cupo;
                context.SaveChanges();
            }
        }

        public static CursoDto ToDto (Curso curso)
        {
            return new CursoDto
            {
                id_curso = curso.id_curso,
                Especialidad = curso.Materia?.Plan?.Especialidad?.desc_especialidad,
                Plan = curso.Materia?.Plan?.desc_plan,
                Materia = curso.Materia?.desc_materia,
                Comision = curso.Comision?.desc_comision,
                anio_calendario = curso.anio_calendario,
                cupo = curso.cupo,
            };
        }
    }
}
