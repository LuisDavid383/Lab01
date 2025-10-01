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
            //Verificar que el codigo no este vacio
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                epUsuario.SetError(txtCodigo, "Debe ingresar el codigo");
                txtCodigo.Focus();
                return;
            }
            epUsuario.SetError(txtCodigo, "");


            //Verificar que el nombre no este vacio
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                epUsuario.SetError(txtNombre, "Debe ingresar el nombre del usuario");
                txtNombre.Focus();
                return;
            }
            epUsuario.SetError(txtNombre, "");


            //Verificar que el paterno no este vacio+
            if (string.IsNullOrEmpty(txtPaterno.Text))
            {
                epUsuario.SetError(txtPaterno, "Debe ingresar el Apellido Paterno");
                txtPaterno.Focus();
                return;
            }
            epUsuario.SetError(txtPaterno, "");


            //Verificar que el materno no este vacio
            if (string.IsNullOrEmpty(txtMaterno.Text))
            {
                epUsuario.SetError(txtMaterno, "Debe ingresar el Apellido Materno");
                txtMaterno.Focus();
                return;
            }
            epUsuario.SetError(txtMaterno, "");


            //Verificar el tipo de documento
            if (string.IsNullOrEmpty(cmb_Tipo_Documento.Text))
            {
                epUsuario.SetError(cmb_Tipo_Documento, "Debe ingresar el tipo de documento");
                cmb_Tipo_Documento.Focus();
                return;
            }
            epUsuario.SetError(cmb_Tipo_Documento, "");


            //Verificar que el documento no este vacio
            if (string.IsNullOrEmpty(txt_Num_Documento.Text))
            {
                epUsuario.SetError(txt_Num_Documento, "Debe ingresar el numero de documento");
                txt_Num_Documento.Focus();
                return;
            }
            epUsuario.SetError(txt_Num_Documento, "");


            //Verificar que el celular no este vacio
            if (string.IsNullOrEmpty(txtCelular.Text))
            {
                epUsuario.SetError(txtCelular, "Debe ingresar el número de celular");
                txtCelular.Focus();
                return;
            }
            epUsuario.SetError(txtCelular, "");


            //Verificar que el email no este vacio
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                epUsuario.SetError(txtEmail, "Debe ingresar el email");
                txtEmail.Focus();
                return;
            }
            epUsuario.SetError(txtEmail, "");

            //Verificar que la direccion no este vacio
            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                epUsuario.SetError(txtDireccion, "Debe ingresar la dirección");
                txtDireccion.Focus();
                return;
            }
            epUsuario.SetError(txtDireccion, "");


            ObjUsuario.codigo = txtCodigo.Text;
            ObjUsuario.nombre = txtNombre.Text;
            ObjUsuario.apellidoPaterno = txtPaterno.Text;
            ObjUsuario.apellidoMaterno = txtMaterno.Text;
            ObjUsuario.tipo_documento = cmb_Tipo_Documento.Text;
            ObjUsuario.num_documento = txt_Num_Documento.Text;
            ObjUsuario.celular = txtCelular.Text;
            ObjUsuario.email = txtEmail.Text;
            ObjUsuario.direccion = txtDireccion.Text;

            aDatosUsuario.Add(ObjUsuario);

            dgvUsuario.Rows.Add(ObjUsuario.codigo, ObjUsuario.nombre, ObjUsuario.apellidoPaterno, ObjUsuario.apellidoMaterno, ObjUsuario.tipo_documento, ObjUsuario.num_documento, ObjUsuario.celular, ObjUsuario.email, ObjUsuario.direccion);

            mtd_Limpiar_Campos();
        }

        private void mtd_Limpiar_Campos()
        {
            txtCodigo.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtPaterno.Text = string.Empty;
            txtMaterno.Text = string.Empty;
            txt_Num_Documento.Text = string.Empty;
            txtCelular.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtDireccion.Text = string.Empty;
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
