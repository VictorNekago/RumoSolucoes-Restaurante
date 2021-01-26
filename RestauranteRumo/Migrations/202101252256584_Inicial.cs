namespace RestauranteRumo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bebida",
                c => new
                    {
                        Identificador = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 20, unicode: false),
                        Mililitro = c.Int(),
                        Quantidade = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Identificador);
            
            CreateTable(
                "dbo.Pedido",
                c => new
                    {
                        Identificador = c.Int(nullable: false, identity: true),
                        NomeSolicitante = c.String(nullable: false, maxLength: 20, unicode: false),
                        NumeroMesa = c.Int(nullable: false),
                        IdentificadorPrato = c.Int(nullable: false),
                        IdentificadorBebida = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Identificador)
                .ForeignKey("dbo.Bebida", t => t.IdentificadorBebida)
                .ForeignKey("dbo.Prato", t => t.IdentificadorPrato)
                .Index(t => t.IdentificadorPrato)
                .Index(t => t.IdentificadorBebida);
            
            CreateTable(
                "dbo.Prato",
                c => new
                    {
                        Identificador = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 20, unicode: false),
                        Quantidade = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Identificador);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pedido", "IdentificadorPrato", "dbo.Prato");
            DropForeignKey("dbo.Pedido", "IdentificadorBebida", "dbo.Bebida");
            DropIndex("dbo.Pedido", new[] { "IdentificadorBebida" });
            DropIndex("dbo.Pedido", new[] { "IdentificadorPrato" });
            DropTable("dbo.Prato");
            DropTable("dbo.Pedido");
            DropTable("dbo.Bebida");
        }
    }
}
