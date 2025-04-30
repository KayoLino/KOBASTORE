namespace backend.Interfaces.RefreshToken
{
    public interface IRefreshTokenRepository
    {
        Task AddAsync(Models.RefreshToken token);
        Task<Models.RefreshToken> GetByTokenAsync(string token);
        Task DeleteAsync(string token);
    }
}
