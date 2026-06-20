using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Domain.Services;
using Entities;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EspecialidadesController : ControllerBase
    {
        private readonly EspecialidadService _especialidadService;

        public EspecialidadesController(EspecialidadService especialidadService)
        {
            _especialidadService = especialidadService;
        }

        [HttpGet("{id}")]
        public ActionResult<Especialidad> Get(int id)
        {
            try
            {
                var especialidad = _especialidadService.Get(id);
                if (especialidad == null)
                {
                    return NotFound();
                }
                return Ok(especialidad);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public ActionResult<List<EspecialidadDto>> GetAll()
        {
            try
            {
                var especialidades = _especialidadService.GetAll();
                return Ok(especialidades);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Add([FromBody] Especialidad especialidad)
        {
            try
            {
                _especialidadService.Add(especialidad);
                return CreatedAtAction(nameof(Get), new { id = especialidad.id_especialidad }, especialidad);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public ActionResult Update([FromBody] Especialidad especialidad)
        {
            try
            {
                _especialidadService.Update(especialidad);
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
                _especialidadService.Delete(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
