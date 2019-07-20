using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedido.DTO
{
    public class PedidoDTO
    {
        public int PedidoId { get; set; }
        [Required]
        public string Descricao { get; set; }
        public List<ProdutoDTO> Produtos { get; set; }

    }
}
