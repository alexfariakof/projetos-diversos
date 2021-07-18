using ProdutoMarca.Dominio;
using ProdutoMarca.Persistencia.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoMarca.Repositorio.EF
{
    public class RepositorioProduto : IRepositorioGenerico<Produto>
    {
        public Produto GetById(int Id)
        {
            Produto produto = new Produto();
            using (ProdutoMarcaDB contexto = new ProdutoMarcaDB())
            {
                produto = contexto.Produtos.Include("Marca").Single(objeto => objeto.Id == Id);
            }
            return produto;
        }

        public Task<List<Produto>> GetAll()
        {
            return Task.Run(() =>
            {
                List<Produto> lstProduto = new List<Produto>();
                using (ProdutoMarcaDB contexto = new ProdutoMarcaDB())
                {
                    lstProduto = contexto.Produtos.Include("Marca").ToList();
                }
                return lstProduto;
            });
        }

        public void insert(Produto dominio)
        {
            using (ProdutoMarcaDB contexto = new ProdutoMarcaDB())
            {
                Marca marca = contexto.Marcas.Find(dominio.IdMarca);
                dominio.Marca = marca;
                contexto.Produtos.Add(dominio);
                contexto.SaveChanges();
            }
        }

        public void update(Produto dominio)
        {
            using (ProdutoMarcaDB contexto = new ProdutoMarcaDB())
            {
                Marca marca = contexto.Marcas.Find(dominio.IdMarca);
                dominio.Marca = marca;
                contexto.Produtos.Attach(dominio);
                contexto.Entry(dominio).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public void delete(Produto dominio)
        {
            using (ProdutoMarcaDB contexto = new ProdutoMarcaDB())
            {
                contexto.Produtos.Attach(dominio);
                contexto.Entry(dominio).State = System.Data.Entity.EntityState.Deleted;
                contexto.SaveChanges();
            }
        }
    }
}
