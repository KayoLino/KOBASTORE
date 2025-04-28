using System.Collections.Generic;
using backend.Interfaces;
using backend.Models;

namespace backend.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<IEnumerable<Cliente>> GetAllClienteAsync()
        {
            return await _clienteRepository.GetAllAsync();
        }

        public async Task<Cliente> GetClienteByIdAsync (int id)
        {
            return await _clienteRepository.GetByIdAsync(id);
        }

        public async Task CreateClienteAsync (Cliente cliente)
        {
            await _clienteRepository.AddAsync(cliente);
        }

        public async Task UpdateClienteAsync (Cliente cliente)
        {
            await _clienteRepository.UpdateAsync(cliente);
        }

        public async Task DeleteClienteAsync (int id)
        {
            var cliente = await _clienteRepository.GetByIdAsync(id);
            if(cliente != null)
            {
                await _clienteRepository.DeleteAsync(cliente);
            }
        }
    }
}
