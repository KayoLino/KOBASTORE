﻿namespace backend.DTOs.Cliente
{
    public class EnderecoDTO
    {
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public string? Complemento { get; set; }
    }
}
