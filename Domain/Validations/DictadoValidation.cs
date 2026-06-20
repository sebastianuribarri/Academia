using Entities;

namespace Domain.Validations
{
    internal class DictadoValidation
    {
        public bool isValid(Dictado? dictado)
        {
            if (dictado == null) throw new Exception("Los datos del dictado son obligatorios.");
            if (dictado.cargo != "DOCENTE" && dictado.cargo != "JEFE DE CATEDRA" && dictado.cargo != "AYUDANTE") throw new Exception("El cargo no es valido");
            if (dictado.cargo.Length > 50) throw new Exception("El cargo debe ser menor a 50 caracteres.");

            using var context = new AcademiaContext();
            var curso = context.Cursos.Find(dictado.id_curso);
            if (curso == null)
            {
                throw new Exception("El curso seleccionado no existe.");
            }

            var usuario = context.Usuarios.Find(dictado.id_docente);
            if (usuario == null)
            {
                throw new Exception("El docente seleccionado no existe.");
            }
            var dictado_ = context.Dictados.FirstOrDefault(d => d.id_curso == dictado.id_curso && d.id_docente == dictado.id_docente && d.cargo == dictado.cargo);
            if(dictado_ != null)
            {
                throw new Exception("El docente ya esta cargado en este curso para este cargo");
            }

            return true;
        }
    }
}
