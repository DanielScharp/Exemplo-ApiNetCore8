using ExemploApiNetCore8.App;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExemploApiNetCore8.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioApplication _usuarioApplication;

        public UsuarioController(UsuarioApplication usuarioApplication)
        {
            _usuarioApplication = usuarioApplication;
        }

        [HttpGet]
        public async Task<IActionResult> Listar()
        {
            try
            {
                var listaUsuarios = await _usuarioApplication.ListarUsuarios();
                return Ok(listaUsuarios);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
