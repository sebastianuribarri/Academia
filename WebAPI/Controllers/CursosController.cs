using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Domain.Services;
using Entities;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursosController : ControllerBase
    {
        private readonly CursoService _cursoService;

        public CursosController(CursoService cursoService)
        {
            _cursoService = cursoService;
        }

        [HttpGet("{id}")]
        public ActionResult<Curso> Get(int id)
        {
            try
            {
                var curso = _cursoService.Get(id);
                if (curso == null)
                {
                    return NotFound();
                }
                return Ok(curso);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public ActionResult<List<CursoDto>> GetAll()
        {
            try
            {
                var cursos = _cursoService.GetAll();
                return Ok(cursos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("usuario/{usuarioId}")]
        public  ActionResult<List<Curso>> GetByUsuario(int usuarioId)
        {
            try
            {
                var cursos =  _cursoService.GetByUsuario(usuarioId);
                return Ok(cursos);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPost]
        public ActionResult Add([FromBody] Curso curso)
        {
            try
            {
                _cursoService.Add(curso);
                return CreatedAtAction(nameof(Get), new { id = curso.id_curso }, curso);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public ActionResult Update([FromBody] Curso curso)
        {
            try
            {
                _cursoService.Update(curso);
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
                _cursoService.Delete(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
