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
    public partial class frmModificar : Form
    {
        int posicion;
        string id, nacimiento;
        public frmModificar()
        {
            InitializeComponent();
            lblAlerta.Visible = false;
            gboxDatos.Enabled = false;
        }

        private void btnModificarInicio_Click(object sender, EventArgs e)
        {
            frmHome frmHome = new frmHome();
            frmHome.Show();
            this.Hide();
        }

        private void btnModificarBuscar_Click(object sender, EventArgs e)
        {
            frmBuscar frmBuscar = new frmBuscar();
            frmBuscar.Show();
            this.Hide();
        }

        private void btnModificarRegistro_Click(object sender, EventArgs e)
        {
            frmRegistro frmRegistrar = new frmRegistro();
            frmRegistrar.Show();
            this.Hide();
        }

        private void btnModificarAgenda_Click(object sender, EventArgs e)
        {
            frmAgenda frmAgenda = new frmAgenda();
            frmAgenda.Show();
            this.Hide();
        }

        private void btnModificarPacientes_Click(object sender, EventArgs e)
        {
            frmPacientes frmPacientes = new frmPacientes();
            frmPacientes.Show();
            this.Hide();
        }

        private void btnModificarSalir_Click(object sender, EventArgs e)
        {
            frmSalir frmSalir = new frmSalir();
            frmSalir.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            XDocument doc = XDocument.Load(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Base de Datos\Pacientes.xml");

            var iniciar = (from a in doc.Descendants("Pacientes").Elements()
                           where (((string)a.Element("Nombre") == txtNombreBuscar.Text)
                           || ((string)a.Element("Carnet") == txtCarnetBuscar.Text))
                           select a).Count();

            if (iniciar != 0)
            {
                lblAlerta.Visible = false;
                var query = from c in doc.Descendants("Pacientes").Elements()
                            where (((string)c.Element("Nombre") == txtNombreBuscar.Text)
                            || ((string)c.Element("Carnet") == txtCarnetBuscar.Text))
                            select new
                            {
                                ID = c.Element("Id").Value,
                                NOMBRE = c.Element("Nombre").Value,
                                APELLIDO = c.Element("Apellido").Value,
                                SEXO = c.Element("Sexo").Value,
                                CARNET = c.Element("Carnet").Value,
                                FECHA_DE_NACIMIENTO = c.Element("Nacimiento").Value,
                                DIRECCION = c.Element("Direccion").Value,
                                LOCALIDAD = c.Element("Localidad").Value,
                                CELULAR = c.Element("Celular").Value,
                                COMENTARIO = c.Element("Comentario").Value,
                            };

                tblPaciente.DataSource = query.ToList();
                gboxDatos.Enabled = true;
            }
            else
            {
                lblAlerta.Visible = true;
                tblPaciente.DataSource = null;
                gboxDatos.Enabled = false;
            }
        }

        private void tblPaciente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = tblPaciente.CurrentRow.Index;
            EliminarPaciente();
            id = tblPaciente[0, posicion].Value.ToString();
            txtNombre.Text = tblPaciente[1, posicion].Value.ToString();
            txtApellido.Text = tblPaciente[2, posicion].Value.ToString();
            txtSexo.Text = tblPaciente[3, posicion].Value.ToString();
            txtCarnet.Text = tblPaciente[4, posicion].Value.ToString();
            nacimiento = tblPaciente[5, posicion].Value.ToString();
            txtDireccion.Text = tblPaciente[6, posicion].Value.ToString();
            cboxLocalidad.Text = tblPaciente[7, posicion].Value.ToString();
            txtCelular.Text = tblPaciente[8, posicion].Value.ToString();
            txtComentario.Text = tblPaciente[9, posicion].Value.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var doc = XElement.Load(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Base de Datos\Pacientes.xml");

            //CREAR AL PACIENTE NUEVAMENTE YA MODIFICARDO
            if (doc != null)
            {

                var paciente =  new XElement("Paciente",
                    new XElement("Id", id),
                    new XElement("Nombre", txtNombre.Text),
                    new XElement("Apellido", txtApellido.Text),
                    new XElement("Sexo", txtSexo.Text),
                    new XElement("Carnet", txtCarnet.Text + " " + cboxCarnet.SelectedItem),
                    new XElement("Nacimiento", nacimiento),
                    new XElement("Direccion", txtDireccion.Text),
                    new XElement("Localidad", cboxLocalidad.Text),
                    new XElement("Celular", txtCelular.Text),
                    new XElement("Comentario", txtComentario.Text)
                    );

                doc.Add(paciente);
                doc.Save(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Base de Datos\Pacientes.xml");
                MessageBox.Show("Se modifico los datos del paciente\n        EXITOSAMENTE","FELICIDADES", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Se produjo un error al modificar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MostrarModificado();
        }

        public void EliminarPaciente()
        {
            XDocument doc = XDocument.Load(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Base de Datos\Pacientes.xml");

            var query = from c in doc.Descendants("Pacientes").Elements()
                        where (string)c.Element("Nombre") == txtNombreBuscar.Text
                        || (string)c.Element("Carnet") == txtCarnetBuscar.Text
                        select c;
            query.Remove();
            doc.Save(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Base de Datos\Pacientes.xml");
        }

        public void MostrarModificado()
        {
            XDocument xml = XDocument.Load(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Base de Datos\Pacientes.xml");
           
            var query = from c in xml.Descendants("Pacientes").Elements()
                        where (((string)c.Element("Nombre") == txtNombre.Text)
                        || ((string)c.Element("Carnet") == txtCarnet.Text))
                        select new
                        {
                            ID = c.Element("Id").Value,
                            NOMBRE = c.Element("Nombre").Value,
                            APELLIDO = c.Element("Apellido").Value,
                            SEXO = c.Element("Sexo").Value,
                            FECHA_DE_NACIMIENTO = c.Element("Nacimiento").Value,
                            CARNET = c.Element("Carnet").Value,
                            DIRECCION = c.Element("Direccion").Value,
                            LOCALIDAD = c.Element("Localidad").Value,
                            CELULAR = c.Element("Celular").Value,
                            COMENTARIO = c.Element("Comentario").Value,
                        };

            tblPaciente.DataSource = query.ToList();
        }

        private void tblPaciente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtSexo.Text = "";
            cboxCarnet.Text = "";
            txtCarnet.Text = "";
            txtDireccion.Text = "";
            cboxLocalidad.Text = "";
            txtCelular.Text = "";
            txtComentario.Text = "";
            
        }
    }
}
