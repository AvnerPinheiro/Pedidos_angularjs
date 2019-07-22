namespace Pedido.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adicionadovaloraoproduto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produtoes", "Valor", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Produtoes", "Valor");
        }
    }
}
