using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using Model;

namespace ProjetoLocateCar
{
    public partial class frmcadcli : Form
    {
        public frmcadcli()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cadastrado com sucesso!", "+",
         MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarEndereco_Click(object sender, EventArgs e)
        {
            Endereco end = new ClienteController().buscarEnderecoWS(txtCEP.Text);

            if ( end != null ) 
            {
                txtCEP.Text = end.cep;
                txtEndereco.Text = end.logradouro;
                txtBairro.Text = end.bairro;
                txtCidade.Text = end.localidade;
                txtUF.Text = end.uf;
            }
            else
            {
                MessageBox.Show("Endereço não encontrado!");
                txtEndereco.Text = "";
                txtBairro.Text = "";
                txtCidade.Text = "";
                txtUF.Text = ""; 
            }
        }
    }
}
