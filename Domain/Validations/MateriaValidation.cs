using Entities;

namespace Domain.Validations
{
    internal class MateriaValidation
    {
        public bool isValid(Materia? materia)
        {
            if (materia == null) throw new Exception("Los datos de la materia son obligatorios.");
            if (materia.hs_totales <= 0) throw new Exception("Las horas totales deben ser mayor a 0.");
            if (materia.hs_semanales <= 0) throw new Exception("Las horas semanales deben ser mayor a 0.");
            if (String.IsNullOrEmpty(materia.desc_materia)) throw new Exception("La descripcion es requerida.");
            if (materia.desc_materia.Length > 50) throw new Exception("La descripcion debe ser menor a 50 caracteres.");

            using var context = new AcademiaContext();
            bool? plan_activo = context.Planes.Find(materia.id_plan)?.activo;
            if (plan_activo != true) throw new Exception("El plan seleccionado no existe.");

            return true;
        }
    }
}
