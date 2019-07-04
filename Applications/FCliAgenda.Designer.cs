namespace Applications
{
    partial class FCliAgenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCliAgenda));
            this.btnPesquisaCliente = new System.Windows.Forms.Button();
            this.mskCPFCliente = new System.Windows.Forms.MaskedTextBox();
            this.dgvcliente = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIDcliente = new System.Windows.Forms.TextBox();
            this.txtNomecliente = new System.Windows.Forms.TextBox();
            this.dgvCliAgenda = new System.Windows.Forms.DataGridView();
            this.btnAgenda = new System.Windows.Forms.Button();
            this.txtmes = new System.Windows.Forms.TextBox();
            this.txtano = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisaCliente
            // 
            this.btnPesquisaCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPesquisaCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisaCliente.Image")));
            this.btnPesquisaCliente.Location = new System.Drawing.Point(184, 25);
            this.btnPesquisaCliente.Name = "btnPesquisaCliente";
            this.btnPesquisaCliente.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisaCliente.TabIndex = 39;
            this.btnPesquisaCliente.Text = "Pesquisar";
            this.btnPesquisaCliente.UseVisualStyleBackColor = true;
            this.btnPesquisaCliente.Click += new System.EventHandler(this.BtnPesquisaCliente_Click);
            // 
            // mskCPFCliente
            // 
            this.mskCPFCliente.Location = new System.Drawing.Point(74, 25);
            this.mskCPFCliente.Mask = "000.000.000-00";
            this.mskCPFCliente.Name = "mskCPFCliente";
            this.mskCPFCliente.Size = new System.Drawing.Size(83, 20);
            this.mskCPFCliente.TabIndex = 38;
            this.mskCPFCliente.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MskCPFCliente_MaskInputRejected);
            // 
            // dgvcliente
            // 
            this.dgvcliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcliente.Location = new System.Drawing.Point(295, 10);
            this.dgvcliente.Name = "dgvcliente";
            this.dgvcliente.Size = new System.Drawing.Size(485, 81);
            this.dgvcliente.TabIndex = 37;
            this.dgvcliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgvcliente_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(3, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "CPF Cliente:";
            this.label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.Location = new System.Drawing.Point(231, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "ID";
            this.label10.Click += new System.EventHandler(this.Label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.Location = new System.Drawing.Point(30, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Nome:";
            this.label9.Click += new System.EventHandler(this.Label9_Click);
            // 
            // txtIDcliente
            // 
            this.txtIDcliente.Location = new System.Drawing.Point(255, 97);
            this.txtIDcliente.Name = "txtIDcliente";
            this.txtIDcliente.ReadOnly = true;
            this.txtIDcliente.Size = new System.Drawing.Size(100, 20);
            this.txtIDcliente.TabIndex = 41;
            this.txtIDcliente.TextChanged += new System.EventHandler(this.TxtIDcliente_TextChanged);
            // 
            // txtNomecliente
            // 
            this.txtNomecliente.Location = new System.Drawing.Point(74, 94);
            this.txtNomecliente.Name = "txtNomecliente";
            this.txtNomecliente.ReadOnly = true;
            this.txtNomecliente.Size = new System.Drawing.Size(100, 20);
            this.txtNomecliente.TabIndex = 40;
            this.txtNomecliente.TextChanged += new System.EventHandler(this.TxtNomecliente_TextChanged);
            // 
            // dgvCliAgenda
            // 
            this.dgvCliAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliAgenda.Location = new System.Drawing.Point(62, 184);
            this.dgvCliAgenda.Name = "dgvCliAgenda";
            this.dgvCliAgenda.Size = new System.Drawing.Size(718, 259);
            this.dgvCliAgenda.TabIndex = 44;
            this.dgvCliAgenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCliAgenda_CellContentClick);
            // 
            // btnAgenda
            // 
            this.btnAgenda.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgenda.Image = ((System.Drawing.Image)(resources.GetObject("btnAgenda.Image")));
            this.btnAgenda.Location = new System.Drawing.Point(428, 150);
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Size = new System.Drawing.Size(75, 23);
            this.btnAgenda.TabIndex = 45;
            this.btnAgenda.Text = "Agenda";
            this.btnAgenda.UseVisualStyleBackColor = true;
            this.btnAgenda.Click += new System.EventHandler(this.BtnAgenda_Click);
            // 
            // txtmes
            // 
            this.txtmes.Location = new System.Drawing.Point(74, 157);
            this.txtmes.Name = "txtmes";
            this.txtmes.Size = new System.Drawing.Size(100, 20);
            this.txtmes.TabIndex = 46;
            this.txtmes.TextChanged += new System.EventHandler(this.Txtmes_TextChanged);
            // 
            // txtano
            // 
            this.txtano.Location = new System.Drawing.Point(255, 152);
            this.txtano.Name = "txtano";
            this.txtano.Size = new System.Drawing.Size(100, 20);
            this.txtano.TabIndex = 47;
            this.txtano.TextChanged += new System.EventHandler(this.Txtano_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(38, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Mes:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(220, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Ano:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // FCliAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtano);
            this.Controls.Add(this.txtmes);
            this.Controls.Add(this.btnAgenda);
            this.Controls.Add(this.dgvCliAgenda);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtIDcliente);
            this.Controls.Add(this.txtNomecliente);
            this.Controls.Add(this.btnPesquisaCliente);
            this.Controls.Add(this.mskCPFCliente);
            this.Controls.Add(this.dgvcliente);
            this.Controls.Add(this.label8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FCliAgenda";
            this.Text = "FCliAgenda";
            this.Load += new System.EventHandler(this.FCliAgenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliAgenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisaCliente;
        private System.Windows.Forms.MaskedTextBox mskCPFCliente;
        private System.Windows.Forms.DataGridView dgvcliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIDcliente;
        private System.Windows.Forms.TextBox txtNomecliente;
        private System.Windows.Forms.DataGridView dgvCliAgenda;
        private System.Windows.Forms.Button btnAgenda;
        private System.Windows.Forms.TextBox txtmes;
        private System.Windows.Forms.TextBox txtano;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}