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
    public partial class FProntuario : Form
    {
        private AtendimentoServico atendimentoServico = new AtendimentoServico();
        public int AnimalID { get; set; }
      
        public FProntuario(int animalid)
        {
            AnimalID = animalid;
            InitializeComponent();
        }

        private void FProntuario_Load(object sender, EventArgs e)
        {
            List<Atendimento> atendimentos = atendimentoServico.Buscar(X => X.AnimalID == AnimalID).ToList();
            dgvProntuario.DataSource = atendimentos;
        }
    }
}
