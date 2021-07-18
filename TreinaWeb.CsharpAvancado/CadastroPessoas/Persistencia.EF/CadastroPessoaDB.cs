using Dominio;
using System.Data.Entity;

namespace Persistencia.EF
{
    public class CadastroPessoaDB : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
    }
}
