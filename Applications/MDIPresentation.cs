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
    public partial class MDIPresentation : Form
    {
         private int childFormNumber = 0;

        public MDIPresentation()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form
            {
                MdiParent = this,
                Text = "Window " + childFormNumber++
            };
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
            };
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                _ = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
            };
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                _ = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form cliente = new FCliente
            {
                MdiParent = this
            };
            cliente.Show();

        }

        private void MedicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Medico = new FMedico
            {
                MdiParent = this
            };


            Medico.Show();
        }

        private void FuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form Funcionario = new FFuncionarios
            {
                MdiParent = this
            };
            Funcionario.Show();
        }

        private void ContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Contacli = new FContaCli
            {
                MdiParent = this
            };
            Contacli.Show();
        }

        private void AgendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cliAgenda = new FCliAgenda
            {
                MdiParent = this
            };
            cliAgenda.Show();
        }

        private void MDIPresentation_Load(object sender, EventArgs e)
        {

        }

        private void AgendaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form medAgenda = new FMedAgenda
            {
                MdiParent = this
            };
            medAgenda.Show();
        }

        private void CaixaClinicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Caixacli = new FCaixaClinica
            {
                MdiParent = this
            };
            Caixacli.Show();

        }

        private void AnimaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form aniprontuario = new FAniProntuario
            {
                MdiParent = this
            };
            aniprontuario.Show();

        }
    }
}
