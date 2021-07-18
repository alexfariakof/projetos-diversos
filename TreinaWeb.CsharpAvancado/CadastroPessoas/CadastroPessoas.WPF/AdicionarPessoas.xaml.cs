using Dominio;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CadastroPessoas.WPF
{
    /// <summary>
    /// Interaction logic for AdicionarPessoas.xaml
    /// </summary>
    public partial class AdicionarPessoas : Window
    {
        public AdicionarPessoas()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            Pessoa pessoa = new Pessoa
            {
                Nome = txtNome.Text,
                Idade = txtIdade.Text.ToInteger(),
                Endereco = txtEndereco.Text
            };

            IRepositorio<Pessoa> repositorioPessoa = new HPessoaRepositorio();
            repositorioPessoa.Add(pessoa);
            Close();
        }
    }
}
