namespace Applications
{
    partial class FAniProntuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAniProntuario));
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.mskdtxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.bntBuscar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIDcliente = new System.Windows.Forms.TextBox();
            this.txtNomecliente = new System.Windows.Forms.TextBox();
            this.dgvAnimais = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDAnimal = new System.Windows.Forms.TextBox();
            this.txtNomeAnimal = new System.Windows.Forms.TextBox();
            this.bntProntuario = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimais)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCliente
            // 
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(311, 6);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(485, 65);
            this.dgvCliente.TabIndex = 0;
            this.dgvCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCliente_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CPFCliente:";
            // 
            // mskdtxtCPF
            // 
            this.mskdtxtCPF.Location = new System.Drawing.Point(98, 20);
            this.mskdtxtCPF.Mask = "000.000.000-00";
            this.mskdtxtCPF.Name = "mskdtxtCPF";
            this.mskdtxtCPF.Size = new System.Drawing.Size(93, 20);
            this.mskdtxtCPF.TabIndex = 10;
            // 
            // bntBuscar
            // 
            this.bntBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bntBuscar.Image = ((System.Drawing.Image)(resources.GetObject("bntBuscar.Image")));
            this.bntBuscar.Location = new System.Drawing.Point(385, 143);
            this.bntBuscar.Name = "bntBuscar";
            this.bntBuscar.Size = new System.Drawing.Size(75, 23);
            this.bntBuscar.TabIndex = 42;
            this.bntBuscar.Text = "Buscar";
            this.bntBuscar.UseVisualStyleBackColor = true;
            this.bntBuscar.Click += new System.EventHandler(this.BntBuscar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.Location = new System.Drawing.Point(257, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.Location = new System.Drawing.Point(38, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Nome:";
            // 
            // txtIDcliente
            // 
            this.txtIDcliente.Location = new System.Drawing.Point(301, 93);
            this.txtIDcliente.Name = "txtIDcliente";
            this.txtIDcliente.ReadOnly = true;
            this.txtIDcliente.Size = new System.Drawing.Size(100, 20);
            this.txtIDcliente.TabIndex = 39;
            // 
            // txtNomecliente
            // 
            this.txtNomecliente.Location = new System.Drawing.Point(115, 93);
            this.txtNomecliente.Name = "txtNomecliente";
            this.txtNomecliente.ReadOnly = true;
            this.txtNomecliente.Size = new System.Drawing.Size(100, 20);
            this.txtNomecliente.TabIndex = 38;
            // 
            // dgvAnimais
            // 
            this.dgvAnimais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimais.Location = new System.Drawing.Point(12, 175);
            this.dgvAnimais.Name = "dgvAnimais";
            this.dgvAnimais.Size = new System.Drawing.Size(757, 205);
            this.dgvAnimais.TabIndex = 43;
            this.dgvAnimais.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAnimais_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(273, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(54, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Nome:";
            // 
            // txtIDAnimal
            // 
            this.txtIDAnimal.Location = new System.Drawing.Point(364, 386);
            this.txtIDAnimal.Name = "txtIDAnimal";
            this.txtIDAnimal.ReadOnly = true;
            this.txtIDAnimal.Size = new System.Drawing.Size(100, 20);
            this.txtIDAnimal.TabIndex = 45;
            // 
            // txtNomeAnimal
            // 
            this.txtNomeAnimal.Location = new System.Drawing.Point(131, 386);
            this.txtNomeAnimal.Name = "txtNomeAnimal";
            this.txtNomeAnimal.ReadOnly = true;
            this.txtNomeAnimal.Size = new System.Drawing.Size(100, 20);
            this.txtNomeAnimal.TabIndex = 44;
            // 
            // bntProntuario
            // 
            this.bntProntuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bntProntuario.Image = ((System.Drawing.Image)(resources.GetObject("bntProntuario.Image")));
            this.bntProntuario.Location = new System.Drawing.Point(542, 386);
            this.bntProntuario.Name = "bntProntuario";
            this.bntProntuario.Size = new System.Drawing.Size(75, 23);
            this.bntProntuario.TabIndex = 48;
            this.bntProntuario.Text = "Prontuario";
            this.bntProntuario.UseVisualStyleBackColor = true;
            this.bntProntuario.Click += new System.EventHandler(this.BntProntuario_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCliente.Image")));
            this.btnBuscarCliente.Location = new System.Drawing.Point(216, 23);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCliente.TabIndex = 49;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.BtnBuscarCliente_Click);
            // 
            // FAniProntuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.bntProntuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIDAnimal);
            this.Controls.Add(this.txtNomeAnimal);
            this.Controls.Add(this.dgvAnimais);
            this.Controls.Add(this.bntBuscar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtIDcliente);
            this.Controls.Add(this.txtNomecliente);
            this.Controls.Add(this.mskdtxtCPF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FAniProntuario";
            this.Text = "FAniProntuario";
            this.Load += new System.EventHandler(this.FAniProntuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskdtxtCPF;
        private System.Windows.Forms.Button bntBuscar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIDcliente;
        private System.Windows.Forms.TextBox txtNomecliente;
        private System.Windows.Forms.DataGridView dgvAnimais;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDAnimal;
        private System.Windows.Forms.TextBox txtNomeAnimal;
        private System.Windows.Forms.Button bntProntuario;
        private System.Windows.Forms.Button btnBuscarCliente;
    }
}