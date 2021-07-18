using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateMulticast
{
    class Program
    {

        delegate void VertificacaoIdade(int idade);
        static VertificacaoIdade verificaIdade;
        static void Main(string[] args)
        {
            // Usuário Informa se ele é homem ou mulher 
            //Usuario também informa idade
            //Se for Homem:
            //Se tiver menos que 21 anos: "Você ainda está crescendo"
            //Se ele tiver mais que 25 anos : "Você já cresceu"
            //Se ele tiver mais que 25 anos : "Você pode carregar bastante peso"
            //Se você tiver menos que 25 anos : "Você não pode carregar tanto peso"
            //Se for mulher 
            //Se tiver menos que 18 anos : "Você ainda esta crescendo"
            //Se ela tiver mais que 18 anos : "Você já cresceu"
            //Se ela tiver mais que 30 anos : "Você pode carregar bastante peso "
            //Se ela tiver menos que 30 anos: "Você não pode carrehar tanto peso"

            Console.WriteLine("Digite seu sexo:");
            String sexoUsuario = Console.ReadLine();
            Console.WriteLine("Digite sua idade:");
            int idadeUsuario = Convert.ToInt32(Console.ReadLine());

            if (sexoUsuario.Equals("H"))
            {

                verificaIdade = new VertificacaoIdade(VerificaIdadeHomem);
                verificaIdade += VerificaCarregamentoPesoHomem;
            }
            else
            {
                verificaIdade = new VertificacaoIdade(VerificaIdadeMulher);
                verificaIdade += VerificaCarregamentoPesoMulher;
            }

            verificaIdade(idadeUsuario);
            Console.ReadKey();
        }


        //Homens
        static void VerificaIdadeHomem(int idade)
        {
            if (idade < 21)
            {
                Console.WriteLine("Você ainda está crescendo");
            }
            else
            {
                Console.WriteLine("Você já cresceu");
            }
        }

        static void VerificaCarregamentoPesoHomem(int idade)
        {
            if (idade > 25)
            {
                Console.WriteLine("Você pode carregar bastante peso");
            }
            else
            {
                Console.WriteLine("Você não pode carregar tanto peso");
            }
        }

        static void VerificaIdadeMulher(int idade)
        {
            if (idade < 18)
            {
                Console.WriteLine("Você ainda esta crescendo");
            }
            else
            {
                Console.WriteLine("Você já cresceu");
            }
        }

        static void VerificaCarregamentoPesoMulher(int idade)
        {
            if (idade > 30)
            {
                Console.WriteLine("Você pode carregar bastante peso");
            }
            else
            {
                Console.WriteLine("Você não pode carregar tanto peso");
            }
        }



    }
}
