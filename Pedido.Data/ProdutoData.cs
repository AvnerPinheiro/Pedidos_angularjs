using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedido.Data
{
    public static class ProdutoData
    {
        public static List<Dominio.Produto> Listar()
        {
            return new PedidoContext().Produtos.ToList();
        }
    }
}
