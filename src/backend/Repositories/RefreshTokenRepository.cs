using backend.Data;
using backend.Interfaces.RefreshToken;
using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Repositories
{
    public class RefreshTokenRepository : IRefreshTokenRepository
    {
        private readonly KobaStoreContext _context;

        public RefreshTokenRepository(KobaStoreContext storeContext)
        {
            _context = storeContext;
        }

        public async Task AddAsync (RefreshToken refreshToken)
        {
            await _context.RefreshTokens.AddAsync(refreshToken);
            await _context.SaveChangesAsync();
        }

        public async Task<RefreshToken?> GetByTokenAsync(string token)
        {
            return await _context.RefreshTokens
                                 .FirstOrDefaultAsync(rt => rt.Token == token);
        }

        public async Task DeleteAsync(string token)
        {
            var tokenToDelete = await _context.RefreshTokens
       .FirstOrDefaultAsync(t => t.Token == token);

            if (tokenToDelete != null)
            {
                _context.RefreshTokens.Remove(tokenToDelete);
                await _context.SaveChangesAsync(); 
            }
        }
    }
}
