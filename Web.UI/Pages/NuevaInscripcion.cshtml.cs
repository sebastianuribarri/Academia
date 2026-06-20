using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiClient;
using Entities;
public class NuevaInscripcionModel : PageModel
{
    private readonly IInscripcionApiClient _inscripcionApiClient;
    private readonly ICursoApiClient _cursosApiClient;
    private readonly IUsuarioApiClient _usuarioApiClient;

    public NuevaInscripcionModel(IInscripcionApiClient inscripcionApiClient,
        ICursoApiClient cursosApiClient,
        IUsuarioApiClient usuarioApiClient)
    {
        _inscripcionApiClient = inscripcionApiClient;
        _cursosApiClient = cursosApiClient;
        _usuarioApiClient = usuarioApiClient;
    }

    [BindProperty]
    public InscripcionRequest InscripcionRequest { get; set; } = new InscripcionRequest();  // Cambiado a InscripcionRequest

    public List<SelectListItem> MateriasSelectList { get; set; } = new();
    public List<SelectListItem> ComisionesSelectList { get; set; } = new();
    public string? ErrorMessage { get; set; }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        int? userId = HttpContext.Session.GetInt32("UserId");
        if (userId == null)
        {
            return RedirectToPage("/");
        }

        InscripcionRequest.id_usuario = userId.Value;  // Asignar el ID del usuario actual

        if (InscripcionRequest.id_materia == 32)  
        {
            ErrorMessage = "Debe seleccionar una materia.";
            return Page();
        }

        try
        {
            await _inscripcionApiClient.AddAsync(InscripcionRequest);  // Usar InscripcionRequest en lugar de Inscripcion
            return RedirectToPage("/Inscripciones");
        }
        catch (Exception ex)
        {
            ErrorMessage = $"Error al intentar inscribirse: {ex.Message}";
            return Page();
        }
    }

    public async Task OnGetAsync()
    {
        await CargarMateriasYComisionesAsync();
    }

    private async Task CargarMateriasYComisionesAsync()
    {
        int? userId = HttpContext.Session.GetInt32("UserId");
        if (userId == null)
        {
            Redirect("/");  // Si no hay usuario, redirigir
            return;
        }

        var cursos = await _cursosApiClient.GetByUsuarioAsync(userId.Value);
        if (cursos == null || !cursos.Any())
        {
            ErrorMessage = "No se encontraron cursos para el plan de este usuario.";
            return;
        }

        // Generar lista de materias sin duplicados
        MateriasSelectList = cursos
            .Select(c => c.Materia)
            .Distinct()
            .Select(m => new SelectListItem
            {
                Text = m?.desc_materia,
                Value = m?.id_materia.ToString() ?? "32"
            })
            .ToList();

        // Generar lista de comisiones sin duplicados
        ComisionesSelectList = cursos
            .Select(c => c.Comision)
            .Distinct()
            .Select(com => new SelectListItem
            {
                Text = com?.desc_comision ?? "No disponible",
                Value = com?.id_comision.ToString() ?? "0"
            })
            .ToList();
    }
}
