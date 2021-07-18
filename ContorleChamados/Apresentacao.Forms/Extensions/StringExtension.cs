using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apresentacao.Forms
{
    public static class StringExtension
    {
        public static int ToInteger(this String strToConvert)
        {
            int strConvert;
            int.TryParse(strToConvert, out strConvert);
            return strConvert;
        }       
    }
}
