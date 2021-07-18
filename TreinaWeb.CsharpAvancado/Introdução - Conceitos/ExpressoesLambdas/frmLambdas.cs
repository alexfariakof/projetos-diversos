using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Events;

namespace ExpressoesLambdas
{
    public partial class frmLambdas : Form
    {
        Func<String, String, String> concatenador;
        GerenciadorLatidos gerenciadorLatidos;

        public frmLambdas()
        {
            InitializeComponent();         
            concatenador = (s1, s2) => { return s1 + " " + s2; };

            gerenciadorLatidos = new GerenciadorLatidos();

            gerenciadorLatidos.ExcessoDecibeisEvent += (sender, args) =>
            {
                ExcessoDecibeisEventArgs eventArgrs = (ExcessoDecibeisEventArgs)args;
                MessageBox.Show("O Cachorro execedeu o limite em " + eventArgrs.IntensidadeLatido + " decibéis", "Excesso de decibéis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            };

            gerenciadorLatidos.ExcessoDecibeisAcimaNoventa += (sender, args) =>
            {
                ExcessoDecibeisEventArgs eventArgrs = (ExcessoDecibeisEventArgs)args;
                MessageBox.Show("O Cachorro execedeu o limite em " + eventArgrs.IntensidadeLatido + " decibéis e levou uma multa", "Excesso de decibéis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            };


        }

        private void btnConcatenar_Click(object sender, EventArgs e)
        {
            // Abaixo metodo de antigo de escrita para realização de concatenção 
            //  Func<String, String, String> concatenador = Concatenar; 

            // Utilizando lambdas Expressions
            txtResultado.Text = String.Empty;           
            txtResultado.Text = concatenador(txt1.Text , txt2.Text);
        }


 
        private void btnConcatenarInvetido_Click(object sender, EventArgs e)
        {
            txtResultado.Text = String.Empty;
            Action<string> escritor = s1 =>
            {
                txtResultado.Text = s1;
            };
            escritor(concatenador(txt2.Text, txt1.Text));

        }


        // Metodo Exemplo de forma Atinga de Escrita
        private string Concatenar(string str1, string str2)
        {

            return str1 + " " + str2;
        }

        private void btnLatir_Click(object sender, EventArgs e)
        {
            pgBIntensidadeLatido.Value = gerenciadorLatidos.Latir();
        }

        private void frmLambdas_Load(object sender, EventArgs e)
        {
            pgBIntensidadeLatido.Value = 0;
        }
    }
}
