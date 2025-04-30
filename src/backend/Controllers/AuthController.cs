using backend.DTOs.Auth;
using backend.DTOs.Cliente;
using backend.Exceptions;
using backend.Interfaces.Auth;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        public async Task<IActionResult> Register([FromBody] RegisterDTO dto)
        {
            try
            {
                    await _authService.RegisterAsync(dto);
                    return Ok("Cliente registrado com sucesso");
            }
            catch (BadRequestException ex)
            {
                return BadRequest(new { erro = ex.Message });
            }
            catch (ConflictException ex)
            {
                return Conflict(new { erro = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { erro = "Erro interno do servidor." });
            }
        }
    }
}
