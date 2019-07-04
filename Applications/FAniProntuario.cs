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
    public partial class FAniProntuario : Form
    {
        private ClienteServico clienteServico = new ClienteServico();
        private AnimalServico animalServico = new AnimalServico();
        public int AnimalID { get; set; }
        public FAniProntuario()
        {
          
            InitializeComponent();
        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            List<Cliente> clientes = clienteServico.Buscar(X => X.CPF == mskdtxtCPF.Text).ToList();
            dgvCliente.DataSource = clientes;

        }

        private void FAniProntuario_Load(object sender, EventArgs e)
        {

        }

        private void DgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int sel = dgvCliente.CurrentRow.Index;
            txtNomecliente.Text = Convert.ToString(dgvCliente["nome", sel].Value);
            txtIDcliente.Text = Convert.ToString(dgvCliente["ClienteID", sel].Value);
        }

        private void BntBuscar_Click(object sender, EventArgs e)
        {
            List<Animal> animals = animalServico.Buscar(X => X.ClienteID== Convert.ToInt16(txtIDcliente.Text)).ToList();
            dgvAnimais.DataSource = animals;

        }

        private void DgvAnimais_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int sel = dgvAnimais.CurrentRow.Index;
            txtNomeAnimal.Text = Convert.ToString(dgvAnimais["nome", sel].Value);
            txtIDAnimal.Text = Convert.ToString(dgvAnimais["AnimalID", sel].Value);
            AnimalID = Convert.ToInt16(dgvAnimais["AnimalID", sel].Value);

        }
      
        private void BntProntuario_Click(object sender, EventArgs e)
        {
            FProntuario prontuario = new FProntuario(AnimalID);
            prontuario.Show();
        }
    }
}
