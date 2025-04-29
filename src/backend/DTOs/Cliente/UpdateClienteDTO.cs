
namespace backend.DTOs.Cliente
{
    public class UpdateClienteDTO
    {
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public int? Idade { get; set; }
        public string? Telefone { get; set; }
        public EnderecoDTO? Endereco { get; set; }
    }
}
