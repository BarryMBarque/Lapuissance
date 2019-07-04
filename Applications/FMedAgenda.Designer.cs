namespace Applications
{
    partial class FMedAgenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMedAgenda));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtano = new System.Windows.Forms.TextBox();
            this.txtmes = new System.Windows.Forms.TextBox();
            this.btnAgenda = new System.Windows.Forms.Button();
            this.dgvMedAgenda = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIDmedico = new System.Windows.Forms.TextBox();
            this.txtNomemedico = new System.Windows.Forms.TextBox();
            this.btnPesquisaMedico = new System.Windows.Forms.Button();
            this.mskCPFCliente = new System.Windows.Forms.MaskedTextBox();
            this.dgvMedico = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedAgenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedico)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(147, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Ano:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Mes:";
            // 
            // txtano
            // 
            this.txtano.Location = new System.Drawing.Point(182, 149);
            this.txtano.Name = "txtano";
            this.txtano.Size = new System.Drawing.Size(54, 20);
            this.txtano.TabIndex = 61;
            // 
            // txtmes
            // 
            this.txtmes.Location = new System.Drawing.Point(57, 149);
            this.txtmes.Name = "txtmes";
            this.txtmes.Size = new System.Drawing.Size(35, 20);
            this.txtmes.TabIndex = 60;
            // 
            // btnAgenda
            // 
            this.btnAgenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAgenda.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgenda.Location = new System.Drawing.Point(290, 146);
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Size = new System.Drawing.Size(75, 23);
            this.btnAgenda.TabIndex = 59;
            this.btnAgenda.Text = "Agenda";
            this.btnAgenda.UseVisualStyleBackColor = false;
            this.btnAgenda.Click += new System.EventHandler(this.BtnAgenda_Click);
            // 
            // dgvMedAgenda
            // 
            this.dgvMedAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedAgenda.Location = new System.Drawing.Point(4, 176);
            this.dgvMedAgenda.Name = "dgvMedAgenda";
            this.dgvMedAgenda.Size = new System.Drawing.Size(718, 259);
            this.dgvMedAgenda.TabIndex = 58;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(218, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 57;
            this.label10.Text = "ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(12, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 56;
            this.label9.Text = "Nome:";
            // 
            // txtIDmedico
            // 
            this.txtIDmedico.Location = new System.Drawing.Point(242, 89);
            this.txtIDmedico.Name = "txtIDmedico";
            this.txtIDmedico.ReadOnly = true;
            this.txtIDmedico.Size = new System.Drawing.Size(53, 20);
            this.txtIDmedico.TabIndex = 55;
            // 
            // txtNomemedico
            // 
            this.txtNomemedico.Location = new System.Drawing.Point(76, 86);
            this.txtNomemedico.Name = "txtNomemedico";
            this.txtNomemedico.ReadOnly = true;
            this.txtNomemedico.Size = new System.Drawing.Size(79, 20);
            this.txtNomemedico.TabIndex = 54;
            // 
            // btnPesquisaMedico
            // 
            this.btnPesquisaMedico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnPesquisaMedico.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPesquisaMedico.Location = new System.Drawing.Point(220, 15);
            this.btnPesquisaMedico.Name = "btnPesquisaMedico";
            this.btnPesquisaMedico.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisaMedico.TabIndex = 53;
            this.btnPesquisaMedico.Text = "Pesquisar";
            this.btnPesquisaMedico.UseVisualStyleBackColor = false;
            this.btnPesquisaMedico.Click += new System.EventHandler(this.BtnPesquisaMedico_Click);
            // 
            // mskCPFCliente
            // 
            this.mskCPFCliente.Location = new System.Drawing.Point(97, 17);
            this.mskCPFCliente.Mask = "000.000.000-00";
            this.mskCPFCliente.Name = "mskCPFCliente";
            this.mskCPFCliente.Size = new System.Drawing.Size(91, 20);
            this.mskCPFCliente.TabIndex = 52;
            // 
            // dgvMedico
            // 
            this.dgvMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedico.Location = new System.Drawing.Point(301, 12);
            this.dgvMedico.Name = "dgvMedico";
            this.dgvMedico.Size = new System.Drawing.Size(519, 76);
            this.dgvMedico.TabIndex = 51;
            this.dgvMedico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMedico_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(12, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "CPF Medico:";
            // 
            // FMedAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtano);
            this.Controls.Add(this.txtmes);
            this.Controls.Add(this.btnAgenda);
            this.Controls.Add(this.dgvMedAgenda);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtIDmedico);
            this.Controls.Add(this.txtNomemedico);
            this.Controls.Add(this.btnPesquisaMedico);
            this.Controls.Add(this.mskCPFCliente);
            this.Controls.Add(this.dgvMedico);
            this.Controls.Add(this.label8);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FMedAgenda";
            this.Text = "FMedAgenda";
            this.Load += new System.EventHandler(this.FMedAgenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedAgenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtano;
        private System.Windows.Forms.TextBox txtmes;
        private System.Windows.Forms.Button btnAgenda;
        private System.Windows.Forms.DataGridView dgvMedAgenda;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIDmedico;
        private System.Windows.Forms.TextBox txtNomemedico;
        private System.Windows.Forms.Button btnPesquisaMedico;
        private System.Windows.Forms.MaskedTextBox mskCPFCliente;
        private System.Windows.Forms.DataGridView dgvMedico;
        private System.Windows.Forms.Label label8;
    }
}