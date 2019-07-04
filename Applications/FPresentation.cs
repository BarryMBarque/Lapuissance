using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
namespace Applications
{
    public partial class FPresentation : Form
    {
        public FPresentation()
        {
            InitializeComponent();
        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cliente = new FCliente();
            cliente.Show();
        }

        private void FPresentation_Load(object sender, EventArgs e)
        {

        }

        private void MedicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form medico = new FMedico();
            medico.Show();

        }
    }
}
