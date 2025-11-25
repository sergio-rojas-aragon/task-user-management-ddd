

namespace TUM.Domain.Entities
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Rut { get; set; }
        public string LegalName { get; set; }
        public string? TradeName { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }

        public string? PhoneMobile { get; set; }
        public bool isActive { get; set; } = true;

        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public string? LastModified { get; set; }
        public DateTime? LastModifiedAt { get; set; }

        public ICollection<Tarea> Tareas { get; set; } = new List<Tarea>();
        public ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();

        public int ClientTypeId { get; set; }
        public ClientTypes ClientTypes { get; set; } = null;
    }
}
