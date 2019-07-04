namespace Applications
{
    partial class FContaCli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FContaCli));
            this.btnPesquisaCliente = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIDcliente = new System.Windows.Forms.TextBox();
            this.txtNomecliente = new System.Windows.Forms.TextBox();
            this.mskCPFCliente = new System.Windows.Forms.MaskedTextBox();
            this.dgvcliente = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvConta = new System.Windows.Forms.DataGridView();
            this.bntConta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdConta = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.bntPagar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAnimalid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMedicoid = new System.Windows.Forms.TextBox();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.la = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisaCliente
            // 
            this.btnPesquisaCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPesquisaCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisaCliente.Image")));
            this.btnPesquisaCliente.Location = new System.Drawing.Point(200, 8);
            this.btnPesquisaCliente.Name = "btnPesquisaCliente";
            this.btnPesquisaCliente.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisaCliente.TabIndex = 35;
            this.btnPesquisaCliente.Text = "Pesquisar";
            this.btnPesquisaCliente.UseVisualStyleBackColor = true;
            this.btnPesquisaCliente.Click += new System.EventHandler(this.BtnPesquisaCliente_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.Location = new System.Drawing.Point(197, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "ID";
            this.label10.Click += new System.EventHandler(this.Label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.Location = new System.Drawing.Point(21, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Nome:";
            this.label9.Click += new System.EventHandler(this.Label9_Click);
            // 
            // txtIDcliente
            // 
            this.txtIDcliente.Location = new System.Drawing.Point(217, 51);
            this.txtIDcliente.Name = "txtIDcliente";
            this.txtIDcliente.ReadOnly = true;
            this.txtIDcliente.Size = new System.Drawing.Size(58, 20);
            this.txtIDcliente.TabIndex = 32;
            this.txtIDcliente.TextChanged += new System.EventHandler(this.TxtIDfuncionario_TextChanged);
            // 
            // txtNomecliente
            // 
            this.txtNomecliente.Location = new System.Drawing.Point(77, 50);
            this.txtNomecliente.Name = "txtNomecliente";
            this.txtNomecliente.ReadOnly = true;
            this.txtNomecliente.Size = new System.Drawing.Size(100, 20);
            this.txtNomecliente.TabIndex = 31;
            this.txtNomecliente.TextChanged += new System.EventHandler(this.TxtNomefuncionario_TextChanged);
            // 
            // mskCPFCliente
            // 
            this.mskCPFCliente.Location = new System.Drawing.Point(77, 10);
            this.mskCPFCliente.Mask = "000.000.000-00";
            this.mskCPFCliente.Name = "mskCPFCliente";
            this.mskCPFCliente.Size = new System.Drawing.Size(91, 20);
            this.mskCPFCliente.TabIndex = 30;
            this.mskCPFCliente.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MskCPFFuncionario_MaskInputRejected);
            // 
            // dgvcliente
            // 
            this.dgvcliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcliente.Location = new System.Drawing.Point(303, 8);
            this.dgvcliente.Name = "dgvcliente";
            this.dgvcliente.Size = new System.Drawing.Size(485, 79);
            this.dgvcliente.TabIndex = 29;
            this.dgvcliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgvcliente_CellContentClick_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(13, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "CPF Cliente:";
            this.label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // dgvConta
            // 
            this.dgvConta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConta.Location = new System.Drawing.Point(39, 154);
            this.dgvConta.Name = "dgvConta";
            this.dgvConta.Size = new System.Drawing.Size(705, 150);
            this.dgvConta.TabIndex = 36;
            this.dgvConta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvConta_CellContentClick);
            // 
            // bntConta
            // 
            this.bntConta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bntConta.Image = ((System.Drawing.Image)(resources.GetObject("bntConta.Image")));
            this.bntConta.Location = new System.Drawing.Point(268, 125);
            this.bntConta.Name = "bntConta";
            this.bntConta.Size = new System.Drawing.Size(75, 23);
            this.bntConta.TabIndex = 37;
            this.bntConta.Text = "Conta";
            this.bntConta.UseVisualStyleBackColor = true;
            this.bntConta.Click += new System.EventHandler(this.BntConta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(197, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "IDConta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(35, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Preco:";
            // 
            // txtIdConta
            // 
            this.txtIdConta.Location = new System.Drawing.Point(288, 324);
            this.txtIdConta.Name = "txtIdConta";
            this.txtIdConta.ReadOnly = true;
            this.txtIdConta.Size = new System.Drawing.Size(29, 20);
            this.txtIdConta.TabIndex = 39;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(98, 327);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.ReadOnly = true;
            this.txtPreco.Size = new System.Drawing.Size(42, 20);
            this.txtPreco.TabIndex = 38;
            // 
            // bntPagar
            // 
            this.bntPagar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bntPagar.Image = ((System.Drawing.Image)(resources.GetObject("bntPagar.Image")));
            this.bntPagar.Location = new System.Drawing.Point(312, 401);
            this.bntPagar.Name = "bntPagar";
            this.bntPagar.Size = new System.Drawing.Size(75, 23);
            this.bntPagar.TabIndex = 42;
            this.bntPagar.Text = "Pagar";
            this.bntPagar.UseVisualStyleBackColor = true;
            this.bntPagar.Click += new System.EventHandler(this.BntPagar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(379, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "IDAnimal:";
            // 
            // txtAnimalid
            // 
            this.txtAnimalid.Location = new System.Drawing.Point(475, 327);
            this.txtAnimalid.Name = "txtAnimalid";
            this.txtAnimalid.ReadOnly = true;
            this.txtAnimalid.Size = new System.Drawing.Size(30, 20);
            this.txtAnimalid.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(552, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "IDMedico";
            // 
            // txtMedicoid
            // 
            this.txtMedicoid.Location = new System.Drawing.Point(648, 320);
            this.txtMedicoid.Name = "txtMedicoid";
            this.txtMedicoid.ReadOnly = true;
            this.txtMedicoid.Size = new System.Drawing.Size(30, 20);
            this.txtMedicoid.TabIndex = 45;
            // 
            // txtConta
            // 
            this.txtConta.Location = new System.Drawing.Point(98, 408);
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(79, 20);
            this.txtConta.TabIndex = 48;
            // 
            // la
            // 
            this.la.AutoSize = true;
            this.la.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.la.Image = ((System.Drawing.Image)(resources.GetObject("la.Image")));
            this.la.Location = new System.Drawing.Point(40, 411);
            this.la.Name = "la";
            this.la.Size = new System.Drawing.Size(38, 13);
            this.la.TabIndex = 49;
            this.la.Text = "Conta:";
            // 
            // FContaCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.la);
            this.Controls.Add(this.txtConta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMedicoid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAnimalid);
            this.Controls.Add(this.bntPagar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdConta);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.bntConta);
            this.Controls.Add(this.dgvConta);
            this.Controls.Add(this.btnPesquisaCliente);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtIDcliente);
            this.Controls.Add(this.txtNomecliente);
            this.Controls.Add(this.mskCPFCliente);
            this.Controls.Add(this.dgvcliente);
            this.Controls.Add(this.label8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FContaCli";
            this.Text = "FContaCli";
            this.Load += new System.EventHandler(this.FContaCli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisaCliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIDcliente;
        private System.Windows.Forms.TextBox txtNomecliente;
        private System.Windows.Forms.MaskedTextBox mskCPFCliente;
        private System.Windows.Forms.DataGridView dgvcliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvConta;
        private System.Windows.Forms.Button bntConta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdConta;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Button bntPagar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAnimalid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMedicoid;
        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.Label la;
    }
}