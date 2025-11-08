using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUM.Domain.Entities;

namespace TUM.Application.Common.Interfaces
{
    public interface IPedidoRepository
    {
        Task AddASync(Pedido pedido);
        Task<Pedido?> GetByIdAsync(int id);

    }
}
