using Dominio;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.NHibernate.Maps
{
    public class PessoaMap : ClassMapping<Pessoa>
    {
        public PessoaMap()
        {
            Table("Pessoas");
            Id(pk => pk.Id, (map) => { map.Generator(Generators.Identity); });
            Property(p => p.Nome);
            Property(p => p.Idade);
            Property(p => p.Endereco);
        }
    }
}
