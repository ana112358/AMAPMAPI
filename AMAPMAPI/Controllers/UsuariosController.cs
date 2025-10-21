using AMAPMAPI.Dto;
using AMAPMAPI.Service;
using Microsoft.AspNetCore.Mvc;

namespace AMAPMAPI.Controllers;

[ApiController]
[Route("api/[controller]")]

public class UsuariosController : ControllerBase
{
    private readonly UsuarioService _usuarioService;

    public UsuariosController(UsuarioService usuarioService)
    {
        _usuarioService = usuarioService;
    }

    [HttpPost("cadastrar")]
    public IActionResult Cadastrar([FromBody] UsuarioCreateDto dto)
    {

        if (!ModelState.IsValid)
            return BadRequest(ModelState);


        try
        {
            var usuario = _usuarioService.CriarUsuario(dto.Email, dto.Senha);
            return Ok(new { mensagem = "Usuário criado com sucesso!", usuario.Email });
          
        }
        catch (Exception ex)
        {
            return BadRequest(new { erro = ex.Message });
        }
    }
}
