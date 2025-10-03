using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using PG02_TRABADIC_LUIS_MOSQUITO.Clases;

namespace PG02_TRABADIC_LUIS_MOSQUITO
{
    public partial class Frm_Mantenimiento_Usuario_LDMF : Form
    {
        //INSTANCIAR LA CLASE USUARIO
        clsUsuario_LDMF ObjUsuario = new clsUsuario_LDMF();

        //CREAR UN ARRAY LIST DONDE GUARDAR Y ALMACENAR LOS DATOS
        //ArrayList aDatosUsuario = new ArrayList();

        public Frm_Mantenimiento_Usuario_LDMF()
        {
            InitializeComponent();
            txt_Num_Documento.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //CASO EN QUE TODOS LOS VALORES ESTEN VACIOS
            if (string.IsNullOrEmpty(txtCodigo.Text) &&
                string.IsNullOrEmpty(txtNombre.Text) &&
                string.IsNullOrEmpty(txtPaterno.Text) &&
                string.IsNullOrEmpty(txtMaterno.Text) &&
                string.IsNullOrEmpty(cmb_Tipo_Documento.Text) &&
                string.IsNullOrEmpty(txt_Num_Documento.Text) &&
                string.IsNullOrEmpty(txtCelular.Text) &&
                string.IsNullOrEmpty(txtEmail.Text) &&
                string.IsNullOrEmpty(txtDireccion.Text))
            {
                MessageBox.Show("No puede dejar ningun elemento vacio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //VERIFICAR CADA ELEMENTO PARA QUE SE INGRESEN VALORES CORRECTOS


            //VERIFICAR EN EL TEXBOX CODIGO
            //VERIFICAR QUE EL CAMPO CODIGO NO ESTE VACIO
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                epUsuario.SetError(txtCodigo, "Debe ingresar el codigo");
                txtCodigo.Focus();
                return;
            }
            epUsuario.SetError(txtCodigo, "");

            //VERIFICAR QUE SE INGRESEN SOLO VALORES NUMERICOS
            if (!Regex.IsMatch(txtCodigo.Text, "^[0-9]*$"))
            {
                epUsuario.SetError(txtCodigo, "Solo puede ingresar valores numericos");
                txtCodigo.Focus();
                return;
            }
            epUsuario.SetError(txtCodigo, "");



            //VERIFICAR EN EL TEXBOX NOMBRE
            //VERIFICAR QUE EL CAMPO NOMBRE NO ESTE VACIO
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                epUsuario.SetError(txtNombre, "Debe ingresar el nombre del usuario");
                txtNombre.Focus();
                return;
            }
            epUsuario.SetError(txtNombre, "");

            //VERIFICAR QUE SE INGRESEN SOLO VALORES ALFABETICOS
            if (!Regex.IsMatch(txtNombre.Text, "^[A-Za-záéíóúÁÉÍÓÚñÑ ]*$"))
            {
                epUsuario.SetError(txtNombre, "Solo puede ingresar valores alfabeticos");
                txtNombre.Focus();
                return;
            }
            epUsuario.SetError(txtNombre, "");



            //VERIFICAR EL TEXBOX APELLIDO PATERNO
            //VERIFICAR QUE EL CAMPO APELLIDO PATERNO NO ESTE VACIO
            if (string.IsNullOrEmpty(txtPaterno.Text))
            {
                epUsuario.SetError(txtPaterno, "Debe ingresar el Apellido Paterno");
                txtPaterno.Focus();
                return;
            }
            epUsuario.SetError(txtPaterno, "");

            //VERIFICAR QUE SE INGRESE SOLO VALORES ALFANUMERICOS
            if (!Regex.IsMatch(txtPaterno.Text, "^[A-Za-záéíóúÁÉÍÓÚñÑ ]*$"))
            {
                epUsuario.SetError(txtPaterno, "Solo puede ingresar valores alfabeticos");
                txtPaterno.Focus();
                return;
            }
            epUsuario.SetError(txtPaterno, "");



            //VERIFICAR EL TEXBOX APELLIDO MATERNO
            //VERIFICAR QUE EL CAMPO APELLIDO MATERNO NO ESTE VACIO
            if (string.IsNullOrEmpty(txtMaterno.Text))
            {
                epUsuario.SetError(txtMaterno, "Debe ingresar el Apellido Materno");
                txtMaterno.Focus();
                return;
            }
            epUsuario.SetError(txtMaterno, "");

            //VERIFICAR QUE SE INGRESE SOLO VALORES ALFANUMERICOS
            if (!Regex.IsMatch(txtMaterno.Text, "^[A-Za-záéíóúÁÉÍÓÚñÑ ]*$"))
            {
                epUsuario.SetError(txtMaterno, "Solo puede ingresar valores alfabeticos");
                txtMaterno.Focus();
                return;
            }
            epUsuario.SetError(txtMaterno, "");



            //VERIFICAR EL COMBOBOX TIPO DE DOCUMENTO
            //VERIFICAR QUE EL COMBO BOX TIPO DE DOCUMENTO NO ESTE VACIO
            if (string.IsNullOrEmpty(cmb_Tipo_Documento.Text))
            {
                epUsuario.SetError(cmb_Tipo_Documento, "Debe ingresar el tipo de documento");
                cmb_Tipo_Documento.Focus();
                return;
            }
            epUsuario.SetError(cmb_Tipo_Documento, "");



            //VERIFICAR EL TEXTBOX NUMERO DE DOCUMENTO
            //VERIFICAR QUE EL CAMPO NUMERO DE DOCUMENTO NO ESTE VACIO
            if (string.IsNullOrEmpty(txt_Num_Documento.Text))
            {
                epUsuario.SetError(txt_Num_Documento, "Debe ingresar el numero de documento");
                txt_Num_Documento.Focus();
                return;
            }
            epUsuario.SetError(txt_Num_Documento, "");
            
            //VERIFICAR QUE SE INGRESEN LOS VALORES CORRECTOS SEGUN LA OPCION
            string seleccion = cmb_Tipo_Documento.SelectedItem.ToString();

            if (seleccion == "Pasaporte")
            {
                if (!Regex.IsMatch(txt_Num_Documento.Text, "^[A-Za-z0-9]*$"))
                {
                    epUsuario.SetError(txt_Num_Documento, "Solo puede ingresar valores alfanumericos");
                    txt_Num_Documento.Focus();
                    return;
                }
                epUsuario.SetError(txt_Num_Documento, "");
            }
            else if (seleccion == "DNI" || seleccion == "CARNET DE EXTRANJERIA")
            {
                if (!Regex.IsMatch(txt_Num_Documento.Text, "^[0-9]*$"))
                {
                    epUsuario.SetError(txt_Num_Documento, "Solo puede ingresar valores numericos");
                    txt_Num_Documento.Focus();
                    return;
                }
                epUsuario.SetError(txt_Num_Documento, "");
            }



            //VERIFICAR EL TEXBOX CELULAR
            //VERIFICAR QUE EL CAMPO CELULAR NO ESTE VACIO
            if (string.IsNullOrEmpty(txtCelular.Text))
            {
                epUsuario.SetError(txtCelular, "Debe ingresar el número de celular");
                txtCelular.Focus();
                return;
            }
            epUsuario.SetError(txtCelular, "");

            //VERIFICAR QUE SE INGRESEN SOLO VALORES NUMERICOS
            if (!Regex.IsMatch(txtCelular.Text, "^[0-9]*$"))
            {
                epUsuario.SetError(txtCelular, "Solo puede ingresar valores numericos");
                txtCelular.Focus();
                return;
            }
            epUsuario.SetError(txtCelular, "");



            //VERIFICAR EL TEXBOX EMAIL
            //VERIFICAR QUE EL CAMPO EMAIL NO ESTE VACIO
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                epUsuario.SetError(txtEmail, "Debe ingresar el email");
                txtEmail.Focus();
                return;
            }
            epUsuario.SetError(txtEmail, "");

