using Persistencia.DAO.POCO;
using Persistencia.DAO.Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao.Forms
{
    public partial class FrmCadastroCliente : Form
    {
        private Cliente _cliente;

        public FrmCadastroCliente(Cliente pCliente = null)
        {
            this._cliente = pCliente;
            InitializeComponent();
        }

        public FrmCadastroCliente()
        {
            InitializeComponent();
        }

        private void FrmCadastroCliente_Load(object sender, EventArgs e)
        {
            if (this._cliente != null)
            {
                txtNome.Text = this._cliente.Nome;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            if (_cliente == null)
            {
                cliente.Nome = txtNome.Text;
                new RepositorioCliente().Insert(cliente);
            }
            else
            {
                cliente.Id = this._cliente.Id;
                cliente.Nome = txtNome.Text;
                new RepositorioCliente().Update(cliente);
            }

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
    }
}
