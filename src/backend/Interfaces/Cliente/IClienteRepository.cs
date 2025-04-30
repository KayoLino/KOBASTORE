namespace backend.Interfaces.Cliente
{
    public interface IClienteRepository
    {
        Task<IEnumerable<Models.Cliente>> GetAllAsync();
        Task<Models.Cliente> GetByIdAsync(int id);
        Task AddAsync(Models.Cliente cliente);
        Task UpdateAsync(Models.Cliente cliente);
        Task DeleteAsync(int id);
        Task<bool> ClienteExistsByEmailAsync(string email);
        Task<bool> ClienteExistsByCpfAsync(string cpf);
        Task<Models.Cliente> GetByEmailAsync(string email);
    }
}
