namespace Applications
{
    partial class FAtendimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAtendimento));
            this.rtxtDescripcao = new System.Windows.Forms.RichTextBox();
            this.rtxtMedicamento = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnvalidar = new System.Windows.Forms.Button();
            this.dgvAtendimento = new System.Windows.Forms.DataGridView();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.dgvTratamento = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtIDcliente = new System.Windows.Forms.TextBox();
            this.txtMedico = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtendimento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTratamento)).BeginInit();
            this.SuspendLayout();
            // 
            // rtxtDescripcao
            // 
            this.rtxtDescripcao.Location = new System.Drawing.Point(34, 170);
            this.rtxtDescripcao.Name = "rtxtDescripcao";
            this.rtxtDescripcao.Size = new System.Drawing.Size(262, 107);
            this.rtxtDescripcao.TabIndex = 0;
            this.rtxtDescripcao.Text = "";
            // 
            // rtxtMedicamento
            // 
            this.rtxtMedicamento.Location = new System.Drawing.Point(384, 170);
            this.rtxtMedicamento.Name = "rtxtMedicamento";
            this.rtxtMedicamento.Size = new System.Drawing.Size(296, 107);
            this.rtxtMedicamento.TabIndex = 1;
            this.rtxtMedicamento.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(68, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Descripcao:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(471, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Medicamento:";
            // 
            // btnvalidar
            // 
            this.btnvalidar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnvalidar.Image = ((System.Drawing.Image)(resources.GetObject("btnvalidar.Image")));
            this.btnvalidar.Location = new System.Drawing.Point(305, 287);
            this.btnvalidar.Name = "btnvalidar";
            this.btnvalidar.Size = new System.Drawing.Size(75, 23);
            this.btnvalidar.TabIndex = 4;
            this.btnvalidar.Text = "Validar";
            this.btnvalidar.UseVisualStyleBackColor = true;
            this.btnvalidar.Click += new System.EventHandler(this.Btnvalidar_Click);
            // 
            // dgvAtendimento
            // 
            this.dgvAtendimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtendimento.Location = new System.Drawing.Point(23, 314);
            this.dgvAtendimento.Name = "dgvAtendimento";
            this.dgvAtendimento.Size = new System.Drawing.Size(764, 128);
            this.dgvAtendimento.TabIndex = 5;
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Location = new System.Drawing.Point(23, 12);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.Size = new System.Drawing.Size(369, 109);
            this.dgvConsulta.TabIndex = 6;
            this.dgvConsulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvConsulta_CellContentClick);
            // 
            // dgvTratamento
            // 
            this.dgvTratamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTratamento.Location = new System.Drawing.Point(398, 12);
            this.dgvTratamento.Name = "dgvTratamento";
            this.dgvTratamento.Size = new System.Drawing.Size(401, 109);
            this.dgvTratamento.TabIndex = 7;
            this.dgvTratamento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTratamento_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(71, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(239, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "IDCLiente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(465, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "IDMedico:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(112, 127);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 11;
            // 
            // txtIDcliente
            // 
            this.txtIDcliente.Location = new System.Drawing.Point(325, 130);
            this.txtIDcliente.Name = "txtIDcliente";
            this.txtIDcliente.ReadOnly = true;
            this.txtIDcliente.Size = new System.Drawing.Size(100, 20);
            this.txtIDcliente.TabIndex = 12;
            // 
            // txtMedico
            // 
            this.txtMedico.Location = new System.Drawing.Point(536, 127);
            this.txtMedico.Name = "txtMedico";
            this.txtMedico.ReadOnly = true;
            this.txtMedico.Size = new System.Drawing.Size(100, 20);
            this.txtMedico.TabIndex = 13;
            // 
            // FAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMedico);
            this.Controls.Add(this.txtIDcliente);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvTratamento);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.dgvAtendimento);
            this.Controls.Add(this.btnvalidar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxtMedicamento);
            this.Controls.Add(this.rtxtDescripcao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FAtendimento";
            this.Text = "FAtendimento";
            this.Load += new System.EventHandler(this.FAtendimento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtendimento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTratamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtDescripcao;
        private System.Windows.Forms.RichTextBox rtxtMedicamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnvalidar;
        private System.Windows.Forms.DataGridView dgvAtendimento;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.DataGridView dgvTratamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtIDcliente;
        private System.Windows.Forms.TextBox txtMedico;
    }
}