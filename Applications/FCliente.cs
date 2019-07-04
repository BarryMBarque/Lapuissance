using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servico;
using System.Data.Entity;
using System.Data.SqlClient;
using Modelo;
using Servico.ServicoFolders;

namespace Applications
{
    public partial class FCliente : Form
    {
        private readonly ClienteServico clienteServico = new ClienteServico();
        private readonly FuncionarioServico funcionarioServico = new FuncionarioServico();

        public int codCliSelecionado = -1;
        public string ClienteNome { get; set; }
        public string Nome_Animal { get; set; }
 


        public FCliente()
        {
        
            InitializeComponent();
            RefreshDataGridView();
        }

        private void FCliente_Load(object sender, EventArgs e)
        {

        }
        private void RefreshDataGridView()
        {
            dgvCliente.DataSource = clienteServico.ObterTodosInclude();
            //dgvCliente.Columns["Funcionrio"].Visible = false;
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            List<Cliente> clientes = clienteServico.Buscar(X => X.CPF == mskdtxtCPF.Text).ToList();
            bool vazio = !clientes.Any();
            if (vazio) {
                clienteServico.Gravar(
                       new Modelo.Cliente()
                       {
                           FuncionarioID = Convert.ToInt16(txtIDfuncionario.Text),
                           Nome = txtNome.Text,
                           CPF = mskdtxtCPF.Text,
                           Identidade = txtIdentidate.Text,
                           Endereco = txtEndereco.Text,
                           Email = txtEmail.Text,
                           Telefone = mskdtxtTelefone.Text,
                           Date = DateTime.Now,





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
                MessageBox.Show("CPF já cadastrado");
            }


           

        }

      public void DgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int sel = dgvCliente.CurrentRow.Index;
            txtNome.Text = Convert.ToString(dgvCliente["nome", sel].Value);
            mskdtxtCPF.Text = Convert.ToString(dgvCliente["cpf", sel].Value);
            txtIdentidate.Text = Convert.ToString(dgvCliente["identidade", sel].Value);
            txtEndereco.Text = Convert.ToString(dgvCliente["endereco", sel].Value);
            txtEmail.Text = Convert.ToString(dgvCliente["email", sel].Value);
            mskdtxtTelefone.Text = Convert.ToString(dgvCliente["telefone", sel].Value);
            codCliSelecionado = Convert.ToInt16(dgvCliente["ClienteID", sel].Value);
            ClienteNome = txtNome.Text = Convert.ToString(dgvCliente["nome", sel].Value);

        }

        private void BtnAdicionarAnimal_Click(object sender, EventArgs e)
        {
            if (codCliSelecionado > 0)
            {
                FAnimal fanimal = new FAnimal(codCliSelecionado,ClienteNome);
                fanimal.Show();
                this.WindowState = FormWindowState.Minimized;

              
            

            }
            else
            {
                MessageBox.Show("selectione um cliente ");

            }
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            if (codCliSelecionado > 0) {
               
                    clienteServico.Atualizar(
                        new Modelo.Cliente()
                        {
                            FuncionarioID = Convert.ToInt16(txtIDfuncionario.Text),
                            ClienteID = codCliSelecionado,
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
                MessageBox.Show("selecione um cliente"); 
            }
       



        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            List<Cliente> clientes = clienteServico.Buscar(X => X.Nome == txtNomeP.Text).ToList();
         
            dgvCliente.DataSource = clientes;
         

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (codCliSelecionado > 0)
            {
                clienteServico.Excluir(x => x.CPF == mskdtxtCPF.Text);
                RefreshDataGridView();
            }
            else
            {
                MessageBox.Show("SELECIONE UM CIENTE ANTES!");
            }
        }

        private void DgvFucionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int sel = dgvFuncionario.CurrentRow.Index;
            txtNomefuncionario.Text = Convert.ToString(dgvFuncionario["nome", sel].Value);
            txtIDfuncionario.Text = Convert.ToString(dgvFuncionario["FuncionarioID", sel].Value);

        }

        private void BtnPesquisaFuncionario_Click(object sender, EventArgs e)
        {
            List<Funcionario> funcionarios = funcionarioServico.Buscar(X => X.CPF == mskCPFFuncionario.Text).ToList();

            dgvFuncionario.DataSource = funcionarios;

        }
    }
}
