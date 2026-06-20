using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using ApiClient;
using Entities;

public class IndexModel : PageModel
{
    private readonly IUsuarioApiClient _usuarioApiClient;

    public IndexModel(IUsuarioApiClient usuarioApiClient)
    {
        _usuarioApiClient = usuarioApiClient;
    }

    [BindProperty]
    public LoginRequest LoginRequest { get; set; } = new();

    public string? ErrorMessage { get; set; }

    public async Task<IActionResult> OnGetAsync()
    {
        // Verifica si hay un usuario logueado basado en la sesión
        int? userId = HttpContext.Session.GetInt32("UserId");

        if (userId.HasValue)
        {
            // Puedes usar un servicio para obtener los detalles del usuario si es necesario
            Usuario? usuario = await _usuarioApiClient.GetAsync(userId.Value);

            if (usuario != null)
            {
                // Redirige según el tipo de usuario
                if (usuario.tipo_usuario == 3)
                {
                    return RedirectToPage("/Inscripciones");
                }
                else if (usuario.tipo_usuario == 2)
                {
                    return RedirectToPage("/Docente");
                }
            }
        }

        // Si no hay sesión o no se cumple ninguna condición, permanece en la página de login
        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        try
        {
            Usuario? usuario = await _usuarioApiClient.LoginAsync(LoginRequest.NombreUsuario, LoginRequest.Clave);

            if (usuario != null)
            {
                
                if (usuario.tipo_usuario == 3)
                {
                    HttpContext.Session.SetInt32("UserId", usuario.id_usuario);
                    return RedirectToPage("/Inscripciones");  // Redirige después de un login exitoso
                }
                else if(usuario.tipo_usuario == 2){
                    HttpContext.Session.SetInt32("UserId", usuario.id_usuario);
                    return RedirectToPage("/Docente");
                }
                else
                {
                    ErrorMessage = "Usuario no tiene permisos para inscribirse o otra condición";
                    return Page(); // Retorna la misma página si no pasa la condición
                }
            }
            else
            {
                ErrorMessage = "Usuario o contraseña incorrectos.";
                return Page();  // Si no se encontró el usuario
            }
        }
        catch (Exception ex)
        {
            ErrorMessage = ex.Message;
            return Page();  // Si ocurre una excepción, retorna la misma página
        }
    }

}

public class LoginRequest
{
    public string NombreUsuario { get; set; } = string.Empty;
    public string Clave { get; set; } = string.Empty;
}
