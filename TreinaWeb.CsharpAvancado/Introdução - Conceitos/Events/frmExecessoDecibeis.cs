using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events
{
    public partial class frmLatidos : Form
    {
        private GerenciadorLatidos gerenciadorLatidos;

        public frmLatidos()
        {
            InitializeComponent();
            gerenciadorLatidos = new GerenciadorLatidos();
            gerenciadorLatidos.ExcessoDecibeisEvent += QuandoExcederDecibeis;
            gerenciadorLatidos.ExcessoDecibeisAcimaNoventa += QuandoExcederDecibeisAcimaNoventa;
        }

        private void frmLatidos_Load(object sender, EventArgs e)
        {
            pgBlatido.Value = 0;
        }

        private void btnLatido_Click(object sender, EventArgs e)
        {
            pgBlatido.Value = gerenciadorLatidos.Latir();
        }

        private void QuandoExcederDecibeis(object sender, EventArgs e)
        {
            ExcessoDecibeisEventArgs eventArgrs = (ExcessoDecibeisEventArgs)e;
            MessageBox.Show("Cachorro execedeu o limites em " + eventArgrs.IntensidadeLatido + " decibéis", "Excesso de decibéis", MessageBoxButtons.OK , MessageBoxIcon.Warning);
        }

        private void QuandoExcederDecibeisAcimaNoventa(object sender, EventArgs e)
        {
            ExcessoDecibeisEventArgs eventArgrs = (ExcessoDecibeisEventArgs)e;
            MessageBox.Show("Cachorro execedeu o limite em " + eventArgrs.IntensidadeLatido + " decibéis e levou uma multa", "Excesso de decibéis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

    }
}
