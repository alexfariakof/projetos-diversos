namespace Events
{
    partial class frmLatidos
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
            this.btnLatido = new System.Windows.Forms.Button();
            this.pgBlatido = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnLatido
            // 
            this.btnLatido.Location = new System.Drawing.Point(13, 29);
            this.btnLatido.Name = "btnLatido";
            this.btnLatido.Size = new System.Drawing.Size(75, 23);
            this.btnLatido.TabIndex = 0;
            this.btnLatido.Text = "Latir";
            this.btnLatido.UseVisualStyleBackColor = true;
            this.btnLatido.Click += new System.EventHandler(this.btnLatido_Click);
            // 
            // pgBlatido
            // 
            this.pgBlatido.Location = new System.Drawing.Point(13, 75);
            this.pgBlatido.Maximum = 400;
            this.pgBlatido.Name = "pgBlatido";
            this.pgBlatido.Size = new System.Drawing.Size(302, 23);
            this.pgBlatido.TabIndex = 1;
            // 
            // frmLatidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 121);
            this.Controls.Add(this.pgBlatido);
            this.Controls.Add(this.btnLatido);
            this.Name = "frmLatidos";
            this.Text = "Gerenciador de Latidos de Cachorro";
            this.Load += new System.EventHandler(this.frmLatidos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLatido;
        private System.Windows.Forms.ProgressBar pgBlatido;
    }
}

