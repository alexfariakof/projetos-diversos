using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covariancia_Contravariancia
{
    class Program
    {
        static void Main(string[] args)
        {
            ManipuladorFTP<Nivel2> ftp = new ManipuladorFTP<Nivel2>();
            /*ContraVariancia*/
            ftp.Armazenar(new Nivel3());
            Console.WriteLine(ftp.Recuperar(0));
            Console.ReadKey();

            /*Covariancia*/
            ManipuladorFTP<Nivel3> ftpCovariancia = new ManipuladorFTP<Nivel3>();
            IRecuperador<Nivel1> armazenador = ftp;            
            Console.WriteLine(ftpCovariancia.Recuperar(0));
            Console.ReadKey();



        }
    }
}
