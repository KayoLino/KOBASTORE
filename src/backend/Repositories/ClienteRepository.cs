using backend.Data;
using backend.Models;
using backend.Interfaces.Cliente;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly KobaStoreContext _context;

        public ClienteRepository(KobaStoreContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Cliente>> GetAllAsync()
        {
            return await _context.Clientes.ToListAsync(); 
        }

        public async Task<Cliente> GetByIdAsync(int id)
        {
            return await _context.Clientes
                .Include(c => c.Endereco) 
                .FirstOrDefaultAsync(c => c.Id == id); 
        }

        public async Task AddAsync(Cliente cliente)
        {
            await _context.Clientes.AddAsync(cliente); 
            await _context.SaveChangesAsync(); 
        }

        public async Task UpdateAsync(Cliente cliente)
        {
            _context.Clientes.Update(cliente); 
            await _context.SaveChangesAsync(); 
        }

        public async Task DeleteAsync(int id)
        {
            var cliente = await GetByIdAsync(id);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente); 
                await _context.SaveChangesAsync(); 
            }
        }

        public async Task<bool> ClienteExistsByEmailAsync(string email)
        {
            return await _context.Clientes
                .AnyAsync(c => c.Email == email); 
        }

        public async Task<Cliente> GetByEmailAsync(string email)
        {
            return await _context.Clientes
                .FirstOrDefaultAsync(c => c.Email == email); 
        }
    }
}
