using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public static class Extension
    {
        public static int ToInteger(this String strToConvert)
        {
            int strConvert;
            int.TryParse(strToConvert, out strConvert);
            return strConvert;
        }

        public static int ToInteger(this object objToConvert)
        {
            int objConvert;
            int.TryParse(objToConvert.ToString(), out objConvert);
            return objConvert;

        }
    }
}
