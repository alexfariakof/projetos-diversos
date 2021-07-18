using Dominio;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Cfg.MappingSchema;
using NHibernate.Mapping.ByCode;
using Persistencia.NHibernate.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class HPessoaRepositorio  : IRepositorio<Pessoa>
    {
        private ISessionFactory _sessionFactory;

        //Este Construtor deve ser utilizado apenas quando for utilizado NHBerbate
        public HPessoaRepositorio()
        {
            Configuration config = new Configuration();
            config.Configure();
            config.AddAssembly(typeof(Pessoa).Assembly);
            HbmMapping mapping = CreateMapping();
            config.AddDeserializedMapping(mapping, null);
            _sessionFactory = config.BuildSessionFactory();
        }

        private HbmMapping CreateMapping()
        {
            ModelMapper mapper = new ModelMapper();
            mapper.AddMapping(typeof(PessoaMap));

            return mapper.CompileMappingForAllExplicitlyAddedEntities();
        }

        public List<Pessoa> Get()
        {
            using (ISession session = _sessionFactory.OpenSession())
            {
                IQuery consulta = session.CreateQuery("From Pessoa");
                return consulta.List<Pessoa>().ToList();
            }            
        }

        public void Add(Pessoa objeto)
        {
            Add(objeto, null);

        }

        public void Add(Pessoa objeto, Action<int> callBack)
        {
            using (ISession session = _sessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Save(objeto);
                    transaction.Commit();
                }
            }
           
        }

        public int Update(Pessoa objeto)
        {
            throw new NotImplementedException();
        }

        public int Cancel(Pessoa objeto)
        {
            throw new NotImplementedException();
        }

        public List<Pessoa> Selecionar(Func<Pessoa, bool> whereClause)
        {
            using (ISession session = _sessionFactory.OpenSession())
            {
                IQuery consulta = session.CreateQuery("From Pessoa");
                return consulta.List<Pessoa>().Where(whereClause).ToList();
            }
        }
    }
}
