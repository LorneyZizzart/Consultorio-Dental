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
    public partial class frmRegistro : Form
    {
        int id = 1;

        public void Carga()
        {
            XDocument doc = XDocument.Load(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Base de Datos\Pacientes.xml");
            int val =1 ;            
            do
            {
                var iniciar = (from a in doc.Descendants("Pacientes").Elements()
                               where ((string)a.Element("Id") == id + "")
                               select a).Count();

                if (iniciar != 0)
                {
                    id++;
                    val = 1;
                }
                else
                {
                    val = 0;  
                }
            } while (val != 0);
            txtId.Text = id + ""; 
        }
        public frmRegistro()
        {

            InitializeComponent();
            Carga();
        }

        private void btnRegistroInicio_Click(object sender, EventArgs e)
        {
            frmHome frmHome = new frmHome();
            frmHome.Show();
            this.Hide();
        }

        private void btnRegistroBuscar_Click(object sender, EventArgs e)
        {
            frmBuscar frmBuscar = new frmBuscar();
            frmBuscar.Show();
            this.Hide();
        }

        private void btnRegistroSalir_Click(object sender, EventArgs e)
        {
            frmAgenda frmAgenda = new frmAgenda();
            frmAgenda.Show();
            this.Hide();
        }

        private void btnRegistroPacientes_Click(object sender, EventArgs e)
        {
            frmPacientes frmPacientes = new frmPacientes();
            frmPacientes.Show();
            this.Hide();
        }

        private void btnRegsitroModificar_Click(object sender, EventArgs e)
        {
            frmModificar frmModificar = new frmModificar();
            frmModificar.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmSalir frmSalir = new frmSalir();
            frmSalir.Show();
        }
        private void txtId_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
             var doc = XElement.Load(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Base de Datos\Pacientes.xml");

            if (doc != null && txtNombre.Text != "" && txtApellido.Text != "" && cboxSexo.Text != ""
                && txtCarnet.Text != "" && txtDireccion.Text != "" && cboxLocalidad.Text != "" 
                && txtCelular.Text != "")
            {
                var paciente = new XElement("Paciente",
                    new XElement("Id",txtId.Text),
                    new XElement("Nombre", txtNombre.Text),
                    new XElement("Apellido", txtApellido.Text),
                    new XElement("Sexo",cboxSexo.Text),
                    new XElement("Carnet", txtCarnet.Text+" "+cboxCarnet.SelectedItem),
                    new XElement("Nacimiento", mcanFeNacimiento.SelectionStart.ToLongDateString()),
                    new XElement("Direccion", txtDireccion.Text),
                    new XElement("Localidad", cboxLocalidad.Text),
                    new XElement("Celular", txtCelular.Text),
                    new XElement("Comentario", txtComentario.Text)
                    );

                doc.Add(paciente);
                doc.Save(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Base de Datos\Pacientes.xml");
                MessageBox.Show("Se registro exitosamente", "FELICIDADES", MessageBoxButtons.OK, MessageBoxIcon.None);

            }
            else
            {
                MessageBox.Show("Se produjo un error en el registro\ny no se admite espacios vacios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Carga();
            Vaciar();
        }
        void Vaciar()
        {
            txtId.Text = txtId.Text;
            txtNombre.Text = "";
            txtApellido.Text = "";
            cboxSexo.Text = "";
            txtCarnet.Text = "";
            cboxCarnet.Text = "";
            txtDireccion.Text = "";
            cboxLocalidad.Text = "";
            txtCelular.Text = "";
            txtComentario.Text = "";
        }
    }
}
