
namespace TUM.Domain.Entities
{
    public class Tarea
    {

        public int TareaId { get; set; }

        public string Titulo { get; set; }
        public string Descripcion { get; set; }

        public string Estado { get; set; }

        // claves foraneas

        // usuario
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; } = null!;

        //estado
        public int EstadoId { get; set; }
        public EstadoTarea estadoTarea { get; set; } = null!;

        //cliente
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; } = null!;

        // pedido
        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; } = null!;

    }
}
