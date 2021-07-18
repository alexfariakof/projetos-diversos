using ProdutoMarca.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoMarca.Persistencia.Context
{
    public class ProdutoMarcaDB : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Marca> Marcas { get; set; }

        public ProdutoMarcaDB()
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>()
                .HasRequired(p => p.Marca)
                .WithMany(p => p.LstProduto)
                .HasForeignKey(fk => fk.IdMarca)
                .WillCascadeOnDelete(false);

           // base.OnModelCreating(modelBuilder);
        }
    }
}
