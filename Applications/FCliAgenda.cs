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
    public partial class FCliAgenda : Form
    {
        private readonly ClienteServico clienteServico = new ClienteServico();
        private readonly ConsultaServico consultaServico = new ConsultaServico();
        public int Mes { get; set; }
        public int Ano { get; set; }

        public FCliAgenda()
        {
            InitializeComponent();
        }

        private void Dgvcliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int sel = dgvcliente.CurrentRow.Index;
            txtNomecliente.Text = Convert.ToString(dgvcliente["nome", sel].Value);
            txtIDcliente.Text = Convert.ToString(dgvcliente["ClienteID", sel].Value);
        }

        private void BtnPesquisaCliente_Click(object sender, EventArgs e)
        {

            List<Cliente> clientes = clienteServico.Buscar(X => X.CPF == mskCPFCliente.Text).ToList();

            dgvcliente.DataSource = clientes;
        }
        public List<Consulta> BuscarPorMes(int mes, int ano)
        {
            return consultaServico.Buscar(a => a.Data_Consulta.Month == mes && a.Data_Consulta.Year == ano).ToList();

        }

        private void BtnAgenda_Click(object sender, EventArgs e)
        {
            Mes = Convert.ToInt16(txtmes.Text);
            Ano = Convert.ToInt16(txtano.Text);

            dgvCliAgenda.DataSource = BuscarPorMes(Mes, Ano);
           
            

        }

        private void FCliAgenda_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Txtano_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txtmes_TextChanged(object sender, EventArgs e)
        {

        }

        private void DgvCliAgenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void TxtIDcliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNomecliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void MskCPFCliente_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }
    }
}
