using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUM.Application.DTOs
{
    internal class CrearDetallePedidoDTO
    {
        public int DetallePedidoId { get; set; }
        public int Cantidad { get; set; }
        public int ProductoId { get; set; }

        //public List<ProductoDTO> Productos { get; set; } = new List<ProductoDTO>();

    }
}
