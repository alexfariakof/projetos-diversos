namespace ProdutoMarca.Apresentacao
{
    partial class FrmPrincipal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdateMarca = new System.Windows.Forms.Button();
            this.btnNewMarca = new System.Windows.Forms.Button();
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.IdMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpdateProduto = new System.Windows.Forms.Button();
            this.btnNewProduto = new System.Windows.Forms.Button();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNomeMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clidMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteMarca = new System.Windows.Forms.Button();
            this.btnDeleteProduto = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteMarca);
            this.groupBox1.Controls.Add(this.btnUpdateMarca);
            this.groupBox1.Controls.Add(this.btnNewMarca);
            this.groupBox1.Controls.Add(this.dgvMarcas);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marcas Cadastradas";
            // 
            // btnUpdateMarca
            // 
            this.btnUpdateMarca.Location = new System.Drawing.Point(560, 53);
            this.btnUpdateMarca.Name = "btnUpdateMarca";
            this.btnUpdateMarca.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateMarca.TabIndex = 2;
            this.btnUpdateMarca.Text = "Alterar";
            this.btnUpdateMarca.UseVisualStyleBackColor = true;
            this.btnUpdateMarca.Click += new System.EventHandler(this.btnUpdateMarca_Click);
            // 
            // btnNewMarca
            // 
            this.btnNewMarca.Location = new System.Drawing.Point(560, 23);
            this.btnNewMarca.Name = "btnNewMarca";
            this.btnNewMarca.Size = new System.Drawing.Size(75, 23);
            this.btnNewMarca.TabIndex = 1;
            this.btnNewMarca.Text = "Novo";
            this.btnNewMarca.UseVisualStyleBackColor = true;
            this.btnNewMarca.Click += new System.EventHandler(this.btnNewMarca_Click);
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.AllowUserToAddRows = false;
            this.dgvMarcas.AllowUserToDeleteRows = false;
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMarca,
            this.NomeMarca});
            this.dgvMarcas.Location = new System.Drawing.Point(6, 22);
            this.dgvMarcas.MultiSelect = false;
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.ReadOnly = true;
            this.dgvMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarcas.Size = new System.Drawing.Size(547, 136);
            this.dgvMarcas.TabIndex = 0;
            // 
            // IdMarca
            // 
            this.IdMarca.DataPropertyName = "Id";
            this.IdMarca.HeaderText = "Id";
            this.IdMarca.Name = "IdMarca";
            this.IdMarca.ReadOnly = true;
            this.IdMarca.Visible = false;
            // 
            // NomeMarca
            // 
            this.NomeMarca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NomeMarca.DataPropertyName = "Nome";
            this.NomeMarca.HeaderText = "Nome";
            this.NomeMarca.Name = "NomeMarca";
            this.NomeMarca.ReadOnly = true;
            this.NomeMarca.Width = 500;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeleteProduto);
            this.groupBox2.Controls.Add(this.btnUpdateProduto);
            this.groupBox2.Controls.Add(this.btnNewProduto);
            this.groupBox2.Controls.Add(this.dgvProduto);
            this.groupBox2.Location = new System.Drawing.Point(3, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(646, 182);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produtos Cadastrados";
            // 
            // btnUpdateProduto
            // 
            this.btnUpdateProduto.Location = new System.Drawing.Point(560, 53);
            this.btnUpdateProduto.Name = "btnUpdateProduto";
            this.btnUpdateProduto.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateProduto.TabIndex = 2;
            this.btnUpdateProduto.Text = "Alterar";
            this.btnUpdateProduto.UseVisualStyleBackColor = true;
            this.btnUpdateProduto.Click += new System.EventHandler(this.btnUpdateProduto_Click);
            // 
            // btnNewProduto
            // 
            this.btnNewProduto.Location = new System.Drawing.Point(560, 23);
            this.btnNewProduto.Name = "btnNewProduto";
            this.btnNewProduto.Size = new System.Drawing.Size(75, 23);
            this.btnNewProduto.TabIndex = 1;
            this.btnNewProduto.Text = "Novo";
            this.btnNewProduto.UseVisualStyleBackColor = true;
            this.btnNewProduto.Click += new System.EventHandler(this.btnNewProduto_Click);
            // 
            // dgvProduto
            // 
            this.dgvProduto.AllowUserToAddRows = false;
            this.dgvProduto.AllowUserToDeleteRows = false;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nome,
            this.clNomeMarca,
            this.clidMarca});
            this.dgvProduto.Location = new System.Drawing.Point(9, 22);
            this.dgvProduto.MultiSelect = false;
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.ReadOnly = true;
            this.dgvProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduto.Size = new System.Drawing.Size(544, 150);
            this.dgvProduto.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome do Produto";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 250;
            // 
            // clNomeMarca
            // 
            this.clNomeMarca.DataPropertyName = "NomeMarca";
            this.clNomeMarca.HeaderText = "Nome da Marca";
            this.clNomeMarca.Name = "clNomeMarca";
            this.clNomeMarca.ReadOnly = true;
            this.clNomeMarca.Width = 250;
            // 
            // clidMarca
            // 
            this.clidMarca.HeaderText = "Id da Marca";
            this.clidMarca.Name = "clidMarca";
            this.clidMarca.ReadOnly = true;
            this.clidMarca.Visible = false;
            // 
            // btnDeleteMarca
            // 
            this.btnDeleteMarca.Location = new System.Drawing.Point(560, 83);
            this.btnDeleteMarca.Name = "btnDeleteMarca";
            this.btnDeleteMarca.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteMarca.TabIndex = 3;
            this.btnDeleteMarca.Text = "Excluir";
            this.btnDeleteMarca.UseVisualStyleBackColor = true;
            this.btnDeleteMarca.Click += new System.EventHandler(this.btnDeleteMarca_Click);
            // 
            // btnDeleteProduto
            // 
            this.btnDeleteProduto.Location = new System.Drawing.Point(560, 84);
            this.btnDeleteProduto.Name = "btnDeleteProduto";
            this.btnDeleteProduto.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteProduto.TabIndex = 3;
            this.btnDeleteProduto.Text = "Excluir";
            this.btnDeleteProduto.UseVisualStyleBackColor = true;
            this.btnDeleteProduto.Click += new System.EventHandler(this.btnDeleteProduto_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 367);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos e Marcas";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeMarca;
        private System.Windows.Forms.Button btnNewMarca;
        private System.Windows.Forms.Button btnNewProduto;
        private System.Windows.Forms.Button btnUpdateMarca;
        private System.Windows.Forms.Button btnUpdateProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNomeMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn clidMarca;
        private System.Windows.Forms.Button btnDeleteMarca;
        private System.Windows.Forms.Button btnDeleteProduto;
    }
}