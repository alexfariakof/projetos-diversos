using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesGenericos
{
    class Program
    {

        delegate T CalculoMatematico<T>(T a, T b);

        static void Main(string[] args)
        {
            Program p = new Program();

            

            Func<int, int, int> calcular = p.Somar;
            Console.WriteLine(calcular(2,5).ToString());
            
            Action<int> impressao = p.ImprimirResultado;
            impressao(calcular(3, 8));
            Console.ReadKey();



            CalculoMatematico<int> calculo = new CalculoMatematico<int>(p.Somar);
            ExibirInformacoesDelegate(calculo);
            impressao(calculo(3, 9));
            
            CalculoMatematico<double> calculoDecimal = new CalculoMatematico<double>(Program.dividir);
            ExibirInformacoesDelegate(calculoDecimal);
            impressao(calculo(3, 20));
            Console.ReadKey();
        }

        private static void ExibirInformacoesDelegate<T>(CalculoMatematico<T> calculo)
        {
            Console.WriteLine(calculo.Target);
            Console.WriteLine(calculo.Method);
        }

        int Somar(int a, int b)
        {
            return a + b;
        }

        decimal SomarDecimal(decimal a, decimal b)
        {
            return a + b;

        }

        static double dividir(double a, double b)
        {
            return a / b; 
        }

        void ImprimirResultado(int resultado)
        {
            Console.WriteLine(resultado);
        }

    }
}
