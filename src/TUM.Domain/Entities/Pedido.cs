
namespace TUM.Domain.Entities
{
    public class Pedido
    {
        public int PedidoId { get; set; }

        public DateTime Fecha { get; set; }

        // cliente
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; } = null!;

        // usuario
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; } = null!;



        // Relacion uno a muchos
        public ICollection<Tarea> Tareas { get; set; } = new List<Tarea>();
        public ICollection<DetallePedido> DetallePedidos { get; set; } = new List<DetallePedido>();

    }
}
