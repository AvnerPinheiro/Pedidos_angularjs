namespace Pedido.Data.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Pedido.Data.PedidoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Pedido.Data.PedidoContext context)
        {
            List<Dominio.Produto> lstProdutos = new List<Dominio.Produto>();
            lstProdutos.Add(new Dominio.Produto { ProdutoId = 1, Descricao = "Produto 1", Valor = 1 });
            lstProdutos.Add(new Dominio.Produto { ProdutoId = 2, Descricao = "Produto 2", Valor = 2 });
            lstProdutos.Add(new Dominio.Produto { ProdutoId = 3, Descricao = "Produto 3", Valor = 3 });
            lstProdutos.Add(new Dominio.Produto { ProdutoId = 4, Descricao = "Produto 4", Valor = 4 });
            lstProdutos.Add(new Dominio.Produto { ProdutoId = 5, Descricao = "Produto 5", Valor = 5 });
            lstProdutos.Add(new Dominio.Produto { ProdutoId = 6, Descricao = "Produto 6", Valor = 6 });

            context.Produtos.AddRange(lstProdutos);
        }
    }
}
