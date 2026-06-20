
using ApiClient;
using Domain;
using Entities;
using Microsoft.EntityFrameworkCore;

public class InscripcionValidation
{

    public static Curso? findValidCurso(int id_materia, int id_comision, int id_usuario)
    {
        using var context = new AcademiaContext();

        var incripcionAnteriorAlumno = context.Inscripciones.Where(i => i.id_usuario == id_usuario && i.condicion != "Recursa")
                                                        .Include(i => i.Curso)
                                                        .FirstOrDefault(i => i.Curso.id_materia == id_materia);

        if (incripcionAnteriorAlumno != null) throw new Exception("No se puede inscribir a esta materia");

        var currentYear = DateTime.Now.Year;

   
        var curso = context.Cursos
            .FirstOrDefault(c => c.id_materia == id_materia
                                 && c.id_comision == id_comision
                                 && c.anio_calendario == currentYear);

        if (curso == null)
        {
            throw new Exception("No se encontró el curso para los parámetros proporcionados.");
        }
        return curso;
    }

    public static bool IsValid(Inscripcion inscripcion)
    {
        
        if (!TieneCupo(inscripcion.id_curso))
        {
            throw new InvalidOperationException("No hay cupo disponible para este curso.");
        }
        return true;
    }

    private static bool TieneCupo(int idCurso)
    {
        using var context = new AcademiaContext();
        int inscripcionesActuales = context.Inscripciones.Count(i => i.id_curso == idCurso);
        Curso? curso = context.Cursos.Find(idCurso);

        return inscripcionesActuales < (curso?.cupo ?? 0);
    }

    public static bool isValidNota(Inscripcion inscripcion)
    {
        if(inscripcion.condicion == "Aprobado")
        {
            if(inscripcion.nota < 6)
            {
                throw new Exception("La nota para estar aprobado debe ser mayor a 6");
            }
        }
        else
        {
            inscripcion.nota = null;
        }
        return true;
    }
}
