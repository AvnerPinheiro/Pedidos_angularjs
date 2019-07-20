using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedido.Dominio
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public string Descricao { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}
