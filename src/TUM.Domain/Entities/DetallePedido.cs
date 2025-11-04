

namespace TUM.Domain.Entities
{
    public class DetallePedido
    {

        public int DetallePedidoId { get; set; }

        public int Cantidad { get; set; }

        public int idPedido { get; set; }
        public Pedido Pedido { get; set; } = null!;

        public int ProductoId { get; set; }
        public Producto Producto { get; set; } = null!;
    }
}
