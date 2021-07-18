using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Repositorio;

namespace CadastroPessoas
{
    public partial class FrmAdcionarPessoas : Form
    {
        public FrmAdcionarPessoas()
        {
            InitializeComponent();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa
            {
                Nome = txtNome.Text,
                Idade = txtIdade.Text.ToInteger(),
                Endereco = txtEndereco.Text
            };

            IRepositorio<Pessoa> repositorioPessoa = new PessoaRepositorio();
            repositorioPessoa.Add(pessoa, (linhasAfetadas) => 
            {
                MessageBox.Show(String.Format("Linhas Afetadas {0}", linhasAfetadas));
            });
            Close();
        }
    }
}
