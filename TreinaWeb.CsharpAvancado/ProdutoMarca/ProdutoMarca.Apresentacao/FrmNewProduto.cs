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
    public partial class FrmNewProduto : Form
    {
        private Produto produtoToUpdate;
        public FrmNewProduto(Produto produto = null)
        {
            produtoToUpdate = produto;
            InitializeComponent();
        }

        private void FrmNewProduto_Load(object sender, EventArgs e)
        {
            FillDropDownListMarca();
            if (produtoToUpdate != null)
            {
                txtProduto.Text = produtoToUpdate.Nome;
                ddlMarcas.SelectedValue = produtoToUpdate.IdMarca;
            }
            

        }
        private void btnConfirma_Click(object sender, EventArgs e)
        {            
            IRepositorioGenerico<Produto> repositorio = new RepositorioProduto();
            if (produtoToUpdate == null)
            {
                Produto newProduto = new Produto
                {
                    Nome = txtProduto.Text.Trim(),
                    IdMarca = ddlMarcas.SelectedValue.ToInteger()
                };

                repositorio.insert(newProduto);
            }
            else
            {
                produtoToUpdate.Nome = txtProduto.Text;
                produtoToUpdate.IdMarca = ddlMarcas.SelectedValue.ToInteger();
                repositorio.update(produtoToUpdate);
            }
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void FillDropDownListMarca()
        {
            IRepositorioGenerico<Marca> repositorio = new RepositorioMarca();
            List<Marca> lstMarca = await repositorio.GetAll();
            List<MarcaViewModel> lstViewModel = new List<MarcaViewModel>();
            foreach (Marca marca in lstMarca)
            {
                MarcaViewModel viewModel = new MarcaViewModel
                {
                    Id = marca.Id,
                    Nome = marca.Nome
                };
                lstViewModel.Add(viewModel);
            }
            ddlMarcas.DataSource = lstViewModel;
            ddlMarcas.DisplayMember = "Nome";
            ddlMarcas.ValueMember = "Id";
            ddlMarcas.Refresh();
        }

       
    }
}
