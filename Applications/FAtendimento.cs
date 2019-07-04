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
    public partial class FAtendimento : Form
    {
        private AtendimentoServico atendimentoServico = new AtendimentoServico();
        private ConsultaServico consultaServico = new ConsultaServico();
        private TratamentoServico tratamentoServico = new TratamentoServico();
        public int CodAnimal { get; set; }
        public int Codcliente { get; set; }
        private string nome { get; set; }
        private double preco{ get; set; }

        private int CodMedico { get; set; }
        public FAtendimento(int codanimal, int medico)
        {
            CodAnimal = codanimal;
            CodMedico= medico;

            InitializeComponent();
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            dgvAtendimento.DataSource = atendimentoServico.ObterTodosInclude();
            List<Consulta> Consulta= consultaServico.Buscar(X => X.AnimalID == CodAnimal ).ToList();
            dgvConsulta.DataSource = Consulta;
            List<Tratamento> tratamento = tratamentoServico.Buscar(X => X.AnimalID == CodAnimal).ToList();
            dgvTratamento.DataSource = tratamento;
            dgvAtendimento.Columns["Medicos"].Visible = false;
            dgvAtendimento.Columns["Animals"].Visible = false;
            dgvAtendimento.Columns["Contaclinica"].Visible = false;
        }

        private void FAtendimento_Load(object sender, EventArgs e)
        {

        }

        private void Btnvalidar_Click(object sender, EventArgs e)
        {
        
            atendimentoServico.Gravar(
               new Modelo.Atendimento()
               {
                   Nome = nome,


                   Date = DateTime.Now ,
                   Preco = preco,
                   AnimalID = CodAnimal,
                   MedicoID = Convert.ToInt16(txtMedico.Text),
                   Proprietario = Convert.ToInt16(txtIDcliente.Text),
                   Descripcao = Convert.ToString(rtxtDescripcao.Text),
                   Medicamento= rtxtMedicamento.Text




               });
       



            RefreshDataGridView();
        }

        private void DgvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int sel = dgvConsulta.CurrentRow.Index;
           
            nome = Convert.ToString(dgvConsulta["nome", sel].Value);
            preco= Convert.ToDouble(dgvConsulta["preco", sel].Value);
            txtID.Text = Convert.ToString(dgvConsulta["Consultaid", sel].Value);
            txtIDcliente.Text = Convert.ToString(dgvConsulta["proprietario", sel].Value);
            txtMedico.Text = Convert.ToString(dgvConsulta["medicoid", sel].Value);



        }

        private void DgvTratamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int sel = dgvConsulta.CurrentRow.Index;

            nome = Convert.ToString(dgvTratamento["nome", sel].Value);
            preco = Convert.ToDouble(dgvTratamento["preco", sel].Value);
            txtID.Text = Convert.ToString(dgvTratamento["tratamentoid", sel].Value);
            txtIDcliente.Text = Convert.ToString(dgvTratamento["proprietario", sel].Value);
            txtMedico.Text = Convert.ToString(dgvTratamento ["medicoid", sel].Value);

        }
    }
}