            //VERIFICAR QUE SE INGRESA SOLO CORREOS ELECTRONICOS
            if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                epUsuario.SetError(txtEmail, "Solo puede ingresar correos electronicos");
                txtEmail.Focus();
                return;
            }
            epUsuario.SetError(txtEmail, "");



            //VERIFICAR EL TEXTBOX DIRECCION
            //VERIFICAR QUE EL CAMPO DIRECCION NO ESTE VACIO
            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                epUsuario.SetError(txtDireccion, "Debe ingresar la dirección");
                txtDireccion.Focus();
                return;
            }
            epUsuario.SetError(txtDireccion, "");


            //INGRESAR LOS DATOS A LOS OBJETOS DE LA CLASE
            ObjUsuario.codigo = txtCodigo.Text;
            ObjUsuario.nombre = txtNombre.Text;
            ObjUsuario.apellidoPaterno = txtPaterno.Text;
            ObjUsuario.apellidoMaterno = txtMaterno.Text;
            ObjUsuario.tipo_documento = cmb_Tipo_Documento.Text;
            ObjUsuario.num_documento = txt_Num_Documento.Text;
            ObjUsuario.celular = txtCelular.Text;
            ObjUsuario.email = txtEmail.Text;
            ObjUsuario.direccion = txtDireccion.Text;

            //INGRESAR EN UN ARRAYLIST LOS DATOS INGRESADOR DE LA CLASE

            clsDatosGlobales_LDMF.Usuario.Add(ObjUsuario);

            //IMPRIMIR LOS DATOS EN UN DATAWGRIDVIEW
            dgvUsuario.Rows.Add(ObjUsuario.codigo,
                                ObjUsuario.nombre,
                                ObjUsuario.apellidoPaterno,
                                ObjUsuario.apellidoMaterno,
                                ObjUsuario.tipo_documento,
                                ObjUsuario.num_documento,
                                ObjUsuario.celular,
                                ObjUsuario.email,
                                ObjUsuario.direccion);

            mtd_Limpiar_Campos();
        }

        //METODO PARA LIMPIAR LOS DATOS INGRESADOS EN LOS TEXBOX
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
            using (StreamWriter sw = new StreamWriter("Usuario.txt"))
            {
                foreach (DataGridViewRow row in dgvUsuario.Rows)
                {
                    string[] valores = new string[row.Cells.Count];

                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        valores[i] = row.Cells[i].Value?.ToString() ?? "";
                    }
                    sw.WriteLine(string.Join("|", valores));
                }
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
                    clsDatosGlobales_LDMF.Usuario.Add(ObjUsuario);

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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmb_Tipo_Documento_SelectedIndexChanged(object sender, EventArgs e)
        {
            //VERIFICAR SI SE SELECCIONO UNA OPCION PARA HABILITAR EL TEXBOX NUMERO DE DOCUMENTO
            if (cmb_Tipo_Documento.SelectedIndex != -1)
            {
                txt_Num_Documento.Enabled = true;
                txt_Num_Documento.Text = string.Empty;
            }
            else
            {
                txt_Num_Documento.Enabled = false;
            }
        }
    }
}
