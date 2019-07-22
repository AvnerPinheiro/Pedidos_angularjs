using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedido.Dominio
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Descricao { get; set; }
        public long Valor { get; set; }
        public virtual List<Pedido> Pedidos { get; set; }
    }
}
