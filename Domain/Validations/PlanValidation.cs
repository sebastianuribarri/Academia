using Entities;

namespace Domain.Validations
{
    internal class PlanValidation
    {
        public bool isValid(Plan? plan)
        {
            if (plan == null) throw new Exception("Los datos del plan son obligatorios.");
            if (String.IsNullOrEmpty(plan.desc_plan)) throw new Exception("La descripcion es requerida.");
            if (plan.desc_plan.Length > 50) throw new Exception("La descripcion debe ser menor a 50 caracteres.");

            using var context = new AcademiaContext();
            bool? especialidad_activo = context.Especialidades.Find(plan.id_especialidad)?.activo;
            if (especialidad_activo != true) throw new Exception("La especialidad seleccionada no existe.");

            return true;
        }
    }
}
