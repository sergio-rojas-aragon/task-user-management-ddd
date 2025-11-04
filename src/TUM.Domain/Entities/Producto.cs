
namespace TUM.Domain.Entities
{
    public class Producto
    {

        public int ProductoId { get; set; }

        public string Nombre { get; set; }

        public string Categoria { get; set; }

        public decimal Precio { get; set; }

        public DateTime fechaCreacion { get; set; }

        public DateTime fechaActualizacion { get; set; } 

        public ICollection<DetallePedido> DetallePedidos { get; set; } = new List<DetallePedido>();

    }
}
