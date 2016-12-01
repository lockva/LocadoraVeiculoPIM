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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            {
                if ((txtlogin.Text == "adm") && (txtsenha.Text == "123"))
                {
                    frmprincipal chamada = new frmprincipal();
                    chamada.Show();
                    this.Visible = false;

                }
                else
                {
                    MessageBox.Show("Usuário ou Senha inválidos!", "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }
    }
}
