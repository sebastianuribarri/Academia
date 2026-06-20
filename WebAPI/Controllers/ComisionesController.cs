using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Domain.Services;
using Entities;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComisionesController : ControllerBase
    {
        private readonly ComisionService _comisionService;

        public ComisionesController(ComisionService comisionService)
        {
            _comisionService = comisionService;
        }

        [HttpGet("{id}")]
        public ActionResult<Comision> Get(int id)
        {
            try
            {
                var comision = _comisionService.Get(id);
                if (comision == null)
                {
                    return NotFound();
                }
                return Ok(comision);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public ActionResult<List<ComisionDto>> GetAll()
        {
            try
            {
                var comisiones = _comisionService.GetAll();
                return Ok(comisiones);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Add([FromBody] Comision comision)
        {
            try
            {
                _comisionService.Add(comision);
                return CreatedAtAction(nameof(Get), new { id = comision.id_comision }, comision);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public ActionResult Update([FromBody] Comision comision)
        {
            try
            {
                _comisionService.Update(comision);
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
                _comisionService.Delete(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
