using backend.DTOs.Auth;

namespace backend.Interfaces.Auth
{
    public interface IAuthService
    {
        Task RegisterAsync(RegisterDTO dto);
        Task<string> LoginAsync(LoginDTO dto);
    }
}
