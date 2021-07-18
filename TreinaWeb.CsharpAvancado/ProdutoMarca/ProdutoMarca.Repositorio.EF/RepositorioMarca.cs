using ProdutoMarca.Dominio;
using ProdutoMarca.Persistencia.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoMarca.Repositorio.EF
{
    public class RepositorioMarca : IRepositorioGenerico<Marca>
    {       
        public Marca GetById(int Id)
        {
            Marca marca = new Marca();
            using (ProdutoMarcaDB contexto = new ProdutoMarcaDB())
            {
                marca = contexto.Marcas.Find(Id);
            }
            return marca;
        }

        public Task<List<Marca>> GetAll()
        {
            return Task.Run(() =>
            {
                List<Marca> lstMarca = new List<Marca>();
                using (ProdutoMarcaDB contexto = new ProdutoMarcaDB())
                {
                    lstMarca = contexto.Marcas.ToList();
                }
                return lstMarca;
            });
        }

        public void insert(Marca dominio)
        {
            using (ProdutoMarcaDB contexto = new ProdutoMarcaDB())
            {
                contexto.Marcas.Add(dominio);
                contexto.SaveChanges();
            }
        }

        public void update(Marca dominio)
        {
            using (ProdutoMarcaDB contexto = new ProdutoMarcaDB())
            {
                contexto.Marcas.Attach(dominio);
                contexto.Entry(dominio).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public void delete(Marca dominio)
        {
            using (ProdutoMarcaDB contexto = new ProdutoMarcaDB())
            {
                contexto.Marcas.Attach(dominio);
                contexto.Entry(dominio).State = System.Data.Entity.EntityState.Deleted;
                contexto.SaveChanges();
            }
        }
    }
}
