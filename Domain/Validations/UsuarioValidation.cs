using Entities;

namespace Domain.Validations
{
    internal class UsuarioValidation
    {
        public static bool isValid(Usuario usuario)
        {
            using var context = new AcademiaContext();
            var usuario_ = context.Usuarios.FirstOrDefault(u => u.nombre_usuario == usuario.nombre_usuario);
            if(usuario_ != null)
            {
                throw new Exception("Este nombre de usuario ya existe.");
            }
            if (usuario.tipo_usuario > 3 || usuario.tipo_usuario < 1) {
                throw new Exception("Este tipo de usuario no es valido");
            }
            else if(usuario.tipo_usuario == 2 || usuario.tipo_usuario == 3)
            {
                if (usuario.legajo <= 0)
                {
                    throw new Exception("El numero de legajo debe ser mayor a 0");
                }
                var usuarioLegajo = context.Usuarios.FirstOrDefault(u => u.legajo == usuario.legajo);
                if(usuarioLegajo != null)
                {
                    throw new Exception("Este legajo ya existe");
                }
            }
            if(usuario.tipo_usuario == 3)
            {
                var plan = context.Planes.FirstOrDefault(p => p.id_plan == usuario.id_plan && p.activo);
                if(plan == null)
                {
                    throw new Exception("El plan seleccionado no existe.");
                }
            }

            return true;
        }
    }
}
