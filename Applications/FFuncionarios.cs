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
    public partial class FFuncionarios : Form
    {
        private readonly FuncionarioServico funcionarioServico = new FuncionarioServico();
        public int codFuncionario = -1;
        public FFuncionarios()
        {
            InitializeComponent();
            RefreshDataGridView();
        }

        private void FFuncionarios_Load(object sender, EventArgs e)
        {

        }
       

        private void RefreshDataGridView()
        {
            dgvFuncionario.DataSource = funcionarioServico.ObterTodosInclude();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            List<Funcionario> funcionarios = funcionarioServico.Buscar(X => X.CPF == mskdtxtCPF.Text).ToList();
            bool vazio = !funcionarios.Any();
            if (vazio) {

                funcionarioServico.Gravar(
                     new Modelo.Funcionario()
                     {
                         Nome = txtNome.Text,
                         CPF = mskdtxtCPF.Text,
                         Identidade = txtIdentidate.Text,
                         Endereco = txtEndereco.Text,
                         Email = txtEmail.Text,
                         Telefone = mskdtxtTelefone.Text,
                         Date = DateTime.Now




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
               
                MessageBox.Show("CPF ja cadastrado");

            }
               
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {

            if (codFuncionario > 0)
            {
                
                    funcionarioServico.Atualizar(
                           new Modelo.Funcionario()
                           {
                               FuncionarioID = codFuncionario,
                               Nome = txtNome.Text,
                               CPF = mskdtxtCPF.Text,
                               Identidade = txtIdentidate.Text,
                               Endereco = txtEndereco.Text,
                               Email = txtEmail.Text,
                               Telefone = mskdtxtTelefone.Text,
                               Date = DateTime.Now

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
                MessageBox.Show("selecione um Funcionario");
            }
        }

        private void DgvFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int sel = dgvFuncionario.CurrentRow.Index;
            txtNome.Text = Convert.ToString(dgvFuncionario["nome", sel].Value);
            mskdtxtCPF.Text = Convert.ToString(dgvFuncionario["cpf", sel].Value);
            txtIdentidate.Text = Convert.ToString(dgvFuncionario["identidade", sel].Value);
            txtEndereco.Text = Convert.ToString(dgvFuncionario["endereco", sel].Value);
            txtEmail.Text = Convert.ToString(dgvFuncionario["email", sel].Value);
            mskdtxtTelefone.Text = Convert.ToString(dgvFuncionario["telefone", sel].Value);
            codFuncionario = Convert.ToInt16(dgvFuncionario["FuncionarioID", sel].Value);
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if (codFuncionario > 0)
            {
                funcionarioServico.Excluir(x => x.CPF == mskdtxtCPF.Text);
                RefreshDataGridView();
            }
            else
            {
                MessageBox.Show("SELECIONE UM FUNCIONARIO ANTES!");
            }
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            List<Funcionario> funcionarios = funcionarioServico.Buscar(X => X.Nome == txtNomeP.Text).ToList();

            dgvFuncionario.DataSource = funcionarios;

        }

        private void DgvFuncionario_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int sel = dgvFuncionario.CurrentRow.Index;
            txtNome.Text = Convert.ToString(dgvFuncionario["nome", sel].Value);
            mskdtxtCPF.Text = Convert.ToString(dgvFuncionario["cpf", sel].Value);
            txtIdentidate.Text = Convert.ToString(dgvFuncionario["identidade", sel].Value);
            txtEndereco.Text = Convert.ToString(dgvFuncionario["endereco", sel].Value);
            txtEmail.Text = Convert.ToString(dgvFuncionario["email", sel].Value);
            mskdtxtTelefone.Text = Convert.ToString(dgvFuncionario["telefone", sel].Value);
            codFuncionario = Convert.ToInt16(dgvFuncionario["FuncionarioID", sel].Value);

        }
    }
    
}
