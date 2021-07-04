using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Splash_Screen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario, senha;
            usuario = txtUsuario.Text;
            senha = txtSenha.Text;

            if(usuario == "Admin" && senha == "123456")
            {
                Form2 novo = new Form2();
                novo.Show();
                this.Visible = false;
             

            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Senha ou Usuário incorreto", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ = dialogResult;
            }
              
        }

        private void btnEsqueci_Click(object sender, EventArgs e)
        {
            Form6 novo = new Form6();
            novo.Show();
            this.Visible = false;
        }
    }
}
