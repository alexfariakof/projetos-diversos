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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CadastroPessoas.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, RoutedEventArgs e)
        {
            AdicionarPessoas winAdicionarPessoas = new AdicionarPessoas();
            winAdicionarPessoas.ShowDialog();
            PreencherGridView();
        }

        private void PreencherGridView()
        {
            IRepositorio<Pessoa> repositoriopessoas = new HPessoaRepositorio();
            List<Pessoa> pessoas = repositoriopessoas.Get();
            dgPessoas.DataContext = pessoas;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            PreencherGridView();
        }
    }
}
