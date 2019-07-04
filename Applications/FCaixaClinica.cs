using Servico.ServicoFolders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Applications
{
    public partial class FCaixaClinica : Form
    {
        private ContaclinicaServico contaClinicaServico = new ContaclinicaServico();
        public FCaixaClinica()
        {
            InitializeComponent();
            RefreshDataGridView();
        }
        private void RefreshDataGridView()
        {
            dgvCaixa.DataSource = contaClinicaServico.ObterTodosInclude();
            dgvCaixa.Columns["Tipo"].Visible = false;
            dgvCaixa.Columns["Atendimentos"].Visible = false;


        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FCaixaClinica_Load(object sender, EventArgs e)
        {

        }
    }
}
