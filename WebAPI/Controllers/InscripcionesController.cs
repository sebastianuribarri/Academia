using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Domain.Services;
using Entities;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InscripcionesController : ControllerBase
    {
        private readonly InscripcionService _inscripcionService;

        public InscripcionesController(InscripcionService inscripcionService)
        {
            _inscripcionService = inscripcionService;
        }

        [HttpGet("{id}")]
        public ActionResult<Inscripcion> Get(int id)
        {
            try
            {
                var inscripcion = _inscripcionService.Get(id);
                if (inscripcion == null)
                {
                    return NotFound();
                }
                return Ok(inscripcion);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public ActionResult<IEnumerable<Inscripcion>> GetAll()
        {
            try
            {
                var inscripciones = _inscripcionService.GetAll();
                return Ok(inscripciones);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("alumno/{idUsuario}")]
        public ActionResult<List<InscripcionAlumnoDto>> GetInscripcionesAlumno(int idUsuario)
        {
            try
            {
                var inscripciones = _inscripcionService.GetInscripcionesAlumno(idUsuario);
                return Ok(inscripciones);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet("docente/{idUsuario}")]
        public ActionResult<List<InscripcionDto>> GetInscripcionesDocente(int idUsuario)
        {
            try
            {
                var inscripciones = _inscripcionService.GetInscripcionesDocente(idUsuario);
                return Ok(inscripciones);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public ActionResult Add([FromBody] InscripcionRequest inscripcionRequest)
        {
            try
            {
                _inscripcionService.Add(inscripcionRequest);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public ActionResult Update([FromBody] Inscripcion inscripcion)
        {
            try
            {
                _inscripcionService.Update(inscripcion);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                _inscripcionService.Delete(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
