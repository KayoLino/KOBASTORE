using backend.Models;

namespace backend.Interfaces
{
    public interface IClienteService
    {
        Task<IEnumerable<Cliente>> GetAllClienteAsync();
        Task<Cliente> GetClienteByIdAsync(int id);
        Task CreateClienteAsync(Cliente cliente);
        Task UpdateClienteAsync(Cliente cliente);
        Task DeleteClienteAsync(int id);
        Task AddEnderecoAsync(int clienteId, Endereco endereco);
    }
}
