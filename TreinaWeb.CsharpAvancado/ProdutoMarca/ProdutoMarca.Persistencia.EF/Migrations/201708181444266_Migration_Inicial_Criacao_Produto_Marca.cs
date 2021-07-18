namespace ProdutoMarca.Persistencia.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration_Inicial_Criacao_Produto_Marca : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Marcas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Produtoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        IdMarca = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Marcas", t => t.IdMarca)
                .Index(t => t.IdMarca);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Produtoes", "IdMarca", "dbo.Marcas");
            DropIndex("dbo.Produtoes", new[] { "IdMarca" });
            DropTable("dbo.Produtoes");
            DropTable("dbo.Marcas");
        }
    }
}
