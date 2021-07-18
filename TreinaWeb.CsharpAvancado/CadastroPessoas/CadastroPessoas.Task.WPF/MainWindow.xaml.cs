using Dominio;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace CadastroPessoas._Task.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Pessoa> lstPessos = new List<Pessoa>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Load();
        }

        private void Load()
        {
            try
            {
                var tarefa = Task<int>.Run(() =>
                {
                    throw new Exception("testando Erro na task");
                    Thread thread = new Thread(fillProgressBar);
                    thread.Start();
                    Thread.Sleep(5000);
                    IRepositorio<Pessoa> repositoriopessoas = new HPessoaRepositorio();
                    lstPessos = repositoriopessoas.Get();
                    thread.Abort();
                    return lstPessos.Count;

                });

                var tarefa2 = tarefa.ContinueWith((task) =>
                  {
                      try
                      {
                          dtgPessoas.Dispatcher.Invoke((Action)(() =>
                          {
                              dtgPessoas.ItemsSource = lstPessos;

                          }));
                          MessageBox.Show(String.Format("Carregamento Concluido ! \n Quantidade de registros {0}", task.Result.ToString()));
                      }
                      catch (AggregateException ex)
                      {
                          String message = "";
                          foreach (Exception exception in ex.InnerExceptions)
                          {
                              message += exception.Message;
                          }
                          MessageBox.Show(String.Format("Erro na Task AggredateException {0} ! ", message));
                      }
                  }).ContinueWith((taskant) =>
                    {
                        MessageBox.Show("Carregamento Concluido ! ");
                    });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
   
         }

        private void fillProgressBar()
        {
            for (int i = 0; i <= 5000; i++)
            {
                pbDtgPessoas.Dispatcher.Invoke((Action)(() =>
                {
                    pbDtgPessoas.Value += 10;
                }));
                
                Thread.Sleep(10);
            }
        }



        private async void PreencherGridView()
        {

            dtgPessoas.ItemsSource = null;
            pbDtgPessoas.Value = 0;
            await Task.Run(() =>
            {

                Thread thread = new Thread(fillProgressBar);
                thread.Start();
                Thread.Sleep(5000);
                IRepositorio<Pessoa> repositoriopessoas = new HPessoaRepositorio();

                dtgPessoas.Dispatcher.Invoke((Action)(() =>
                {
                    dtgPessoas.ItemsSource = repositoriopessoas.Get();
                    thread.Abort();
                }));

            });         
        }

        private void btnAdicionar_Click(object sender, RoutedEventArgs e)
        {
            AdicionarPessoas winAdicionarPessoas = new AdicionarPessoas();
            winAdicionarPessoas.ShowDialog();
            PreencherGridView();
        }

        private void btnCarregarAssicrono_Click(object sender, RoutedEventArgs e)
        {
            PreencherGridView();
        }
    }
}
