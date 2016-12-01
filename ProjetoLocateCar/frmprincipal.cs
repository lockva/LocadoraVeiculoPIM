using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLocateCar
{
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void cadastroDeClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmcadcli cadcli2 = new frmcadcli();
            cadcli2.Show();
        }

        private void frmprincipal_Load(object sender, EventArgs e)
        {

        }

        private void cadastroDeVeículoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmcadveiculo chama2 = new frmcadveiculo();
            chama2.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void locarVeículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmlocacao cmd3 = new frmlocacao();
            cmd3.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            finalizarlocacao cmd4 = new finalizarlocacao();
            cmd4.Show();
        }

        private void desalocarVeículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdevolver cmd8 = new frmdevolver();
            cmd8.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmconsultar cmd9 = new frmconsultar();
            cmd9.Show();

        }

        private void controleDeAcessoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcontroledeacesso cmd10 = new frmcontroledeacesso();
            cmd10.Show();
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmbackup cmd11 = new frmbackup();
            cmd11.Show();

        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmfornecedor cmd12 = new frmfornecedor();
            cmd12.Show();
        }
    }
  
}
