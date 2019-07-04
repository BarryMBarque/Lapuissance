namespace Applications
{
    partial class FTratamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FTratamento));
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdMedico = new System.Windows.Forms.TextBox();
            this.btnMedico = new System.Windows.Forms.Button();
            this.txtMedicoCon = new System.Windows.Forms.TextBox();
            this.dgvMedicoTratamento = new System.Windows.Forms.DataGridView();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dgvTratamentos = new System.Windows.Forms.DataGridView();
            this.dtpConsulta = new System.Windows.Forms.DateTimePicker();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicoTratamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTratamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(215, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "ID:";
            // 
            // txtIdMedico
            // 
            this.txtIdMedico.Location = new System.Drawing.Point(257, 107);
            this.txtIdMedico.Name = "txtIdMedico";
            this.txtIdMedico.ReadOnly = true;
            this.txtIdMedico.Size = new System.Drawing.Size(100, 20);
            this.txtIdMedico.TabIndex = 27;
            // 
            // btnMedico
            // 
            this.btnMedico.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMedico.Image = ((System.Drawing.Image)(resources.GetObject("btnMedico.Image")));
            this.btnMedico.Location = new System.Drawing.Point(282, 19);
            this.btnMedico.Name = "btnMedico";
            this.btnMedico.Size = new System.Drawing.Size(75, 23);
            this.btnMedico.TabIndex = 26;
            this.btnMedico.Text = "Medicos";
            this.btnMedico.UseVisualStyleBackColor = true;
            this.btnMedico.Click += new System.EventHandler(this.BtnMedico_Click);
            // 
            // txtMedicoCon
            // 
            this.txtMedicoCon.Location = new System.Drawing.Point(109, 107);
            this.txtMedicoCon.Name = "txtMedicoCon";
            this.txtMedicoCon.ReadOnly = true;
            this.txtMedicoCon.Size = new System.Drawing.Size(100, 20);
            this.txtMedicoCon.TabIndex = 25;
            // 
            // dgvMedicoTratamento
            // 
            this.dgvMedicoTratamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicoTratamento.Location = new System.Drawing.Point(449, 13);
            this.dgvMedicoTratamento.Name = "dgvMedicoTratamento";
            this.dgvMedicoTratamento.Size = new System.Drawing.Size(316, 218);
            this.dgvMedicoTratamento.TabIndex = 24;
            this.dgvMedicoTratamento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMedicoTratamento_CellContentClick);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.Location = new System.Drawing.Point(109, 202);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 23;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // dgvTratamentos
            // 
            this.dgvTratamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTratamentos.Location = new System.Drawing.Point(35, 231);
            this.dgvTratamentos.Name = "dgvTratamentos";
            this.dgvTratamentos.Size = new System.Drawing.Size(731, 207);
            this.dgvTratamentos.TabIndex = 22;
            // 
            // dtpConsulta
            // 
            this.dtpConsulta.Location = new System.Drawing.Point(109, 58);
            this.dtpConsulta.Name = "dtpConsulta";
            this.dtpConsulta.Size = new System.Drawing.Size(200, 20);
            this.dtpConsulta.TabIndex = 20;
            // 
            // cbxTipo
            // 
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "Acupontura",
            "Anestesiologia",
            "cardiologia",
            "dermatologia",
            "Endocrinologia",
            "Felinos ",
            "Fisioterapia",
            "Nefrologia e Urologia "});
            this.cbxTipo.Location = new System.Drawing.Point(109, 19);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(121, 21);
            this.cbxTipo.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(52, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Preço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(52, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Medico:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(52, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Data:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(52, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tipo:";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(109, 145);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 29;
            // 
            // FTratamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIdMedico);
            this.Controls.Add(this.btnMedico);
            this.Controls.Add(this.txtMedicoCon);
            this.Controls.Add(this.dgvMedicoTratamento);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dgvTratamentos);
            this.Controls.Add(this.dtpConsulta);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FTratamento";
            this.Text = "FTratamento";
            this.Load += new System.EventHandler(this.FTratamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicoTratamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTratamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdMedico;
        private System.Windows.Forms.Button btnMedico;
        private System.Windows.Forms.TextBox txtMedicoCon;
        private System.Windows.Forms.DataGridView dgvMedicoTratamento;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView dgvTratamentos;
        private System.Windows.Forms.DateTimePicker dtpConsulta;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPreco;
    }
}