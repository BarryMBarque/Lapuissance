namespace Applications
{
    partial class FConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FConsulta));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.dtpConsulta = new System.Windows.Forms.DateTimePicker();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dgvMedicoConsulta = new System.Windows.Forms.DataGridView();
            this.txtMedicoCon = new System.Windows.Forms.TextBox();
            this.btnMedico = new System.Windows.Forms.Button();
            this.txtIdMedico = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAtender = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdconsulta = new System.Windows.Forms.TextBox();
            this.txtProrietarios = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicoConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(35, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(35, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(35, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Medico:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(35, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Preço:";
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
            this.cbxTipo.Location = new System.Drawing.Point(92, 26);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(121, 21);
            this.cbxTipo.TabIndex = 4;
            this.cbxTipo.SelectedIndexChanged += new System.EventHandler(this.CbxTipo_SelectedIndexChanged);
            // 
            // dtpConsulta
            // 
            this.dtpConsulta.Location = new System.Drawing.Point(92, 65);
            this.dtpConsulta.Name = "dtpConsulta";
            this.dtpConsulta.Size = new System.Drawing.Size(200, 20);
            this.dtpConsulta.TabIndex = 5;
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Location = new System.Drawing.Point(18, 238);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.Size = new System.Drawing.Size(731, 207);
            this.dgvConsulta.TabIndex = 8;
            this.dgvConsulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvConsulta_CellContentClick);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.Location = new System.Drawing.Point(92, 209);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 9;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // dgvMedicoConsulta
            // 
            this.dgvMedicoConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicoConsulta.Location = new System.Drawing.Point(432, 20);
            this.dgvMedicoConsulta.Name = "dgvMedicoConsulta";
            this.dgvMedicoConsulta.Size = new System.Drawing.Size(316, 218);
            this.dgvMedicoConsulta.TabIndex = 10;
            this.dgvMedicoConsulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMedicoConsulta_CellContentClick);
            // 
            // txtMedicoCon
            // 
            this.txtMedicoCon.Location = new System.Drawing.Point(92, 114);
            this.txtMedicoCon.Name = "txtMedicoCon";
            this.txtMedicoCon.ReadOnly = true;
            this.txtMedicoCon.Size = new System.Drawing.Size(100, 20);
            this.txtMedicoCon.TabIndex = 11;
            // 
            // btnMedico
            // 
            this.btnMedico.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMedico.Image = ((System.Drawing.Image)(resources.GetObject("btnMedico.Image")));
            this.btnMedico.Location = new System.Drawing.Point(265, 26);
            this.btnMedico.Name = "btnMedico";
            this.btnMedico.Size = new System.Drawing.Size(75, 23);
            this.btnMedico.TabIndex = 12;
            this.btnMedico.Text = "Medicos";
            this.btnMedico.UseVisualStyleBackColor = true;
            this.btnMedico.Click += new System.EventHandler(this.BtnMedico_Click);
            // 
            // txtIdMedico
            // 
            this.txtIdMedico.Location = new System.Drawing.Point(240, 114);
            this.txtIdMedico.Name = "txtIdMedico";
            this.txtIdMedico.ReadOnly = true;
            this.txtIdMedico.Size = new System.Drawing.Size(100, 20);
            this.txtIdMedico.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(198, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "ID:";
            // 
            // btnAtender
            // 
            this.btnAtender.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAtender.Image = ((System.Drawing.Image)(resources.GetObject("btnAtender.Image")));
            this.btnAtender.Location = new System.Drawing.Point(255, 475);
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(75, 23);
            this.btnAtender.TabIndex = 15;
            this.btnAtender.Text = "Atender";
            this.btnAtender.UseVisualStyleBackColor = true;
            this.btnAtender.Click += new System.EventHandler(this.BtnAtender_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(15, 459);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "IdConsulta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(15, 491);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Proprietario:";
            // 
            // txtIdconsulta
            // 
            this.txtIdconsulta.Location = new System.Drawing.Point(92, 456);
            this.txtIdconsulta.Name = "txtIdconsulta";
            this.txtIdconsulta.ReadOnly = true;
            this.txtIdconsulta.Size = new System.Drawing.Size(100, 20);
            this.txtIdconsulta.TabIndex = 18;
            // 
            // txtProrietarios
            // 
            this.txtProrietarios.Location = new System.Drawing.Point(92, 488);
            this.txtProrietarios.Name = "txtProrietarios";
            this.txtProrietarios.ReadOnly = true;
            this.txtProrietarios.Size = new System.Drawing.Size(100, 20);
            this.txtProrietarios.TabIndex = 19;
            this.txtProrietarios.TextChanged += new System.EventHandler(this.TxtProrietarios_TextChanged);
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(92, 156);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 20;
            // 
            // FConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtProrietarios);
            this.Controls.Add(this.txtIdconsulta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAtender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIdMedico);
            this.Controls.Add(this.btnMedico);
            this.Controls.Add(this.txtMedicoCon);
            this.Controls.Add(this.dgvMedicoConsulta);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.dtpConsulta);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FConsulta";
            this.Text = "FConsulta";
            this.Load += new System.EventHandler(this.FConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicoConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.DateTimePicker dtpConsulta;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView dgvMedicoConsulta;
        private System.Windows.Forms.TextBox txtMedicoCon;
        private System.Windows.Forms.Button btnMedico;
        private System.Windows.Forms.TextBox txtIdMedico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAtender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdconsulta;
        private System.Windows.Forms.TextBox txtProrietarios;
        private System.Windows.Forms.TextBox txtPreco;
    }
}