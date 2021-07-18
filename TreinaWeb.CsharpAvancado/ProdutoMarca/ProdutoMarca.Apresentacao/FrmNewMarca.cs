using ProdutoMarca.Dominio;
using ProdutoMarca.Repositorio;
using ProdutoMarca.Repositorio.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdutoMarca.Apresentacao
{
    public partial class FrmNewMarca : Form
    {
        private Marca marcaToUpdate;

        public FrmNewMarca(Marca marca = null)
        {
            marcaToUpdate = marca;
            InitializeComponent();
        }

        private void FrmNewMarca_Load(object sender, EventArgs e)
        {
            if (marcaToUpdate != null)
            {
                txtNomeMarca.Text = marcaToUpdate.Nome;
            }
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            IRepositorioGenerico<Marca> repositorio = new RepositorioMarca();
            if (marcaToUpdate == null)
            {
                Marca marca = new Marca
                {
                    Nome = txtNomeMarca.Text
                };

                repositorio.insert(marca);

            }
            else
            {
                marcaToUpdate.Nome = txtNomeMarca.Text;
                repositorio.update(marcaToUpdate);
            }
            Close();
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
