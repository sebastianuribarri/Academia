using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using ApiClient;
using Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

public class EditarCondicionModel : PageModel
{
    private readonly IInscripcionApiClient _inscripcionApiClient;

    public EditarCondicionModel(IInscripcionApiClient inscripcionApiClient)
    {
        _inscripcionApiClient = inscripcionApiClient;
    }

    [BindProperty]
    public Inscripcion? Inscripcion { get; set; } = new Inscripcion();

    public string? ErrorMessage { get; set; }

    public List<SelectListItem> CondicionesSelectList { get; set; } = new();

    public async Task<IActionResult> OnGetAsync(int id)
    {
        try
        {
            Inscripcion = await _inscripcionApiClient.GetAsync(id);
            if (Inscripcion == null)
            {
                ErrorMessage = "La inscripción no existe.";
                return RedirectToPage("/Docente");
            }

            // Rellena la lista de condiciones
            CondicionesSelectList = new List<SelectListItem>
        {
            new SelectListItem { Text = "Cursando", Value = "Cursando" },
            new SelectListItem { Text = "Regular", Value = "Regular" },
            new SelectListItem { Text = "Aprobado", Value = "Aprobado" },
            new SelectListItem { Text = "Recursa", Value = "Recursa" }
        };

            return Page();
        }
        catch (Exception ex)
        {
            ErrorMessage = $"Error al cargar la inscripción: {ex.Message}";
            return RedirectToPage("/Docente");
        }
    }

    public async Task<IActionResult> OnPostAsync(int id)
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        if (string.IsNullOrEmpty(Inscripcion.condicion))
        {
            ErrorMessage = "Debe seleccionar una condición.";
            return Page();
        }

        if (Inscripcion.nota < 0 || Inscripcion.nota > 10)
        {
            ErrorMessage = "La nota debe estar entre 0 y 10.";
            return Page();
        }

        try
        {
            Inscripcion.id_inscripcion = id; // Asegurarse de incluir el ID de la inscripción
            await _inscripcionApiClient.UpdateAsync(Inscripcion);
            return RedirectToPage("/Docente");
        }
        catch (Exception ex)
        {
            ErrorMessage = $"Error al actualizar la inscripción: {ex.Message}";
            return Page();
        }
    }
}
