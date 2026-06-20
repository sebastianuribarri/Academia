using Domain.Validations;
using Entities;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

namespace Domain.Services
{
    public class UsuarioService
    {
        public void Add(Usuario usuario)
        {
            using var context = new AcademiaContext();
            if(UsuarioValidation.isValid(usuario))
            {
                context.Usuarios.Add(usuario);
                context.SaveChanges();
            }
            
        }

        public void Delete(int id)
        {
            using var context = new AcademiaContext();

            Usuario? usuarioToDelete = context.Usuarios.Find(id);

            if (usuarioToDelete != null)
            {
                usuarioToDelete.activo = false;
                context.SaveChanges();
            }
        }

        public Usuario? Get(int id)
        {
            using var context = new AcademiaContext();
            var usuario = context.Usuarios.Find(id);
            if (usuario == null || !usuario.activo) return null;
            return usuario;
        }

        public Usuario? GetByLegajo(int legajo)
        {
            using var context = new AcademiaContext();
            return context.Usuarios
                          .FirstOrDefault(u => u.legajo == legajo && u.activo); 

        }

        public void Update(Usuario usuario)
        {
            using var context = new AcademiaContext();

            Usuario? usuarioToUpdate = context.Usuarios.Find(usuario.id_usuario);

            if (usuarioToUpdate != null)
            {
                usuarioToUpdate.nombre_usuario = usuario.nombre_usuario;
                usuarioToUpdate.clave = usuario.clave;
                usuarioToUpdate.legajo = usuario.legajo;
                usuarioToUpdate.id_plan = usuario.id_plan;
                context.SaveChanges();
            }
        }

        // Método Login
        public Usuario? Login(string nombreUsuario, string clave)
        {
            using var context = new AcademiaContext();

            return context.Usuarios
                .FirstOrDefault(u => u.nombre_usuario == nombreUsuario && u.clave == clave && u.activo);
        }

        public List<UsuarioDto> GetAllAdmins()
        {
            using var context = new AcademiaContext();
            var usuarios = context.Usuarios.Where(u => u.tipo_usuario == 1 && u.activo).Include(u => u.Persona)
                                           .ToList();

            List<UsuarioDto> usuarioDtos = new List<UsuarioDto>();
            foreach (var usuario in usuarios)
            {
                usuarioDtos.Add(ToDto(usuario));
            }
            return usuarioDtos;
        }

        private UsuarioDto ToDto(Usuario usuario)
        {
            return new UsuarioDto
            {
                id_usuario = usuario.id_usuario,
                nombre_usuario = usuario.nombre_usuario,
                Persona = usuario.Persona != null ? $"{usuario.Persona.nombre} {usuario.Persona.apellido}" : null,
            };
        }
    }
}
