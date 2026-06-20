using Entities;
using Microsoft.EntityFrameworkCore;

namespace Domain.Services
{
    
    public class InscripcionService
    {

        public void Add(InscripcionRequest inscripcionRequest)
        {
            using var context = new AcademiaContext();

            Curso? curso = InscripcionValidation.findValidCurso(inscripcionRequest.id_materia, inscripcionRequest.id_comision, inscripcionRequest.id_usuario);

            if(curso != null)
            {
                // Crear la nueva inscripción
                var inscripcion = new Inscripcion
                {
                    id_usuario = inscripcionRequest.id_usuario,
                    id_curso = curso.id_curso,
                    condicion = "Cursando",
                    nota = null
                };

                if (InscripcionValidation.IsValid(inscripcion))
                {
                    context.Inscripciones.Add(inscripcion);
                    context.SaveChanges();
                }
            }
            
            
        }

        public void Delete(int id)
        {
            using var context = new AcademiaContext();
            Inscripcion? inscripcionToDelete = context.Inscripciones.Find(id);
            
            if (inscripcionToDelete != null)
            {
                if (inscripcionToDelete?.condicion != "Cursando")
                {
                    throw new Exception("No es posible eliminar la inscripcion.");
                }
                context.Inscripciones.Remove(inscripcionToDelete);
                context.SaveChanges();
            }
        }

        public Inscripcion? Get(int id)
        {
            using var context = new AcademiaContext();
            return context.Inscripciones.Find(id);
        }

        public List<InscripcionDto> GetAll()
        {
            using var context = new AcademiaContext();


            var inscripciones = context.Inscripciones
                .Include(i => i.Usuario)
                    .ThenInclude(u => u.Persona)                
                .Include(i => i.Curso)                    
                    .ThenInclude(c => c.Materia)          
                        .ThenInclude(m => m.Plan)         
                            .ThenInclude(p => p.Especialidad)
                .Include(i => i.Curso)
                    .ThenInclude(c => c.Comision)
                .ToList();

            // Convertir a InscripcionDto
            var inscripcionDtos = inscripciones.Select(i => ToDto(i)).ToList();

            return inscripcionDtos;
        }
        public List<InscripcionAlumnoDto> GetInscripcionesAlumno(int idUsuario)
        {
            using var context = new AcademiaContext();

            var inscripciones = context.Inscripciones
                .Where(i => i.id_usuario == idUsuario)
                .Include(i => i.Usuario).ThenInclude(u => u.Persona)
                .Include(i => i.Curso)
                    .ThenInclude(c => c.Materia)
                        .ThenInclude(m => m.Plan)
                            .ThenInclude(p => p.Especialidad)
                .Include(i => i.Curso)
                    .ThenInclude(c => c.Comision); 

            return inscripciones.Select(i => ToAlumnoDto(i)).ToList();
        }

        public List<InscripcionDto> GetInscripcionesDocente(int idUsuario)
        {
            using var context = new AcademiaContext();

            // 1. Obtener los id_curso de los dictados asociados al id_docente
            var cursosDictados = context.Dictados
                .Where(d => d.id_docente == idUsuario)
                .Select(d => d.id_curso)
                .Distinct()
                .ToList();

            // 2. Obtener las inscripciones de los cursos filtrados
            var inscripciones = context.Inscripciones
                .Where(i => cursosDictados.Contains(i.id_curso))
                .Include(i => i.Usuario)
                    .ThenInclude(u => u.Persona)
                .Include(i => i.Curso)
                    .ThenInclude(c => c.Materia)
                        .ThenInclude(m => m.Plan)
                            .ThenInclude(p => p.Especialidad)
                .Include(i => i.Curso)
                    .ThenInclude(c => c.Comision)
                .ToList();

            // 3. Convertir a DTO y devolver la lista
            return inscripciones.Select(i => ToDto(i)).ToList();
        }

        private static InscripcionDto ToDto(Inscripcion inscripcion)
        {
            return new InscripcionDto
            {
                id_inscripcion = inscripcion.id_inscripcion,
                nombre_apellido = inscripcion.Usuario?.Persona?.nombre + " " +
                inscripcion.Usuario?.Persona?.apellido,
                legajo = inscripcion.Usuario?.legajo,
                especialidad = inscripcion.Curso?.Materia?.Plan?.Especialidad?.desc_especialidad ?? string.Empty,
                plan = inscripcion.Curso?.Materia?.Plan?.desc_plan ?? string.Empty,
                materia = inscripcion.Curso?.Materia?.desc_materia ?? string.Empty,
                comision = inscripcion.Curso?.Comision?.desc_comision ?? string.Empty,
                condicion = inscripcion.condicion,
                nota = inscripcion.nota
            };
        }
        private static InscripcionAlumnoDto ToAlumnoDto(Inscripcion inscripcion)
        {
            return new InscripcionAlumnoDto
            {
                id_inscripcion = inscripcion.id_inscripcion,
                materia = inscripcion.Curso?.Materia?.desc_materia ?? string.Empty,
                comision = inscripcion.Curso?.Comision?.desc_comision ?? string.Empty,
                condicion = inscripcion.condicion,
                nota = inscripcion.nota
            };
        }

        public void Update(Inscripcion inscripcion)
        {
            using var context = new AcademiaContext();
            Inscripcion? inscripcionToUpdate = context.Inscripciones.Find(inscripcion.id_inscripcion);

            if (inscripcionToUpdate != null)
            {
                if(InscripcionValidation.isValidNota(inscripcion))
                inscripcionToUpdate.condicion = inscripcion.condicion;
                inscripcionToUpdate.nota = inscripcion.nota;
                context.SaveChanges();
            }
        }
    }
}
