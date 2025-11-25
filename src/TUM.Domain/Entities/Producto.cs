
namespace TUM.Domain.Entities
{
    public class Producto
    {

        public int ProductoId { get; set; }

        public string Nombre { get; set; }

        public string Categoria { get; set; }

        public decimal Precio { get; set; }

        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public string? LastModified { get; set; }
        public DateTime? LastModifiedAt { get; set; }

        public ICollection<DetallePedido> DetallePedidos { get; set; } = new List<DetallePedido>();

    }
}
