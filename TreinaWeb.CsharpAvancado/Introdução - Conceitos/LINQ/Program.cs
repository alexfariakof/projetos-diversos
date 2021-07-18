using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> pessoas = CarregarListaPessoa();

            //
            IEnumerable<Pessoa> pessoaMaisDoisIrmaos = from pessoa in pessoas
                                                       where pessoa.QuantidadeIrmaos > 2
                                                       orderby pessoa
                                                       select pessoa;
            foreach (Pessoa p in pessoaMaisDoisIrmaos)
                Console.WriteLine("Nome : {0}, \n Idade  : {1}, \n Irmãos : {2}", p.Nome, p.Idade, p.QuantidadeIrmaos);
            Console.ReadKey();


            pessoaMaisDoisIrmaos = pessoas.Where(p => p.QuantidadeIrmaos <= 2).OrderBy(p => p.Nome).ThenBy(p => p.Idade);                
            foreach (Pessoa p in pessoaMaisDoisIrmaos)
                Console.WriteLine(" Nome : {0}, \n Idade  : {1}, \n Irmãos : {2}", p.Nome, p.Idade, p.QuantidadeIrmaos);
            Console.ReadKey();

            var pessoasLinq = pessoas.Where(p => p.Idade > 20).OrderByDescending(p => p.Idade).Select(p => new { p.Nome, p.Idade });
            foreach (var p in pessoasLinq)
                Console.WriteLine(" Nome : {0}, \n Idade  : {1}, \n Irmãos : ", p.Nome, p.Idade);
            Console.ReadKey();



        }
        static List<Pessoa> CarregarListaPessoa()
        {
            List<Pessoa> lstPessoa = new List<Pessoa>
        {
            new Pessoa
            {
                Nome = "Alex Ribeiro",
                Idade = 34,
                QuantidadeIrmaos = 1
            },
            new Pessoa
            {
                Nome = "Izaide Ribeiro",
                Idade = 60,
                QuantidadeIrmaos = 2

            },
            new Pessoa
            {
                Nome = "Thalita Texeira",
                Idade = 32,
                QuantidadeIrmaos = 4
            }
        };
            return lstPessoa;
        }
    }
    class Pessoa : IEnumerable
    {
        public int id { get; set; }
        public String Nome { get; set; }
        public int Idade { get; set; }
        public int QuantidadeIrmaos { get; set; }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

}