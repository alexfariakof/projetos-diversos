using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Pessoa
    {
        public virtual int Id { get; set; }
        public virtual String Nome { get; set; }
        public virtual int Idade { get; set; }
        public virtual String Endereco { get; set; }
    }
}
