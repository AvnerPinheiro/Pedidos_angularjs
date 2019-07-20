using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedido.Data
{
    public static class PedidoData
    {
        public static void Salvar(Pedido.Dominio.Pedido pedido)
        {
            using (var db = new PedidoContext())
            {
                db.Pedidos.Add(pedido);
                db.SaveChanges();
            }
        }

        public static IQueryable<Dominio.Pedido> Listar()
        {
            return new PedidoContext().Pedidos.AsQueryable();
        }
    }
}
