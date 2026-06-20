using Domain.Services;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Domain
{
    internal class AcademiaContext : DbContext
    {
        internal DbSet<Usuario> Usuarios { get; set; }
        internal DbSet<Persona> Personas { get; set; }
        internal DbSet<Especialidad> Especialidades { get; set; }
        internal DbSet<Plan> Planes { get; set; }
        internal DbSet<Comision> Comisiones { get; set; }
        internal DbSet<Curso> Cursos { get; set; }
        internal DbSet<Materia> Materias { get; set; }
        internal DbSet<Inscripcion> Inscripciones { get; set; }
        internal DbSet<Dictado> Dictados { get; set; }
        internal AcademiaContext()
        {
            this.Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer("Server=localhost;Database=Academia ;Trusted_Connection=SSPI;MultipleActiveResultSets=true;Trust Server Certificate=true");
        
        //@"server=localhost; database=Academia; Integrated Security=true"
    }
}
