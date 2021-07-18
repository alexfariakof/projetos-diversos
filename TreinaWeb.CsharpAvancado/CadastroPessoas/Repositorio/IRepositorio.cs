using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public interface IRepositorio<TTipo>
    {
        List<TTipo> Get();
        void Add(TTipo objeto);
        void Add(TTipo objeto, Action<int> callBack);
        int Update(TTipo objeto);
        int Cancel(TTipo objeto);
        List<TTipo> Selecionar(Func<TTipo, Boolean> whereClause);
    }
}
