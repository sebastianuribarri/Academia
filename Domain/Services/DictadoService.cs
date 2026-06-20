using Domain.Validations;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Domain.Services
{
    public class DictadoService
    {
        private readonly DictadoValidation dictadoValidation;

        public DictadoService()
        {
            dictadoValidation = new DictadoValidation();
        }

        public void Add(Dictado dictado)
        {

            using var context = new AcademiaContext();
            if (dictadoValidation.isValid(dictado))
            {
                context.Dictados.Add(dictado);
                context.SaveChanges();
            }
        }

        public void Delete(int? id)
        {
            using var context = new AcademiaContext();
            Dictado? dictadoToDelete = context.Dictados.Find(id);

            if (dictadoToDelete != null)
            {
                context.Dictados.Remove(dictadoToDelete);
                context.SaveChanges();
            }
        }

        public Dictado? Get(int? id)
        {
            if (id == null) return null;
            using var context = new AcademiaContext();
            return context.Dictados.Include(d => d.Usuario).FirstOrDefault(d => d.id_dictado == id);
        }

        public List<DictadoDto> GetAll()
        {
            using var context = new AcademiaContext();

            var dictados = context.Dictados
                .Include(d => d.Curso)                      
                .ThenInclude(c => c.Materia)            
                .ThenInclude(m => m.Plan)           
                .ThenInclude(p => p.Especialidad) 
                .Include(d => d.Usuario).ThenInclude(u => u.Persona)
                .ToList();

            var dictadoDtos = dictados.Select(d => ToDto(d)).ToList();

            return dictadoDtos;
        }

        public DictadoDto ToDto(Dictado dictado)
        {
            return new DictadoDto
            {
                id_dictado = dictado.id_dictado,
                desc_especialidad = dictado.Curso?.Materia?.Plan?.Especialidad?.desc_especialidad ?? string.Empty,
                desc_plan = dictado.Curso?.Materia?.Plan?.desc_plan ?? string.Empty,
                desc_materia = dictado.Curso?.Materia?.desc_materia ?? string.Empty,
                legajo = dictado.Usuario?.legajo ?? 0,
                nombre_apellido = dictado.Usuario?.Persona?.nombre + " " +
                dictado.Usuario?.Persona?.apellido,
                cargo = dictado.cargo
            };
        }



        public void Update(Dictado dictado)
        {
            using var context = new AcademiaContext();
            Dictado? dictadoToUpdate = context.Dictados.Find(dictado.id_dictado);

            if (dictadoValidation.isValid(dictado))
            {
                dictadoToUpdate.id_curso = dictado.id_curso;
                dictadoToUpdate.id_docente = dictado.id_docente;
                dictadoToUpdate.cargo = dictado.cargo;
                context.SaveChanges();
            }
        }
    }
}