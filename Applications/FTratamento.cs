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
    public partial class FTratamento : Form
    {
        private readonly TratamentoServico tratamentoServico = new TratamentoServico();
        private readonly MedicoServico medicoServico = new MedicoServico();
        public int CodAnimal { get; set; }
        public int Codcliente{ get; set; }

        public int CodMedico { get; set; }
        public FTratamento(int codanimal,int  codcliente)
        {
            CodAnimal = codanimal;
            Codcliente = codcliente;
          
            InitializeComponent();
            RefreshDataGridView();  
        }
        public FTratamento()
        {

            InitializeComponent();
            RefreshDataGridView();
        }
        private void RefreshDataGridView()
        {
         
            dgvTratamentos.DataSource = tratamentoServico.ObterTodosInclude();

            dgvMedicoTratamento.DataSource = medicoServico.ObterTodosInclude();
            List<Medico> medicos = medicoServico.Buscar(X => X.Especialidade == cbxTipo.Text).ToList();

            dgvMedicoTratamento.DataSource = medicos;
            dgvTratamentos.Columns["Medico"].Visible = false;
            dgvTratamentos.Columns["Animal"].Visible = false;
            dgvTratamentos.Columns["Descripcao"].Visible = false;
        }

        private void FTratamento_Load(object sender, EventArgs e)
        {

        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            tratamentoServico.Gravar(
                 new Modelo.Tratamento()
                 {
                     Nome = cbxTipo.Text,


                     Data_Tratamento = Convert.ToDateTime(dtpConsulta.Value),
                     Preco = Convert.ToDouble(txtPreco.Text),
                     AnimalID = CodAnimal,
                     MedicoID = Convert.ToInt16(txtIdMedico.Text),
                     Proprietario= Codcliente





                 });
            txtPreco.Clear();



            RefreshDataGridView();
        }

        private void DgvMedicoTratamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int sel = dgvMedicoTratamento.CurrentRow.Index;
            txtMedicoCon.Text = Convert.ToString(dgvMedicoTratamento["nome", sel].Value);
            txtIdMedico.Text = Convert.ToString(dgvMedicoTratamento["MedicoID", sel].Value);
        }

        private void BtnMedico_Click(object sender, EventArgs e)
        {
            List<Medico> medicos = medicoServico.Buscar(X => X.Especialidade == cbxTipo.Text).ToList();

            dgvMedicoTratamento.DataSource = medicos;

        }
    }
}
