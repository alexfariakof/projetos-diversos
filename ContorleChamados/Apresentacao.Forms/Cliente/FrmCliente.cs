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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            FillGridViewCliente();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = dgvCliente.CurrentRow.Cells[0].Value.ToInteger();
            new RepositorioCliente().Delete(id);
            FillGridViewCliente();
        }



        private void FillGridViewCliente()
        {
            IRepositorio<Cliente> repositorio = new RepositorioCliente();
            dgvCliente.DataSource = repositorio.GetAll();
            dgvCliente.Refresh();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            FrmCadastroCliente frm = new FrmCadastroCliente();
            frm.ShowDialog();
            FillGridViewCliente();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            IRepositorio<Cliente> repositorio = new RepositorioCliente();
            int id = dgvCliente.CurrentRow.Cells[0].Value.ToInteger();
            FrmCadastroCliente frm = new FrmCadastroCliente(repositorio.GetById(id));
            frm.ShowDialog();
            FillGridViewCliente();
        }
    }
}
