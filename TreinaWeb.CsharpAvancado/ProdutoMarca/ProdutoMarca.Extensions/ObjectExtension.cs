using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoMarca.Extensions
{
    public static class ObjectExtension
    {
        public static int ToInteger(this object objToConvert)
        {
            int objConvert;
            int.TryParse(objToConvert.ToString(), out objConvert);
            return objConvert;

        }
    }
}
