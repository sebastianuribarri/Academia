using Entities;

namespace Domain.Validations
{
    internal class CursoValidation
    {
        public static bool isValid(Curso curso)
        {
            if (curso.anio_calendario < DateTime.Now.Year) throw new Exception("El año no puede ser anterior al actual.");

            if (curso.cupo < 0) throw new Exception("El cupo debe ser mayor a 0");

            using var context = new AcademiaContext();
           
            Materia? materia = context.Materias.Find(curso.id_materia);

            Comision? comision = context.Comisiones.Find(curso.id_comision);

            if (materia?.id_plan != comision?.id_plan) throw new Exception("La comision y la materia deben ser del mismo plan");

            Curso? curso_ = context.Cursos.FirstOrDefault(c => c.id_materia == curso.id_materia && c.id_comision == curso.id_comision && c.anio_calendario == curso.anio_calendario);

            if (curso_ != null) throw new Exception("Este curso ya existe");
            return true;
        }
    }
}
