using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApiClient;
using Entities;

public class InscripcionesDocenteModel : PageModel
{
    private readonly IInscripcionApiClient _inscripcionApiClient;

    public InscripcionesDocenteModel(IInscripcionApiClient inscripcionApiClient)
    {
        _inscripcionApiClient = inscripcionApiClient;
    }

    public List<InscripcionDto> Inscripciones { get; set; } = new();

    public async Task<IActionResult> OnGetAsync()
    {
        int? userId = HttpContext.Session.GetInt32("UserId");
        if (userId == null)
        {
            return Redirect("/"); // Redirigir si no hay usuario en sesión
        }

        
        Inscripciones = await _inscripcionApiClient.GetInscripcionesDocenteAsync(userId.Value);

        return Page();
    }
}
