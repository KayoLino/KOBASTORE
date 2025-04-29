using backend.DTOs.Auth;

namespace backend.Interfaces.Auth
{
    public interface IAuthService
    {
        Task<string> LoginAsync(LoginDTO dto);
        Task RegistrarAsync(RegisterDTO dto);
    }
}
