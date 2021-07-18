using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoExtensao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva o deseja inverter");
            var frase = Console.ReadLine();
            frase.invertStringToUpperCase();
            Console.WriteLine("Frase Invertida e em caixa alto");
            Console.WriteLine(frase);
            Console.WriteLine(frase.Reverse());
            Console.ReadKey();

        }
    }

    public static class InvertStringToUpperCase
    {
        public static String invertStringToUpperCase(this String args)
        {
            return args.ToUpper();
        }

        public static string Reverse(this string text)
        {
            char[] cArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }
    }
}
