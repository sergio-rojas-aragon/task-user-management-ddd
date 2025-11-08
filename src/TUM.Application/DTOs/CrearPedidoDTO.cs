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
        public int UsuarioId { get; set; }
        public List<CrearDetallePedidoDTO> DetallePedido { get; set; } = new List<CrearDetallePedidoDTO>();
    }
}
