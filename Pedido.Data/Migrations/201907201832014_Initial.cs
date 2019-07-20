namespace Pedido.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pedidoes",
                c => new
                    {
                        PedidoId = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.PedidoId);
            
            CreateTable(
                "dbo.Produtoes",
                c => new
                    {
                        ProdutoId = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.ProdutoId);
            
            CreateTable(
                "dbo.ProdutoPedidoes",
                c => new
                    {
                        Produto_ProdutoId = c.Int(nullable: false),
                        Pedido_PedidoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Produto_ProdutoId, t.Pedido_PedidoId })
                .ForeignKey("dbo.Produtoes", t => t.Produto_ProdutoId, cascadeDelete: true)
                .ForeignKey("dbo.Pedidoes", t => t.Pedido_PedidoId, cascadeDelete: true)
                .Index(t => t.Produto_ProdutoId)
                .Index(t => t.Pedido_PedidoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProdutoPedidoes", "Pedido_PedidoId", "dbo.Pedidoes");
            DropForeignKey("dbo.ProdutoPedidoes", "Produto_ProdutoId", "dbo.Produtoes");
            DropIndex("dbo.ProdutoPedidoes", new[] { "Pedido_PedidoId" });
            DropIndex("dbo.ProdutoPedidoes", new[] { "Produto_ProdutoId" });
            DropTable("dbo.ProdutoPedidoes");
            DropTable("dbo.Produtoes");
            DropTable("dbo.Pedidoes");
        }
    }
}
