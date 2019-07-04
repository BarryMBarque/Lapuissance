using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servico.ServicoFolders;
using Modelo;
using System.Data.Entity;
    
namespace Applications
{
    public partial class FAnimal : Form
    {
        private readonly AnimalServico animalServico = new AnimalServico();
       
        public int codAnimalselecionado = -1;
        
        public int Codcliente { get; set; }
       public string ClienteNome { get; set; }
        public FAnimal(int codcliente, string clientenome )
        {
            Codcliente = codcliente;
            ClienteNome = clientenome;
            
            InitializeComponent();
            RefreshDataGridView();
        }
        public FAnimal()
        {

        }

        private void FAnimal_Load(object sender, EventArgs e)
        {
             
        }
        private void RefreshDataGridView()
        {
            dgvAnimal.DataSource = animalServico.ObterTodosInclude();
            dgvAnimal.Columns["Cliente"].Visible=false;
            dgvAnimal.Columns["Consultas"].Visible = false;
            dgvAnimal.Columns["Tratamentos"].Visible = false;
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            animalServico.Gravar(
             new Modelo.Animal()
             {
                ClienteID=Codcliente,
                Proprietario=ClienteNome,
                 
                 Nome = txtNome.Text,
                 Idade = Convert.ToInt16(txtIdade.Text),
                 Tipo = cbxTipo.Text,
                 Sub_tipo = cbxSubtipo.Text,
                 Raca = txtRaca.Text,
                 Date = DateTime.Now

             }); ;
            txtNome.Clear();
           txtIdade.Clear();
          
            txtRaca.Clear();
          


            RefreshDataGridView();
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            if (codAnimalselecionado > 0)
            {

                animalServico.Atualizar(
                     new Modelo.Animal()
                     {
                         AnimalID = codAnimalselecionado,
                         ClienteID= Codcliente,
                          
                         Nome = txtNome.Text,
                         Idade = Convert.ToInt16(txtIdade.Text),
                        Tipo = cbxTipo.Text,
                       Sub_tipo =cbxSubtipo.Text,
                         Raca = txtRaca.Text,
                     
                         Date = DateTime.Now

                     });
                txtNome.Clear();
               txtIdade.Clear();
                txtRaca.Clear();
             
                RefreshDataGridView();
            }
            else
            {
                MessageBox.Show("selecione um animal");
            }
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            List<Animal> animals = animalServico.Buscar(X => X.Nome == txtNomeP.Text).ToList();

            dgvAnimal.DataSource = animals;

        }

        private void DgvAnimal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int sel = dgvAnimal.CurrentRow.Index;
            txtNome.Text = Convert.ToString(dgvAnimal["nome", sel].Value);
            txtIdade.Text = Convert.ToString(dgvAnimal["idade", sel].Value);
            txtRaca.Text = Convert.ToString(dgvAnimal["raca", sel].Value);
            cbxTipo.Text = Convert.ToString(dgvAnimal["tipo", sel].Value);
            cbxSubtipo.Text = Convert.ToString(dgvAnimal["sub_tipo", sel].Value);
            codAnimalselecionado = Convert.ToInt16(dgvAnimal["animalid", sel].Value);
            Codcliente = Convert.ToInt16(dgvAnimal["clienteid", sel].Value);
        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            if (codAnimalselecionado > 0)
            {
                _ = new FAnimal();

                FConsulta consulta = new FConsulta(codAnimalselecionado,Codcliente);
                consulta.Show();
                this.WindowState = FormWindowState.Minimized;


            }
            else
            {
                MessageBox.Show("selecione um animal por favor!");
            }
        }

        private void BtnTratamento_Click(object sender, EventArgs e)
        {
            if (codAnimalselecionado > 0)
            {
                FTratamento tratamento = new FTratamento(codAnimalselecionado,Codcliente);
                tratamento.Show();
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                MessageBox.Show("selecione um animal por favor!");
            }
        }

        private void FAnimal_FormClosing(object sender, FormClosingEventArgs e)
        {
         
        }
    }
}
