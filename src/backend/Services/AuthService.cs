using backend.DTOs.Auth;
using backend.Exceptions;
using backend.Interfaces.Auth;
using backend.Interfaces.Cliente;
using backend.Models;
using backend.Utils;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;

namespace backend.Services
{
    public class AuthService : IAuthService
    {
        private readonly IClienteRepository _clienteRepository;

        public AuthService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task RegisterAsync(RegisterDTO registerDTO)
        {
            if (registerDTO == null) throw new ArgumentNullException(nameof(registerDTO));

            if (!CpfValidator.IsValid(registerDTO.CPF)) throw new BadRequestException("CPF inválido.");

            var clienteEmailExists = await _clienteRepository.ClienteExistsByEmailAsync(registerDTO.Email);

            if (clienteEmailExists) throw new ConflictException("E-mail já cadastrado.");

            var clienteCpfExists = await _clienteRepository.ClienteExistsByCpfAsync(registerDTO.CPF);

            if (clienteCpfExists) throw new ConflictException("CPF já cadastrado.");

            var cliente = new Cliente
            {
                Nome = registerDTO.Nome,
                Email = registerDTO.Email,
                CPF = registerDTO.CPF,
                Telefone = registerDTO.Telefone,
                SenhaHash = ""
            };

            var hasher = new PasswordHasher<Cliente>();
            cliente.SenhaHash = hasher.HashPassword(cliente, registerDTO.Senha);

            await _clienteRepository.AddAsync(cliente);
        }

        public async Task<string> LoginAsync(LoginDTO loginDTO)
        {
            return "Login";
        }


    }
}
