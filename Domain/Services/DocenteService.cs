using Entities;
using Microsoft.EntityFrameworkCore;

namespace Domain.Services
{
    public class DocenteService: UsuarioService
    {

        public List<DocenteDto> GetAll()
        {
            using var context = new AcademiaContext();
            var usuarios = context.Usuarios.Where(u => u.tipo_usuario == 2 && u.activo).Include(u => u.Persona)
                                           .Include(u => u.Plan)
                                           .ThenInclude(p => p.Especialidad)
                                           .ToList();

            List<DocenteDto> usuarioDtos = new List<DocenteDto>();
            foreach (var usuario in usuarios)
            {
                usuarioDtos.Add(ToDto(usuario));
            }
            return usuarioDtos;
        }

        private DocenteDto ToDto(Usuario usuario)
        {
            return new DocenteDto
            {
                Id = usuario.id_usuario,
                nombre_usuario = usuario.nombre_usuario,
                Persona = usuario.Persona != null ? $"{usuario.Persona.nombre} {usuario.Persona.apellido}" : null,
                legajo = usuario.legajo,
            };
        }
    }
}
