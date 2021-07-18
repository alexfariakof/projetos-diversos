using ProdutoMarca.Apresentacao.ViewModel;
using ProdutoMarca.Dominio;
using ProdutoMarca.Repositorio;
using ProdutoMarca.Repositorio.EF;
using ProdutoMarca.Extensions;
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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            FillDataGridViewMarcaAsync();
            FillDataGridViewProdutoAsync();
        }

        #region Metodos Marca
        private async void FillDataGridViewMarcaAsync()
        {
            IRepositorioGenerico<Marca> repositorioMarcas = new RepositorioMarca();
            List<Marca> lstMarca = await repositorioMarcas.GetAll();
            List<MarcaViewModel> lstMarcaViewModel = new List<MarcaViewModel>();
            foreach (Marca marca in lstMarca)
            {
                MarcaViewModel viewModel = new MarcaViewModel
                {
                    Id = marca.Id,
                    Nome = marca.Nome
                };
                lstMarcaViewModel.Add(viewModel);
            }
            dgvMarcas.Invoke((MethodInvoker)delegate
            {
                dgvMarcas.DataSource = lstMarcaViewModel;
                dgvMarcas.Refresh();
            });
        }


        private void btnNewMarca_Click(object sender, EventArgs e)
        {
            FrmNewMarca frm = new FrmNewMarca();
            frm.ShowDialog();
            FillDataGridViewMarcaAsync();
        }



        private void btnUpdateMarca_Click(object sender, EventArgs e)
        {
            if (dgvMarcas.SelectedRows.Count > 0)
            {
                int idMarcaSelected = dgvMarcas.SelectedRows[0].Cells[0].Value.ToInteger();
                IRepositorioGenerico<Marca> repositorioMarcas = new RepositorioMarca();
                Marca marcaToUpdate = repositorioMarcas.GetById(idMarcaSelected);
                FrmNewMarca frm = new FrmNewMarca(marcaToUpdate);
                frm.ShowDialog();
                FillDataGridViewMarcaAsync();
                FillDataGridViewProdutoAsync();
            }
            else
            {
                MessageBox.Show("Selecione uma Marca antes.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteMarca_Click(object sender, EventArgs e)
        {
            if (dgvMarcas.SelectedRows.Count > 0)
            {
                int idMarcaSelected = dgvMarcas.SelectedRows[0].Cells[0].Value.ToInteger();
                IRepositorioGenerico<Marca> repositorioMarcas = new RepositorioMarca();
                Marca marcaToDelete = repositorioMarcas.GetById(idMarcaSelected);
                repositorioMarcas.delete(marcaToDelete);
                FillDataGridViewMarcaAsync();
            }
            else
            {
                MessageBox.Show("Selecione uma Marca antes.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        #endregion

        #region Metodos Produto
        private async void FillDataGridViewProdutoAsync()
        {
            IRepositorioGenerico<Produto> repositorioMarcas = new RepositorioProduto();
            List<Produto> lstProduto = await repositorioMarcas.GetAll();
            List<ProdutoViewModel> lstProdutoViewModel = new List<ProdutoViewModel>();
            foreach (Produto produto in lstProduto)
            {
                ProdutoViewModel viewModel = new ProdutoViewModel
                {
                    Id = produto.Id,
                    Nome = produto.Nome,
                    IdMarca = produto.IdMarca,
                    NomeMarca = produto.Marca.Nome

                };
                lstProdutoViewModel.Add(viewModel);
            }

            dgvProduto.Invoke((MethodInvoker)delegate
            {
                dgvProduto.DataSource = lstProdutoViewModel;
                dgvProduto.Refresh();
            });


        }

        private void btnNewProduto_Click(object sender, EventArgs e)
        {
            FrmNewProduto frm = new FrmNewProduto();
            frm.ShowDialog();
            FillDataGridViewProdutoAsync();

        }
        private void btnUpdateProduto_Click(object sender, EventArgs e)
        {
            if (dgvProduto.SelectedRows.Count > 0)
            {
                int idProdutoSelected = dgvProduto.SelectedRows[0].Cells[1].Value.ToInteger();
                IRepositorioGenerico<Produto> repositorio = new RepositorioProduto();
                Produto produtoToUpdate = repositorio.GetById(idProdutoSelected);
                FrmNewProduto frm = new FrmNewProduto(produtoToUpdate);
                frm.ShowDialog();
                FillDataGridViewProdutoAsync();
            }
            else
            {
                MessageBox.Show("Selecione um Produto antes.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteProduto_Click(object sender, EventArgs e)
        {
            if (dgvProduto.SelectedRows.Count > 0)
            {
                int idProdutoSelected = dgvProduto.SelectedRows[0].Cells[1].Value.ToInteger();
                IRepositorioGenerico<Produto> repositorio = new RepositorioProduto();
                Produto produtoToDelete = repositorio.GetById(idProdutoSelected);
                repositorio.delete(produtoToDelete);
                FillDataGridViewMarcaAsync();
                FillDataGridViewProdutoAsync();
            }
            else
            {
                MessageBox.Show("Selecione um Produto antes de realizar a exclusão.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        #endregion

    }
}
