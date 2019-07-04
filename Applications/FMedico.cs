using Modelo;
using Servico;
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
    public partial class FMedico : Form
    {
        private readonly MedicoServico medicoServico = new MedicoServico();
        public int codMedSelecionado = -1;
       // public string Nome_Animal { get; set; }



       
        public FMedico()
        {
            InitializeComponent();
            RefreshDataGridView();
        }
        private void RefreshDataGridView()
        {
            dgvMedico.DataSource = medicoServico.ObterTodosInclude();
        }


        private void FMedico_Load(object sender, EventArgs e)
        {

        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            List<Medico> medicos = medicoServico.Buscar(X => X.CPF == mskdtxtCPF.Text).ToList();
            bool vazio = !medicos.Any();
            if (vazio) {
                medicoServico.Gravar(
                     new Modelo.Medico()
                     {
                         Nome = txtNome.Text,
                         CPF = mskdtxtCPF.Text,
                         Identidade = txtIdentidate.Text,
                         Endereco = txtEndereco.Text,
                         Email = txtEmail.Text,
                         Telefone = mskdtxtTelefone.Text,
                         Date = DateTime.Now,
                         CRM = txtCRM.Text,
                         Especialidade = txtEspecialidade.Text




                     });
                txtNome.Clear();
                mskdtxtCPF.Clear();
                txtIdentidate.Clear();
                txtEndereco.Clear();
                txtEmail.Clear();
                mskdtxtTelefone.Clear();


                RefreshDataGridView();
            }
            else
            {
                MessageBox.Show("CPF ja Cadastrado");
            }
               
        }

        private void DgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int sel = dgvMedico.CurrentRow.Index;
            txtNome.Text = Convert.ToString(dgvMedico["nome", sel].Value);
            mskdtxtCPF.Text = Convert.ToString(dgvMedico["cpf", sel].Value);
            txtIdentidate.Text = Convert.ToString(dgvMedico["identidade", sel].Value);
            txtEndereco.Text = Convert.ToString(dgvMedico["endereco", sel].Value);
            txtEmail.Text = Convert.ToString(dgvMedico["email", sel].Value);
            mskdtxtTelefone.Text = Convert.ToString(dgvMedico["telefone", sel].Value);
            codMedSelecionado = Convert.ToInt16(dgvMedico["MedicoID", sel].Value);
            txtCRM.Text = Convert.ToString(dgvMedico["CRM", sel].Value);
            txtEspecialidade.Text = Convert.ToString(dgvMedico["Especialidade", sel].Value);


        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            if (codMedSelecionado > 0)
            {
                    medicoServico.Atualizar(
                        new Modelo.Medico()
                        {
                            MedicoID = codMedSelecionado,
                            Nome = txtNome.Text,
                            CPF = mskdtxtCPF.Text,
                            Identidade = txtIdentidate.Text,
                            Endereco = txtEndereco.Text,
                            Email = txtEmail.Text,
                            Telefone = mskdtxtTelefone.Text,
                            Date = DateTime.Now,
                            CRM = txtCRM.Text,
                            Especialidade = txtEspecialidade.Text

                        });
                    txtNome.Clear();
                    mskdtxtCPF.Clear();
                    txtIdentidate.Clear();
                    txtEndereco.Clear();
                    txtEmail.Clear();
                    mskdtxtTelefone.Clear();
                    RefreshDataGridView();
               
                   
            }
            else
            {
                MessageBox.Show("selecione um cliente");
            }

        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            List<Medico> medicos = medicoServico.Buscar(X => X.Nome == txtNomeP.Text).ToList();

            dgvMedico.DataSource = medicos;
        }

     
    }
}
