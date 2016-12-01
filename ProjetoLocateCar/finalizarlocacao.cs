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
    public partial class finalizarlocacao : Form
    {
        public finalizarlocacao()
        {
            InitializeComponent();
        }

        private void finalizarlocacao_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pedido finalizado com sucesso!", "+",
         MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            frmchecklist cmd5 = new frmchecklist();
                cmd5.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
