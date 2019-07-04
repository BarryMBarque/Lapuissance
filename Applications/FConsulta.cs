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
    public partial class FConsulta : Form
    {
        private readonly ConsultaServico consultaServico = new ConsultaServico();
        private readonly MedicoServico medicoServico = new MedicoServico();
        public int CodAnimal { get; set; }
        public int Codcliente { get; set; }
        public int CodMedico { get; set; }
        public FConsulta(int codanimal,int codcliente )
        {
            CodAnimal = codanimal;
            Codcliente = codcliente;

            InitializeComponent();
            RefreshDataGridView();
        }
        public FConsulta()
        {
            InitializeComponent();
            RefreshDataGridView();
        }

        
        private void RefreshDataGridView()
        {
            
            dgvConsulta.DataSource = consultaServico.ObterTodosInclude();

            dgvMedicoConsulta.DataSource = medicoServico.ObterTodosInclude();
            List<Medico> medicos = medicoServico.Buscar(X => X.Especialidade == cbxTipo.Text).ToList();

            dgvMedicoConsulta.DataSource = medicos;
            dgvConsulta.Columns["Medico"].Visible = false;
            dgvConsulta.Columns["Animal"].Visible = false;
            dgvConsulta.Columns["Descripcao"].Visible = false;
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            consultaServico.Gravar(
                  new Modelo.Consulta()
                  {
                      Nome = cbxTipo.Text,
                  
                     
                      Data_Consulta= Convert.ToDateTime(dtpConsulta.Value),
                      Preco = Convert.ToDouble(txtPreco.Text),
                      AnimalID= CodAnimal,
                      MedicoID= Convert.ToInt16(txtIdMedico.Text),
                      Proprietario=Codcliente





                  });
            txtPreco.Clear();
        


            RefreshDataGridView();
        }

        private void CbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FConsulta_Load(object sender, EventArgs e)
        {

        }

        private void DgvMedicoConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
            int sel = dgvMedicoConsulta.CurrentRow.Index;
            txtMedicoCon.Text = Convert.ToString(dgvMedicoConsulta["nome", sel].Value);
            txtIdMedico.Text = Convert.ToString(dgvMedicoConsulta["MedicoID", sel].Value);
        }

        private void BtnMedico_Click(object sender, EventArgs e)
        {
            List<Medico> medicos = medicoServico.Buscar(X => X.Especialidade == cbxTipo.Text).ToList();

            dgvMedicoConsulta.DataSource = medicos;

        }

        private void BtnAtender_Click(object sender, EventArgs e)
        {
            FAtendimento atendimento = new FAtendimento(CodAnimal,CodMedico);
            atendimento.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void DgvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int sel = dgvConsulta.CurrentRow.Index;
            txtIdconsulta.Text = Convert.ToString(dgvConsulta["Consultaid", sel].Value);
            txtProrietarios.Text = Convert.ToString(dgvConsulta["Proprietario", sel].Value);

        }

        private void TxtProrietarios_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
