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
    public partial class frmdevolver : Form
    {
        public frmdevolver()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Devolução realizada com sucesso!", "+",
         MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            frmchecklist cmd6 = new frmchecklist();
                cmd6.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmdevolver_Load(object sender, EventArgs e)
        {

        }
    }
}
