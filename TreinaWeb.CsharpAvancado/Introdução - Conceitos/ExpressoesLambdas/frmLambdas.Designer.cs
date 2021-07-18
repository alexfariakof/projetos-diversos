namespace ExpressoesLambdas
{
    partial class frmLambdas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblText1 = new System.Windows.Forms.Label();
            this.lblText2 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.btnConcatenar = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnConcatenarInvetido = new System.Windows.Forms.Button();
            this.btnLatir = new System.Windows.Forms.Button();
            this.pgBIntensidadeLatido = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lblText1
            // 
            this.lblText1.AutoSize = true;
            this.lblText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText1.Location = new System.Drawing.Point(13, 24);
            this.lblText1.Name = "lblText1";
            this.lblText1.Size = new System.Drawing.Size(65, 20);
            this.lblText1.TabIndex = 0;
            this.lblText1.Text = "Texto 1 ";
            // 
            // lblText2
            // 
            this.lblText2.AutoSize = true;
            this.lblText2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText2.Location = new System.Drawing.Point(13, 62);
            this.lblText2.Name = "lblText2";
            this.lblText2.Size = new System.Drawing.Size(61, 20);
            this.lblText2.TabIndex = 1;
            this.lblText2.Text = "Texto 2";
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.Location = new System.Drawing.Point(101, 20);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(518, 24);
            this.txt1.TabIndex = 2;
            // 
            // txt2
            // 
            this.txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2.Location = new System.Drawing.Point(101, 60);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(518, 24);
            this.txt2.TabIndex = 3;
            // 
            // btnConcatenar
            // 
            this.btnConcatenar.Location = new System.Drawing.Point(101, 90);
            this.btnConcatenar.Name = "btnConcatenar";
            this.btnConcatenar.Size = new System.Drawing.Size(142, 47);
            this.btnConcatenar.TabIndex = 4;
            this.btnConcatenar.Text = "Concatenar";
            this.btnConcatenar.UseVisualStyleBackColor = true;
            this.btnConcatenar.Click += new System.EventHandler(this.btnConcatenar_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(101, 143);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(518, 24);
            this.txtResultado.TabIndex = 6;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(13, 145);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(82, 20);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resultado";
            // 
            // btnConcatenarInvetido
            // 
            this.btnConcatenarInvetido.Location = new System.Drawing.Point(249, 90);
            this.btnConcatenarInvetido.Name = "btnConcatenarInvetido";
            this.btnConcatenarInvetido.Size = new System.Drawing.Size(142, 47);
            this.btnConcatenarInvetido.TabIndex = 7;
            this.btnConcatenarInvetido.Text = "Concatenação Invertida";
            this.btnConcatenarInvetido.UseVisualStyleBackColor = true;
            this.btnConcatenarInvetido.Click += new System.EventHandler(this.btnConcatenarInvetido_Click);
            // 
            // btnLatir
            // 
            this.btnLatir.Location = new System.Drawing.Point(101, 192);
            this.btnLatir.Name = "btnLatir";
            this.btnLatir.Size = new System.Drawing.Size(142, 47);
            this.btnLatir.TabIndex = 8;
            this.btnLatir.Text = "Latir!";
            this.btnLatir.UseVisualStyleBackColor = true;
            this.btnLatir.Click += new System.EventHandler(this.btnLatir_Click);
            // 
            // pgBIntensidadeLatido
            // 
            this.pgBIntensidadeLatido.Location = new System.Drawing.Point(17, 263);
            this.pgBIntensidadeLatido.Maximum = 500;
            this.pgBIntensidadeLatido.Name = "pgBIntensidadeLatido";
            this.pgBIntensidadeLatido.Size = new System.Drawing.Size(602, 23);
            this.pgBIntensidadeLatido.TabIndex = 9;
            // 
            // frmLambdas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 312);
            this.Controls.Add(this.pgBIntensidadeLatido);
            this.Controls.Add(this.btnLatir);
            this.Controls.Add(this.btnConcatenarInvetido);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnConcatenar);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lblText2);
            this.Controls.Add(this.lblText1);
            this.Name = "frmLambdas";
            this.Text = "Estudo Sobre Lambdas Expressions";
            this.Load += new System.EventHandler(this.frmLambdas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText1;
        private System.Windows.Forms.Label lblText2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Button btnConcatenar;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnConcatenarInvetido;
        private System.Windows.Forms.Button btnLatir;
        private System.Windows.Forms.ProgressBar pgBIntensidadeLatido;
    }
}

