using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Domain.Services;
using Entities;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MateriasController : ControllerBase
    {
        private readonly MateriaService _materiaService;

        public MateriasController(MateriaService materiaService)
        {
            _materiaService = materiaService;
        }

        [HttpGet("{id}")]
        public ActionResult<Materia> Get(int id)
        {
            try
            {
                var materia = _materiaService.Get(id);
                if (materia == null)
                {
                    return NotFound();
                }
                return Ok(materia);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public ActionResult<IEnumerable<Materia>> GetAll()
        {
            try
            {
                var materias = _materiaService.GetAll();
                return Ok(materias);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("plan/{planId}")]
        public ActionResult<List<MateriaDto>> GetByPlan(int planId)
        {
            try
            {
                var materias = _materiaService.GetByPlan(planId);
                return Ok(materias);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public ActionResult Add([FromBody] Materia materia)
        {
            try
            {
                _materiaService.Add(materia);
                return CreatedAtAction(nameof(Get), new { id = materia.id_materia }, materia);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public ActionResult Update([FromBody] Materia materia)
        {
            try
            {
                _materiaService.Update(materia);
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
                _materiaService.Delete(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
