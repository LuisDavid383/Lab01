using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PG02__LAB01_FICHEROS_LUIS_MOSQUITO.Clases;

namespace PG02__LAB01_FICHEROS_LUIS_MOSQUITO
{
    public partial class Form1 : Form
    {
        //Instanciar la clase
        clsUsuario ObjUsuario = new clsUsuario();

        ArrayList aDatosUsuario = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                epUsuario.SetError(txtCodigo, "Debe ingresar el codigo");
                txtCodigo.Focus();
                return;
            }
            epUsuario.SetError(txtCodigo, "");

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                epUsuario.SetError(txtNombre, "Debe ingresar el nombre del usuario");
                txtNombre.Focus();
                return;
            }
            epUsuario.SetError(txtNombre, "");

            if (string.IsNullOrEmpty(txtPaterno.Text))
            {
                epUsuario.SetError(txtPaterno, "Debe ingresar el Apellido Paterno");
                txtPaterno.Focus();
                return;
            }
            epUsuario.SetError(txtPaterno, "");

            if (string.IsNullOrEmpty(txtMaterno.Text))
            {
                epUsuario.SetError(txtMaterno, "Debe ingresar el Apellido Materno");
                txtMaterno.Focus();
                return;
            }
            epUsuario.SetError(txtMaterno, "");




            ObjUsuario.codigo = txtCodigo.Text;
            ObjUsuario.nombre = txtNombre.Text;
            ObjUsuario.apellidoPaterno = txtPaterno.Text;
            ObjUsuario.apellidoMaterno = txtMaterno.Text;

            aDatosUsuario.Add(ObjUsuario);

            dgvUsuario.Rows.Add(ObjUsuario.codigo, ObjUsuario.nombre, ObjUsuario.apellidoPaterno, ObjUsuario.apellidoMaterno);

            mtd_Limpiar_Campos();
        }

        private void mtd_Limpiar_Campos()
        {
            txtCodigo.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtPaterno.Text = string.Empty;
            txtMaterno.Text = string.Empty;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            mtd_Guardar_Datos();
        }

        private void mtd_Guardar_Datos()
        {
            TextWriter escribir = new StreamWriter("Usuario.txt");
            escribir.Close();

            foreach (clsUsuario usuario in aDatosUsuario)
            {
                StreamWriter agregarusuario = File.AppendText("Usuario.txt");

                agregarusuario.WriteLine(usuario.codigo + "|" + usuario.nombre + "|" + usuario.apellidoPaterno + "|" + usuario.apellidoMaterno);
                agregarusuario.Close();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Selecionar en el data grid view
        }

        private void dgvUsuario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvUsuario.Rows.RemoveAt(0);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader leer = new StreamReader("Usuario.txt");
                string aux, linea, codigo, nombre, apellidopaterno, apellidomaterno;
                Int32 posicion;

                while ((linea = leer.ReadLine()) != null)
                {
                    posicion = linea.IndexOf("|");
                    aux = linea.Substring(0, posicion);
                    codigo = aux;

                    linea = linea.Substring(posicion + 1);
                    posicion = linea.IndexOf('|');
                    aux = linea.Substring(0, posicion);
                    nombre = aux;

                    linea = linea.Substring(posicion + 1);
                    posicion = linea.IndexOf('|');
                    aux = linea.Substring(0, posicion);
                    apellidopaterno = aux;

                    linea = linea.Substring(posicion + 1);
                    apellidomaterno = linea;

                    ObjUsuario.codigo = codigo;
                    ObjUsuario.nombre = nombre;
                    ObjUsuario.apellidoPaterno = apellidopaterno;
                    ObjUsuario.apellidoMaterno = apellidopaterno;

                    //agregar al array
                    aDatosUsuario.Add(ObjUsuario);

                    dgvUsuario.Rows.Add(ObjUsuario.codigo, ObjUsuario.nombre, ObjUsuario.apellidoPaterno, ObjUsuario.apellidoMaterno);
                }
                leer.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(e.ToString());
                MessageBox.Show("error");
            }
        }
    }
}
