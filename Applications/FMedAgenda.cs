using Modelo;
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
    public partial class FMedAgenda : Form
    {
        private readonly MedicoServico medicoServico = new MedicoServico();
        private readonly ConsultaServico consultaServico = new ConsultaServico();
        public int Mes { get; set; }
        public int Ano { get; set; }
        public FMedAgenda()
        {
            InitializeComponent();
        }

        private void BtnPesquisaMedico_Click(object sender, EventArgs e)
        {

            List<Medico> medicos= medicoServico.Buscar(X => X.CPF == mskCPFCliente.Text).ToList();

            dgvMedico.DataSource = medicos;

        }
        public List<Consulta> BuscarPorMes(int mes, int ano)
        {
            return consultaServico.Buscar(a => a.Data_Consulta.Month == mes && a.Data_Consulta.Year == ano).ToList();

        }
        private void DgvMedico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int sel = dgvMedico.CurrentRow.Index;
            txtNomemedico.Text = Convert.ToString(dgvMedico["nome", sel].Value);
            txtIDmedico.Text = Convert.ToString(dgvMedico["MedicoID", sel].Value);
        }

        private void BtnAgenda_Click(object sender, EventArgs e)
        {
            Mes = Convert.ToInt16(txtmes.Text);
            Ano = Convert.ToInt16(txtano.Text);

             dgvMedAgenda.DataSource = BuscarPorMes(Mes, Ano);
            dgvMedAgenda.Columns["Medico"].Visible = false;
            dgvMedAgenda.Columns["Animal"].Visible = false;
            dgvMedAgenda.Columns["Descripcao"].Visible = false;
        }

        private void FMedAgenda_Load(object sender, EventArgs e)
        {

        }
    }
}
