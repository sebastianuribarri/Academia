using Entities;
using Microsoft.EntityFrameworkCore;

namespace Domain.Services
{
    public class ComisionService
    {
        public void Add(Comision comision)
        {

            using var context = new AcademiaContext();


            context.Comisiones.Add(comision);

            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new AcademiaContext();
            Comision? comisionToDelete = context.Comisiones.Find(id);

            if (comisionToDelete != null)
            {
                comisionToDelete.activo = false;
                context.SaveChanges();
            }
        }

        public Comision? Get(int id)
        {
            using var context = new AcademiaContext();
            var comision = context.Comisiones.Find(id);
            if(comision == null ||  !comision.activo) return null;
            return comision;
        }

        public List<ComisionDto> GetAll()
        {
            using var context = new AcademiaContext();
            List<Comision> comisiones = context.Comisiones.Where(c => c.activo)
                                                         .Include(c => c.Plan)
                                                        .ThenInclude(p => p.Especialidad).ToList();

            List<ComisionDto> comisionDtos = new List<ComisionDto>();

            foreach (Comision comision in comisiones)
            {
                comisionDtos.Add(this.ToDto(comision));
            }

            return comisionDtos;
        }

        public ComisionDto ToDto(Comision comision)
        {
            return new ComisionDto
            {
                id_comision = comision.id_comision,
                desc_comision = comision.desc_comision,
                anio_especialidad = comision.anio_especialidad,
                Plan = comision.Plan?.desc_plan,
                Especialidad = comision.Plan?.Especialidad.desc_especialidad
        };
        }

        public void Update(Comision comision)
        {
            using var context = new AcademiaContext();
            Comision? comisionToUpdate = context.Comisiones.Find(comision.id_comision);

            if (comisionToUpdate != null)
            {
                comisionToUpdate.desc_comision = comision.desc_comision;

                context.SaveChanges();
            }
        }
    }
}