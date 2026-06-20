using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApiClient;
using Entities;

public class InscripcionesModel : PageModel
{
    private readonly IInscripcionApiClient _inscripcionApiClient;

    public InscripcionesModel(IInscripcionApiClient inscripcionApiClient)
    {
        _inscripcionApiClient = inscripcionApiClient;
    }

    public List<InscripcionAlumnoDto> Inscripciones { get; set; } = new();

    // Propiedad para almacenar el mensaje de error
    public string? ErrorMessage { get; set; }

    public async Task<IActionResult> OnGetAsync()
    {
        int? userId = HttpContext.Session.GetInt32("UserId");
        if (userId == null)
        {
            return RedirectToPage("/");
        }

        try
        {
            Inscripciones = await _inscripcionApiClient.GetInscripcionesAlumnoAsync(userId.Value);
        }
        catch (Exception ex)
        {
            ErrorMessage = $"Error al cargar las inscripciones: {ex.Message}";
        }

        return Page();
    }

    public async Task<IActionResult> OnPostDeleteAsync(int id)
    {
        try
        {
            await _inscripcionApiClient.DeleteAsync(id);

            
        }
        catch (Exception ex)
        {
            ErrorMessage = $"Error al eliminar la inscripción: {ex.Message}";
        }

        try
        {
            int? userId = HttpContext.Session.GetInt32("UserId");
            if (userId == null)
            {
                return Redirect("/");
            }

            Inscripciones = await _inscripcionApiClient.GetInscripcionesAlumnoAsync(userId.Value);
        }
        catch (Exception ex)
        {
            ErrorMessage = $"Error al cargar las inscripciones: {ex.Message}";
        }

        return Page();
    }
}
