using Pedido.Data;
using Pedido.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedido.Service
{
    public static class ProdutoService
    {
        public static List<ProdutoDTO> ListarTodosProdutos()
        {
            return ProdutoData.Listar().Select(x => new ProdutoDTO {
                Descricao = x.Descricao,
                ProdutoId = x.ProdutoId
            }).ToList();
        } 
    }
}
