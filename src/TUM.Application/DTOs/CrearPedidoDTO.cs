using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUM.Application.DTOs
{
    internal class CrearPedidoDTO
    {
        public int ClienteId { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public List<CrearDetallePedidoDTO> DetallePedido { get; set; } = new List<CrearDetallePedidoDTO>();
    }
}
