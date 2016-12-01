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
    public partial class frmlocacao : Form
    {
        public frmlocacao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Locação cadastrada com sucesso!", "+",
         MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            finalizarlocacao cmd7 = new finalizarlocacao();
            cmd7.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
