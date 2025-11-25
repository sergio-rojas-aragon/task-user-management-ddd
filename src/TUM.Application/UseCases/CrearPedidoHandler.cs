using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUM.Application.Common.Interfaces;
using TUM.Application.DTOs;
using TUM.Domain.Entities;

namespace TUM.Application.UseCases
{
    internal class CrearPedidoHandler (IPedidoRepository pedidoRepository)
    {
        private readonly IPedidoRepository _pedidoRepository;


        public async Task<int> Handle(CrearPedidoDTO dto)
        {
            var pedido = new Pedido
            {
                ClienteId = dto.ClienteId,
                //UsuarioId = dto.UsuarioId,
                CreatedAt = dto.CreatedAt,
                CreatedBy = dto.CreatedBy,
                Fecha = DateTime.Now
            };

            foreach (var item in dto.DetallePedido)
            {
                pedido.DetallePedidos.Add(new DetallePedido
                {
                    Cantidad = item.Cantidad,
                    ProductoId = item.ProductoId
                });
            }

            await _pedidoRepository.AddASync(pedido);

            return pedido.PedidoId;

        }
    }
}
