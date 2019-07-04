
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
    public partial class FContaCli : Form
    {
        private  ClienteServico clienteServico = new ClienteServico();
        private  AtendimentoServico atendimentoServico = new AtendimentoServico();
        private ContaclinicaServico contaclinicaServico = new ContaclinicaServico();
       
        public string Free { get; set; }

         
        public FContaCli()
        {
            InitializeComponent();
         
        }
      


        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void TxtIDfuncionario_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNomefuncionario_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnPesquisaCliente_Click(object sender, EventArgs e)
        {

        }

        private void DgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MskCPFFuncionario_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void BtnPesquisaCliente_Click_1(object sender, EventArgs e)
        {
            List<Cliente> clientes= clienteServico.Buscar(X => X.CPF == mskCPFCliente.Text).ToList();

            dgvcliente.DataSource = clientes;

        }

        private void Dgvcliente_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int sel = dgvcliente.CurrentRow.Index;
            txtNomecliente.Text = Convert.ToString(dgvcliente["nome", sel].Value);
            txtIDcliente.Text = Convert.ToString(dgvcliente["ClienteID", sel].Value);
        }

         

        private void BntConta_Click(object sender, EventArgs e)
        {
           
            List<Atendimento> atendimentos = atendimentoServico.Buscar(X => X.Proprietario == Convert.ToInt16(txtIDcliente.Text) && X.Preco != 0).ToList();
            dgvConta.DataSource = atendimentos;
            
        }

        private void FContaCli_Load(object sender, EventArgs e)
        {

        }

        private void DgvConta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int sel = dgvConta.CurrentRow.Index;
            txtPreco.Text = Convert.ToString(dgvConta["Preco", sel].Value);
            txtIdConta.Text = Convert.ToString(dgvConta["AtendimentoId", sel].Value);
            txtAnimalid.Text = Convert.ToString(dgvConta["Animalid", sel].Value);
            txtMedicoid.Text = Convert.ToString(dgvConta["Medicoid", sel].Value);
            Free = "Conta";
        }

        private void BntPagar_Click(object sender, EventArgs e)
        {
            
                int sel = dgvConta.CurrentRow.Index;
                if (Convert.ToDouble(dgvConta["Preco", sel].Value) <Convert.ToDouble(txtConta.Text))
                {
                    MessageBox.Show("Valor pago maior que Conta a pagar!");
                }
                else
                {
                    dgvConta["Preco", sel].Value = Convert.ToDouble(dgvConta["Preco", sel].Value) - Convert.ToDouble(txtConta.Text);
               
                }


               
             
                atendimentoServico.Atualizar(
                    
                       new Modelo.Atendimento()
                       {
                          
                           Preco = Convert.ToDouble(dgvConta["Preco", sel].Value),
                           AtendimentoID = Convert.ToInt16(txtIdConta.Text),
                           AnimalID = Convert.ToInt16(txtAnimalid.Text),
                           MedicoID = Convert.ToInt16(txtMedicoid.Text),
                           Date = Convert.ToDateTime(dgvConta["Date", sel].Value),
                           Nome = Convert.ToString(dgvConta["Nome", sel].Value),
                           Proprietario = Convert.ToInt16(txtIDcliente.Text),
                           Descripcao= Convert.ToString(dgvConta["Descripcao",sel].Value),
                           Medicamento= Convert.ToString(dgvConta["Medicamento",sel].Value)



                       });
            contaclinicaServico.Gravar(
                new Modelo.ContaClinica()
                {
                    AtendimentoID= Convert.ToInt16(txtIdConta.Text),
                    Preco=Convert.ToDouble(txtConta.Text),
                    Datapagamento= Convert.ToDateTime(dgvConta["Date", sel].Value),

                });
            
            

            
            
            



        }

      
    }

}
