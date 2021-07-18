using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoMarca.Repositorio
{
    public interface IRepositorioGenerico<TDominio>
    {
        Task<List<TDominio>> GetAll();
        TDominio GetById(int Id);
        void insert(TDominio dominio);
        void update(TDominio dominio);
        void delete(TDominio dominio);
    }
}
