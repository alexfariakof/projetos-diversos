using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoMarca.Dominio
{
    public class Marca
    {
        public int Id { get; set; }
        public String  Nome { get; set; }
        public List<Produto> LstProduto { get; set; }
    }
}
