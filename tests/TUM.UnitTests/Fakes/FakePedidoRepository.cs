using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUM.Domain.Entities;
using TUM.Application.Common.Interfaces;

namespace TUM.UnitTests.Fakes
{
    internal class FakePedidoRepository : IPedidoRepository
    {
        private readonly List<Pedido> _pedidos = new();

        public Task AddASync(Pedido pedido)
        {
            pedido.PedidoId = _pedidos.Count + 1;
            _pedidos.Add(pedido);
            return Task.CompletedTask;
        }

        public Task<Pedido?> GetByIdAsync(int id)
        {
            return Task.FromResult(_pedidos.FirstOrDefault(p=> p.PedidoId == id));
        }

        public List<Pedido> GetAll() {
            return _pedidos;

        }
    }
}
