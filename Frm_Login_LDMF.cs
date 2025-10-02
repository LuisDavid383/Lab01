using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PG02_TRABADIC_LUIS_MOSQUITO
{
    public partial class Frm_Login_LDMF : Form
    {
        public Frm_Login_LDMF()
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

                Frm_Mantenimiento_Usuario_LDMF Usuario = new Frm_Mantenimiento_Usuario_LDMF();
                Usuario.Show();

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
