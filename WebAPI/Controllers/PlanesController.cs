using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Domain.Services;
using Entities;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanesController : ControllerBase
    {
        private readonly PlanService _planService;

        public PlanesController(PlanService planService)
        {
            _planService = planService;
        }

        [HttpGet("{id}")]
        public ActionResult<Plan> Get(int id)
        {
            try
            {
                var plan = _planService.Get(id);
                if (plan == null)
                {
                    return NotFound();
                }
                return Ok(plan);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public ActionResult<List<PlanDto>> GetAll()
        {
            try
            {
                var planes = _planService.GetAll();
                return Ok(planes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Add([FromBody] Plan plan)
        {
            try
            {
                _planService.Add(plan);
                return CreatedAtAction(nameof(Get), new { id = plan.id_plan }, plan);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public ActionResult Update([FromBody] Plan plan)
        {
            try
            {
                _planService.Update(plan);
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
                _planService.Delete(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
