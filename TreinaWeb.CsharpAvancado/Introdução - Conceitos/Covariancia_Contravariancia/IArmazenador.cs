using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covariancia_Contravariancia
{
    //para torna a esta interface contravariantes deve se colocar a expressão in 
    //interface IArmazenador<in T>
    interface IArmazenador<in T>
    {
        void Armazenar(T item);
    }

    
}
