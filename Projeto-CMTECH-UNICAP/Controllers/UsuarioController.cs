using Projeto_CMTECH_UNICAP.Models;
using Projeto_CMTECH_UNICAP.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Xml.Linq;

namespace Projeto_CMTECH_UNICAP.Controllers
{
    [Route("api/usuarios")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }
        [HttpGet("GetAllUsuarios")]
        public async Task<ActionResult<IAsyncEnumerable<Usuario>>> GetUsuarios()
        {
            try
            {
                var usuarios = await _usuarioService.GetUsuarios();
                return Ok(usuarios);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao obter usuarios");
            }
        }
        [HttpGet("UsuarioPorNome")]
        public async Task<ActionResult<IAsyncEnumerable<Usuario>>> GetUsuariosByNome([FromQuery] string nome)
        {
            try
            {
                var usuarios = await _usuarioService.GetUsuariosByNome(nome);
                if (usuarios == null)
                {
                    return NotFound($"Não existem usuarios com o critério {nome}");
                }
                return Ok(usuarios);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao obter usuarios");
            }
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<IAsyncEnumerable<Usuario>>> GetUsuario(int id)
        {
            try
            {
                var usuario = await _usuarioService.GetUsuario(id);
                if (usuario == null)
                {
                    return NotFound($"Não existem usuarios com id={id}");
                }
                return Ok(usuario);
            }
            catch
            {
                return BadRequest("Request inválido");
            }
        }
        [HttpPost("CriarUsuario")]
        public async Task<ActionResult> Create(Usuario usuario)
        {
            try
            {
                await _usuarioService.CreateUsuario(usuario);
                return CreatedAtRoute(nameof(GetUsuario), new { id = usuario.id }, usuario);
            }
            catch
            {
                return BadRequest("Request inválido");
            }
        }
        [HttpPut("{id:int}")]
        public async Task<ActionResult> Edit(int id, [FromBody] Usuario usuario)
        {
            try
            {
                if (usuario.id == id)
                {
                    await _usuarioService.UpdateUsuario(usuario);
                    return Ok($"Usuario com id ={id} for atualizado com sucesso");
                }
                else
                {
                    return BadRequest("Dados inconsistentes");
                }
            }
            catch
            {
                return BadRequest("Request inválido");
            }
        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                var usuario = await _usuarioService.GetUsuario(id);
                if (usuario != null)
                {
                    await _usuarioService.DeleteUsuario(usuario);
                    return Ok($"Usuario com id ={id} foi excluído com sucesso");
                }
                else
                {
                    return NotFound($"Usuario com id ={id} não encontrado");
                }
            }
            catch
            {
                return BadRequest("Request inválido");
            }
        }
    }
}
