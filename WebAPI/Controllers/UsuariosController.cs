using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Domain.Services;
using Entities;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly UsuarioService _usuarioService;

        public UsuariosController(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet("{id}")]
        public ActionResult<Usuario> Get(int id)
        {
            try
            {
                var usuario = _usuarioService.Get(id);
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
        public ActionResult<Usuario> GetAll()
        {
            try
            {
                var admins = _usuarioService.GetAllAdmins();
                return Ok(admins);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("legajo/{legajo}")]
        public ActionResult<Usuario> GetByLegajo(int legajo)
        {
            try
            {
                var usuario = _usuarioService.GetByLegajo(legajo) ;
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

        [HttpPost]
        public ActionResult Add([FromBody] Usuario usuario)
        {
            try
            {
                _usuarioService.Add(usuario);
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
                _usuarioService.Update(usuario);
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
                _usuarioService.Delete(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest loginRequest)
        {
            Usuario? usuario = _usuarioService.Login(loginRequest.nombreUsuario, loginRequest.clave);

            if (usuario != null)
            {
                return Ok(usuario);
            }
            return Unauthorized("Usuario o contraseña incorrectos.");
        }
    }

    public class LoginRequest
    {
        public string nombreUsuario { get; set; }
        public string clave { get; set; }
    }

}
