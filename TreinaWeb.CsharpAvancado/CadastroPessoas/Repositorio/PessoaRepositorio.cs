using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio;
using Persistencia.EF;
using System.Threading;

namespace Repositorio
{
    public class PessoaRepositorio : IRepositorio<Pessoa>
    {

        public List<Pessoa> Get()
        {
            CadastroPessoaDB contexto = new CadastroPessoaDB();
            List<Pessoa> pessoas = contexto.Pessoas.OrderBy(p => p.Nome).ToList();
            contexto.Dispose();

            return pessoas;
        }

        public async void Add(Pessoa objeto)
        {
            Add(objeto, null);
        }

        public async void Add(Pessoa objeto, Action<int> callBack)
        {
            CadastroPessoaDB contexto;

            contexto = new CadastroPessoaDB();
            contexto.Pessoas.Add(objeto);
            Thread.Sleep(1000);
            await contexto.SaveChangesAsync().ContinueWith((taskAnterior) =>
            {
                if (callBack != null)
                {
                    int linhasAfetadas = taskAnterior.Result;
                    callBack(linhasAfetadas);
                }
                contexto.Dispose();
            });
        }

        public int Update(Pessoa objeto)
        {
            CadastroPessoaDB contexto;
            int resultado = -1;

            contexto = new CadastroPessoaDB();
            contexto.Pessoas.Add(objeto);
            resultado = contexto.SaveChanges();
            contexto.Dispose();

            return resultado;

        }

        public int Cancel(Pessoa objeto)
        {
            throw new NotImplementedException();
        }

        public List<Pessoa> Selecionar(Func<Pessoa, bool> whereClause)
        {
            CadastroPessoaDB contexto = new CadastroPessoaDB();
            List<Pessoa> pessoas = contexto.Pessoas.AsParallel().Where(whereClause).ToList();
            contexto.Dispose();

            return pessoas;

        }
    }
}
