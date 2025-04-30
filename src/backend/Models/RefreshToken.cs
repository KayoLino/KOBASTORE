using backend.Models;

namespace backend.Models
{
        public class RefreshToken
        {
          public int Id { get; set; }
          public string Token { get; set; }
          public DateTime ExpiraEm { get; set; }
          public bool Usado { get; set; } = false;
          public bool Revogado { get; set; } = false;

          // FK com Cliente
          public int ClienteId { get; set; }
          public Cliente Cliente { get; set; }
        }
}

