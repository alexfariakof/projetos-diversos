using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covariancia_Contravariancia
{
    class ManipuladorFTP<T> : IArmazenador<T>, IRecuperador<T>
    {

        private List<T> _lista = new List<T>();

        public void Armazenar(T item)
        {
            _lista.Add(item);
            Console.WriteLine("Armazenando item " + _lista[_lista.LastIndexOf(item)].ToString());           
        }

        public T Recuperar(int codigo)
        {
            Console.WriteLine("Retornando item " + _lista[codigo].ToString());
            return _lista[codigo];
        }
    }
}
