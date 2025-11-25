

namespace TUM.Domain.Entities
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }

        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public string? LastModified { get; set; }
        public DateTime? LastModifiedAt { get; set; }

        public ICollection<Tarea> Tareas { get; set; } = new List<Tarea>();
        public ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
    }
}
