using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoas
{
    class Tarefa
    {

        Tarefa()
        {


            Task.Run(async () => await LerArquivo()).Wait();
        }

        private static  Task LerArquivo()
        {
            return Task.Run(() =>
            {


            });

        }
    }
}
