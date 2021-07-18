using Dominio;
using Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroPessoas
{
    public partial class Form1 : Form
    {
        List<Pessoa> _pessoas = new List<Pessoa>();
        private static readonly object locker = new Object();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAdcionarPessoas frmAdcionarPessoas = new FrmAdcionarPessoas();
            frmAdcionarPessoas.ShowDialog();
            PreencherGridView();

        }

        private void PreencherGridView()
        {
            dtgPessoas.DataSource = null;
            Thread.Sleep(5000);
            Thread thread = new Thread(PreencherListaPessoas);
            //Thread thread2 = new Thread(PreencherListaPessoas2);
            thread.Start();
           // thread2.Start();
            thread.Join();
            //thread2.Join();
            //dtgPessoas.DataSource = pessoas;
            PreencherListaPessoas();
            dtgPessoas.Invoke((MethodInvoker)delegate { dtgPessoas.DataSource = _pessoas; dtgPessoas.Refresh(); });
        }

        private void PreencherListaPessoas()
        {
            try
            {
                IRepositorio<Pessoa> repositoriopessoas = new PessoaRepositorio();
                List<Pessoa> pessoas = repositoriopessoas.Get();
                lock (locker)
                {
                    foreach (Pessoa p in pessoas)
                    {
                        p.Nome += "Thread 1 ";
                        _pessoas.Add(p);
                        Thread.Sleep(100);
                    }
                }
            }
            catch (Exception e)
            {
                showMessageErro(e);
            }
        }


        private void PreencherListaPessoas2()
        {           
            try
            {
                throw new Exception("PreencherListaPessoas2");
                IRepositorio<Pessoa> repositoriopessoas = new PessoaRepositorio();
                List<Pessoa> pessoas = repositoriopessoas.Get();

                lock (locker)
                {
                    foreach (Pessoa p in pessoas)
                    {
                        p.Nome += "Thread 2 ";
                        _pessoas.Add(p);
                        Thread.Sleep(300);
                    }
                }
            }
            catch (Exception e)
            { showMessageErro(e); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(PreencherGridView);
            thread.Start();
        }


        private void showMessageErro(Exception e)
        {
            MessageBox.Show(e.Message);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            IRepositorio<Pessoa> repositorio = new PessoaRepositorio();
            dtgPessoas.DataSource = repositorio.Selecionar(p => p.Nome.Contains(txtPesquisar.Text));
            dtgPessoas.Refresh();
        }
    }
}
