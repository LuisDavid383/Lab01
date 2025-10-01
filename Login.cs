using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PG02__LAB01_FICHEROS_LUIS_MOSQUITO
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //Declaracion de variables globales
        string strUsuario = "Admin";
        string strPassword = "1234";

        private void btnacceder_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text.ToUpper() == strUsuario.ToUpper() && txtpassword.Text == strPassword)
            {
                string a = txtusuario.Text;
                string b = txtpassword.Text;

                Form1 mDI_Principal = new Form1();
                mDI_Principal.Show();

            }
            else
            {
                MessageBox.Show("Error, Datos incorrectos");
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
