using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Domain.Services;
using Entities;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        private readonly PersonaService _personaService;

        public PersonasController(PersonaService personaService)
        {
            _personaService = personaService;
        }

        [HttpGet("{id}")]
        public ActionResult<Persona> Get(int id)
        {
            try
            {
                var persona = _personaService.Get(id);
                if (persona == null)
                {
                    return NotFound();
                }
                return Ok(persona);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public ActionResult<List<PersonaDto>> GetAll()
        {
            try
            {
                var personas = _personaService.GetAll();
                return Ok(personas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Add([FromBody] Persona persona)
        {
            try
            {
                Persona? createdPersona =  _personaService.Add(persona);
                if (createdPersona == null) throw new Exception("Se produjo un error al crear la persona");
                // Devuelve un 201 Created con la URL del recurso y el objeto creado
                return CreatedAtAction(
                    nameof(Get),
                    new { id = createdPersona.id_persona },
                    createdPersona
                );
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public ActionResult Update([FromBody] Persona persona)
        {
            try
            {
                _personaService.Update(persona);
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
                _personaService.Delete(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }



}
