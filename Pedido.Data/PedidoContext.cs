using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pedido.Dominio;

namespace Pedido.Data
{
    public class PedidoContext : DbContext
    {
        public DbSet<Pedido.Dominio.Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        public PedidoContext() : base("Pedido_Avner")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<PedidoContext>());
        }
    }
}
