
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
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string? LastModified { get; set; }
        public DateTime? LastModifiedAt { get; set; }

        //estado
        public int EstadosTareaId { get; set; }
        public EstadosTarea estadosTarea { get; set; } = null!;

        //cliente
        public int ClienteId { get; set; }
        public Client Cliente { get; set; } = null!;

        // pedido
        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; } = null!;

    }
}
