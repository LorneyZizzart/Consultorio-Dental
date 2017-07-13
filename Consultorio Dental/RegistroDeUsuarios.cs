using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Consultorio_Dental
{
    public partial class frmRegistroUsuario : Form
    {
        string nombre = null, 
               apellido = null, 
               correo = null, 
               telefono = null, 
               celular = null, 
               cargo = null, 
               nick = null, 
               password = null;

        public frmRegistroUsuario()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmSalir frmSalir = new frmSalir();
            frmSalir.Show();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                nombre = txtNombre.Text;
                pictureNombre.Image = Image.FromFile(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Images\Bien.ico");
                pictureNombre.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else
            {
                pictureNombre.Image = Image.FromFile(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Images\Error.ico");
                pictureNombre.SizeMode = PictureBoxSizeMode.CenterImage;
            }
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            if (txtApellido.Text != "")
            {
                apellido = txtApellido.Text;
                pictureApellido.Image = Image.FromFile(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Images\Bien.ico");
                pictureApellido.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else
            {
                pictureApellido.Image = Image.FromFile(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Images\Error.ico");
                pictureApellido.SizeMode = PictureBoxSizeMode.CenterImage;
            }
        }

        private void txtCorreoElectronio_TextChanged(object sender, EventArgs e)
        {
            if ((txtCorreo.Text != "") && (cBoxExtCorreo.SelectedItem != null))
            {
                correo = txtCorreo.Text + cBoxExtCorreo.SelectedItem;
                pictureCorreo.Image = Image.FromFile(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Images\Bien.ico");
                pictureCorreo.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else
            {
                pictureCorreo.Image = Image.FromFile(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Images\Error.ico");
                pictureCorreo.SizeMode = PictureBoxSizeMode.CenterImage;
            }
        }

        private void txtTelefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (txtTelefono.Text != null)
             {
                 telefono = txtTelefono.Text;
                pictureTelefono.Image = Image.FromFile(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Images\Bien.ico");
                pictureTelefono.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else
            {
                pictureTelefono.Image = Image.FromFile(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Images\Error.ico");
                pictureTelefono.SizeMode = PictureBoxSizeMode.CenterImage;
            }
        }

        private void txtCelular_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (txtCelular.Text != null)
            {
                celular = txtCelular.Text;
                pictureCelular.Image = Image.FromFile(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Images\Bien.ico");
                pictureCelular.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else
            {
                pictureCelular.Image = Image.FromFile(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Images\Error.ico");
                pictureCelular.SizeMode = PictureBoxSizeMode.CenterImage;
            }
        }

        private void cBoxCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxCargo.Text != "")
            {
                cargo = cBoxCargo.Text;
                pictureCargo.Image = Image.FromFile(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Images\Bien.ico");
                pictureCargo.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else
            {
                pictureCargo.Image = Image.FromFile(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Images\Error.ico");
                pictureCargo.SizeMode = PictureBoxSizeMode.CenterImage;
            }
        }

        private void txtNick_TextChanged(object sender, EventArgs e)
        {
            XDocument docu = XDocument.Load(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Base de Datos\Registro.xml");

            if ((txtNick.Text != "") && (docu != null))
            {
                var iniciar = (from a in docu.Descendants("Personas").Elements()
                               where (string)a.Element("Nick") == txtNick.Text
                               select a.Name).Count();

                if (iniciar != 0)
                {
                    pictureNick.Image = Image.FromFile(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Images\Error.ico");
                    pictureNick.SizeMode = PictureBoxSizeMode.CenterImage;
                    return;

                }
                else
                {
                    nick = txtNick.Text;
                    pictureNick.Image = Image.FromFile(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Images\Bien.ico");
                    pictureNick.SizeMode = PictureBoxSizeMode.CenterImage;
                }
            }
            else
            {
                pictureNick.Image = Image.FromFile(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Images\Error.ico");
                pictureNick.SizeMode = PictureBoxSizeMode.CenterImage;
            }
        }

        private void txtPassword1_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword1.Text != "")
            {
                picturePassword1.Image = Image.FromFile(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Images\Bien.ico");
                picturePassword1.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else
            {
                picturePassword1.Image = Image.FromFile(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Images\Error.ico");
                picturePassword1.SizeMode = PictureBoxSizeMode.CenterImage;
            }
        }

        private void txtPassword2_TextChanged(object sender, EventArgs e)
        {
            if ((txtPassword2.Text != "") && (txtPassword2.Text == txtPassword1.Text))
            {
                password = txtPassword2.Text;
                picturePassword2.Image = Image.FromFile(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Images\Bien.ico");
                picturePassword2.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else
            {
                picturePassword2.Image = Image.FromFile(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Images\Error.ico");
                picturePassword2.SizeMode = PictureBoxSizeMode.CenterImage;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var doc = XElement.Load(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Base de Datos\Registro.xml");

            if ((doc != null) && (txtNombre.Text != "") && (txtApellido.Text != "")
                && (txtCorreo.Text != "") && (cBoxCargo != null) && (txtNick.Text != "")
                && (txtPassword1.Text != "") && (txtPassword2.Text != ""))
            {
                var newUser = new XElement("Persona",
                    new XElement("Nombre", nombre),
                    new XElement("Apellido", apellido),
                    new XElement("Correo", correo),
                    new XElement("Telefono", telefono),
                    new XElement("Celular", celular),
                    new XElement("Cargo", cargo),
                    new XElement("Nick", nick),
                    new XElement("Password", password));

                //doc.ReplaceNodes(newUser,newUser);

                doc.Add(newUser);
                doc.Save(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Base de Datos\Registro.xml");
                MessageBox.Show("El registro fue exitosamente", "BIENVENIDO", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Se produjo un error al momento del registro\nno se debe dejar espacios en blanco.", "ERROR EN EL REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Limpiar();
        }

        void Limpiar()
        {
            txtNombre.Text = ""; txtApellido.Text = ""; txtCorreo.Text = ""; cBoxExtCorreo.Text = null;
            txtTelefono.Text = null; txtCelular.Text = null; cBoxCargo.Text = null; txtNick.Text = "";
            txtPassword1.Text = ""; txtPassword2.Text = "";
        }
    }
}

