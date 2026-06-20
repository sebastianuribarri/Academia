using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Entities;
using System.Runtime.CompilerServices;
using Domain.Validations;

namespace Domain.Services
{
    public class MateriaService
    {
        private readonly MateriaValidation materiaValidation;

        public MateriaService()
        {
            materiaValidation = new MateriaValidation();
        }

        public void Add(Materia materia)
        {
            try
            {
                using var context = new AcademiaContext();
                if (materiaValidation.isValid(materia))
                {
                    materia.activo = true;
                    context.Materias.Add(materia);

                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                Console.WriteLine($"Error al agregar la materia: {ex.Message}");
                throw;
            }
        }

        public void Delete(int? id)
        {
            try
            {
                using var context = new AcademiaContext();
                Materia? materiaToDelete = context.Materias.Find(id);

                if (materiaToDelete != null)
                {
                    materiaToDelete.activo = false;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                Console.WriteLine($"Error al eliminar la materia: {ex.Message}");
                throw;
            }
        }

        public Materia? Get(int? id)
        {

                if (id == null) return null;
                using var context = new AcademiaContext();
                return context.Materias.FirstOrDefault(m => m.id_materia == id && m.activo);


        }

        public List<MateriaDto> GetAll()
        {
                using var context = new AcademiaContext();
                var materias = context.Materias
                    .Include(m => m.Plan)
                    .ThenInclude(p => p.Especialidad)
                    .Where(m => m.activo)
                    .ToList();

                return materias.Select(m => ToDto(m)).ToList();

        }

        public List<MateriaDto> GetByPlan(int planId)
        {
            try
            {
                using var context = new AcademiaContext();
                var materias = context.Materias
                    .Include(m => m.Plan)
                    .ThenInclude(p => p.Especialidad)
                    .Where(m => m.id_plan == planId && m.activo)
                    .ToList();

                return materias.Select(m => ToDto(m)).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener materias por plan: {ex.Message}");
                throw;
            }
        }

        public void Update(Materia materia)
        {
            try
            {
                using var context = new AcademiaContext();
                Materia? materiaToUpdate = context.Materias.Find(materia.id_materia);

                if (materiaToUpdate != null && materiaValidation.isValid(materia))
                {
                    materiaToUpdate.id_plan = materia.id_plan;
                    materiaToUpdate.desc_materia = materia.desc_materia;
                    materiaToUpdate.hs_semanales = materia.hs_semanales;
                    materiaToUpdate.hs_totales = materia.hs_totales;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al actualizar la materia: {ex.Message}");
                throw;
            }
        }

        private static MateriaDto ToDto(Materia materia)
        {
            return new MateriaDto
            {
                Id = materia.id_materia,
                Descripcion = materia.desc_materia,
                hs_semanales = materia.hs_semanales,
                hs_totales = materia.hs_totales,
                Plan = materia.Plan?.desc_plan,
                Especialidad = materia.Plan?.Especialidad?.desc_especialidad
            };
        }
    }
}
