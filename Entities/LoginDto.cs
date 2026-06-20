using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class LoginDto
    {
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }


    }
}