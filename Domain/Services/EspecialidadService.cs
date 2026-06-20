using Entities;

namespace Domain.Services
{
    public class EspecialidadService
    {
        public void Add(Especialidad especialidad)
        {

            using var context = new AcademiaContext();
            especialidad.activo = true;
            context.Especialidades.Add(especialidad);

            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new AcademiaContext();
            Especialidad? especialidadToDelete = context.Especialidades.Find(id);

            if (especialidadToDelete != null)
            {
                especialidadToDelete.activo = false;
                context.SaveChanges();
            }
        }

        public Especialidad? Get(int id)
        {
            using var context = new AcademiaContext();
            return context.Especialidades.FirstOrDefault(e => e.id_especialidad == id && e.activo);
        }

        public List<EspecialidadDto> GetAll()
        {
            using var context = new AcademiaContext();
            return context.Especialidades.Where(e => e.activo).Select(e => new EspecialidadDto
            {
                id_especialidad = e.id_especialidad,
                desc_especialidad = e.desc_especialidad
            }).ToList();
        }

        public void Update(Especialidad especialidad)
        {
            using var context = new AcademiaContext();
            Especialidad? especialidadToUpdate = context.Especialidades.Find(especialidad.id_especialidad);

            if (especialidadToUpdate != null)
            {
                especialidadToUpdate.desc_especialidad = especialidad.desc_especialidad;

                context.SaveChanges();
            }
        }
    }
}
