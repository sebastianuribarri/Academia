using Entities;
using Microsoft.EntityFrameworkCore;

namespace Domain.Services
{
    public class AlumnoService: UsuarioService
    {

        public List<AlumnoDto> GetAll()
        {
            using var context = new AcademiaContext();
            var usuarios = context.Usuarios.Where(u => u.tipo_usuario == 3 && u.activo)
                                            .Include(u => u.Persona)
                                           .Include(u => u.Plan)
                                           .ThenInclude(p => p.Especialidad)
                                           .ToList();

            List<AlumnoDto> usuarioDtos = new List<AlumnoDto>();
            foreach (var usuario in usuarios)
            {
                usuarioDtos.Add(ToDto(usuario));
            }
            return usuarioDtos;
        }

        private AlumnoDto ToDto(Usuario usuario)
        {
            return new AlumnoDto
            {
                Id = usuario.id_usuario,
                nombre_usuario = usuario.nombre_usuario,
                Persona = usuario.Persona != null ? $"{usuario.Persona.nombre} {usuario.Persona.apellido}" : null,
                legajo = usuario.legajo,
                Plan = usuario.Plan?.desc_plan,
                Especialidad = usuario.Plan?.Especialidad.desc_especialidad  
            };
        }
    }
}
