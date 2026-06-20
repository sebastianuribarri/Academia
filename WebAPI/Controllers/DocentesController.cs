using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Domain.Services;
using Entities;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocentesController : ControllerBase
    {
        private readonly DocenteService _docenteService;

        public DocentesController(DocenteService docenteService)
        {
            _docenteService = docenteService;
        }

        [HttpGet("{id}")]
        public ActionResult<Usuario> Get(int id)
        {
            try
            {
                var usuario = _docenteService.Get(id);
                if (usuario == null)
                {
                    return NotFound();
                }
                return Ok(usuario);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public ActionResult<List<DocenteDto>> GetAll()
        {
            try
            {
                var usuarios = _docenteService.GetAll();
                return Ok(usuarios);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Add([FromBody] Usuario usuario)
        {
            try
            {
                _docenteService.Add(usuario);
                return CreatedAtAction(nameof(Get), new { id = usuario.id_usuario }, usuario);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public ActionResult Update([FromBody] Usuario usuario)
        {
            try
            {
                _docenteService.Update(usuario);
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
                _docenteService.Delete(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
