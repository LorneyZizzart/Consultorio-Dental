using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Consultorio_Dental
{
    public partial class frmBuscar : Form
    {
        int posicion;
        public frmBuscar()
        {
            InitializeComponent();
            CargarRegistro();
            lblAlertaCarnet.Visible = false;
            lblAlerta.Visible = false;
        }
        public void CargarRegistro()
        {
            XDocument doc = XDocument.Load(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Base de Datos\Pacientes.xml");

            var frm = from c in doc.Descendants("Pacientes").Elements()
                      select new
                      {
                          ID = c.Element("Id").Value,
                          NOMBRE = c.Element("Nombre").Value,
                          APELLIDO = c.Element("Apellido").Value,
                          SEXO = c.Element("Sexo").Value,
                          CARNET = c.Element("Carnet").Value,
                          DIRECCION = c.Element("Direccion").Value,
                          LOCALIDAD = c.Element("Localidad").Value,
                          CELULAR = c.Element("Celular").Value,
                          COMENTARIO = c.Element("Comentario").Value};

            var total = (from tt in doc.Descendants("Pacientes").Elements()
                         select tt).Count();

            var varones = (from va in doc.Descendants("Pacientes").Elements()
                           where (string)va.Element("Sexo") == "Masculino"
                           select va).Count();

            var mujeres = (from mu in doc.Descendants("Pacientes").Elements()
                           where (string)mu.Element("Sexo") == "Femenino"
                           select mu).Count();

            lblTotalPacientes.Text = total.ToString();
            lblTotalVarones.Text = varones.ToString();
            lblTotalMujeres.Text = mujeres.ToString();
            tblPaciente.DataSource = frm.ToList();
            btnEliminar.Enabled = false;
            btnBuscar.Enabled = false;
        }

        private void btnBuscarInicio_Click(object sender, EventArgs e)
        {
            frmHome frmHome = new frmHome();
            frmHome.Show();
            this.Hide();
        }

        private void btnBuscarRegistro_Click(object sender, EventArgs e)
        {
            frmRegistro frmRegistro = new frmRegistro();
            frmRegistro.Show();
            this.Hide();
        }

        private void btnBuscarAgenda_Click(object sender, EventArgs e)
        {
            frmAgenda frmAgenda = new frmAgenda();
            frmAgenda.Show();
            this.Hide();
        }

        private void btnBuscarPacientes_Click(object sender, EventArgs e)
        {
            frmPacientes frmPacientes = new frmPacientes();
            frmPacientes.Show();
            this.Hide();
        }

        private void btnBuscarModificar_Click(object sender, EventArgs e)
        {
            frmModificar frmModificar = new frmModificar();
            frmModificar.Show();
            this.Hide();
        }

        private void btnBuscarSalir_Click(object sender, EventArgs e)
        {
            frmSalir frmSalir = new frmSalir();
            frmSalir.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmModificar frmModificar = new frmModificar();
            frmModificar.Show();
            this.Hide();
        }

        private void btnBuscarCarnet_Click(object sender, EventArgs e)
        {
            XDocument doc = XDocument.Load(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Base de Datos\Pacientes.xml");

            var car = (from a in doc.Descendants("Pacientes").Elements()
                      where (string)a.Element("Carnet") == txtCarnet.Text
                      select a).Count();
            if (car != 0)
            {
                lblAlertaCarnet.Visible = false;
                lblAlerta.Visible = false;
                var query = from c in doc.Descendants("Pacientes").Elements()
                            where (string)c.Element("Carnet") == txtCarnet.Text
                            select new
                            {
                                ID = c.Element("Id").Value,
                                NOMBRE = c.Element("Nombre").Value,
                                APELLIDO = c.Element("Apellido").Value,
                                SEXO = c.Element("Sexo").Value,
                                CARNET = c.Element("Carnet").Value,
                                DIRECCION = c.Element("Direccion").Value,
                                LOCALIDAD = c.Element("Localidad").Value,
                                CELULAR = c.Element("Celular").Value,
                                COMENTARIO = c.Element("Comentario").Value
                            };

                tblPaciente.DataSource = query.ToList();
            }
            else
            {
                tblPaciente.DataSource = null;
                lblAlerta.Visible = false;
                lblAlertaCarnet.Visible = true;
            }
        }

        private void btnBuscarNombre_Click(object sender, EventArgs e)
        {
            XDocument doc = XDocument.Load(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Base de Datos\Pacientes.xml");

            var nom = (from a in doc.Descendants("Pacientes").Elements()
                      where (string)a.Element("Nombre") == txtNombre.Text
                      select a).Count();

            if (nom != 0)
            {
                lblAlertaCarnet.Visible = false;
                lblAlerta.Visible = false;
                var query = from c in doc.Descendants("Pacientes").Elements()
                            where (((string)c.Element("Nombre") == txtNombre.Text))
                            select new
                            {
                                ID = c.Element("Id").Value,
                                NOMBRE = c.Element("Nombre").Value,
                                APELLIDO = c.Element("Apellido").Value,
                                SEXO = c.Element("Sexo").Value,
                                CARNET = c.Element("Carnet").Value,
                                DIRECCION = c.Element("Direccion").Value,
                                LOCALIDAD = c.Element("Localidad").Value,
                                CELULAR = c.Element("Celular").Value,
                                COMENTARIO = c.Element("Comentario").Value
                            };

                tblPaciente.DataSource = query.ToList();
            }
            else
            {
                lblAlerta.Visible = true;
                lblAlertaCarnet.Visible = false;
                tblPaciente.DataSource = null;
            }
        }

        private void tblPaciente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = tblPaciente.CurrentRow.Index;

            txtNombre.Text = tblPaciente[1, posicion].Value.ToString();
            txtCarnet.Text = tblPaciente[4, posicion].Value.ToString();

            btnEliminar.Enabled = true;
            btnBuscar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            XDocument doc = XDocument.Load(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Base de Datos\Pacientes.xml");

            var query = from c in doc.Descendants("Pacientes").Elements()
                        where (string)c.Element("Nombre") == txtNombre.Text
                        && (string)c.Element("Carnet") == txtCarnet.Text
                        select c;
            query.Remove();
            doc.Save(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Base de Datos\Pacientes.xml");

            MessageBox.Show("Se elimino el paciente del registro exitosamente", "FELICIDADES", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            txtNombre.Text = "";
            txtCarnet.Text = "";
            CargarRegistro();
        }

        private void txtCarnet_TextChanged(object sender, EventArgs e)
        {
            XDocument doc = XDocument.Load(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Base de Datos\Pacientes.xml");

            if ((txtCarnet.Text != "") || (txtNombre.Text != ""))
            {
                var query = (from c in doc.Descendants("Pacientes").Elements()
                             where (string)c.Element("Carnet") == txtCarnet.Text
                             select c).Count();
                if (query != 0)
                {
                    var nomCompleto = from c in doc.Descendants("Pacientes").Elements()
                                      where (string)c.Element("Carnet") == txtCarnet.Text
                                      select c;

                    foreach (var item in nomCompleto)
                    {
                        string name = string.Format(item.Element("Nombre").Value);
                        string lastname = string.Format(item.Element("Apellido").Value);

                        lblAviso.Text = name + " " + lastname;
                    }

                    btnEliminar.Enabled = true;
                    btnBuscar.Enabled = true;
                }
                else{
                    lblAviso.Text = "Buscando......";
                    btnEliminar.Enabled = false;
                    btnBuscar.Enabled = false;
                }

            }
            else
            {
                btnEliminar.Enabled = false;
                btnBuscar.Enabled = false;
            }
            if (txtCarnet.Text == "")
            {
                CargarRegistro();
                lblAlertaCarnet.Visible = false;
                lblAlerta.Visible = false;
            }
        }

        private void btnBuscarBuscar_Click(object sender, EventArgs e)
        {
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            XDocument doc = XDocument.Load(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Base de Datos\Pacientes.xml");
           
            var query = (from c in doc.Descendants("Pacientes").Elements()
                        where (string)c.Element("Nombre") == txtNombre.Text
                        select c).Count();

            if (query != 0)
            {
                var nomCompleto = from c in doc.Descendants("Pacientes").Elements()
                                  where (string)c.Element("Nombre") == txtNombre.Text
                                  select c;

                foreach (var item in nomCompleto)
                {
                    string name = string.Format(item.Element("Nombre").Value);
                    string lastname = string.Format(item.Element("Apellido").Value);

                    lblAviso.Text = name + " " + lastname;
                }

                btnBuscar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else
            {
                lblAviso.Text = "Buscando......";
                btnEliminar.Enabled = false;
                btnBuscar.Enabled = false;
            }

            if (txtNombre.Text == "")
            {
                CargarRegistro();
                lblAlertaCarnet.Visible = false;
                lblAlerta.Visible = false;
            }
        }

        private void tblPaciente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
