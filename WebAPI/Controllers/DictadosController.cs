using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Domain.Services;
using Entities;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DictadosController : ControllerBase
    {
        private readonly DictadoService _dictadoService;

        public DictadosController(DictadoService dictadoService)
        {
            _dictadoService = dictadoService;
        }

        [HttpGet("{id}")]
        public ActionResult<Dictado> Get(int id)
        {
            try
            {
                var dictado = _dictadoService.Get(id);
                if (dictado == null)
                {
                    return NotFound();
                }
                return Ok(dictado);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public ActionResult<List<DictadoDto>> GetAll()
        {
            try
            {
                var dictadoes = _dictadoService.GetAll();
                return Ok(dictadoes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Add([FromBody] Dictado dictado)
        {
            try
            {
                _dictadoService.Add(dictado);
                return CreatedAtAction(nameof(Get), new { id = dictado.id_dictado }, dictado);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public ActionResult Update([FromBody] Dictado dictado)
        {
            try
            {
                _dictadoService.Update(dictado);
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
                _dictadoService.Delete(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
