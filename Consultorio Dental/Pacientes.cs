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
    public partial class frmPacientes : Form
    {
        string CitaUrgente, month;
        public frmPacientes()
        {
            InitializeComponent();
            CargarLista();
            NuCitas();
        }

        public void CargarLista()
        {
            XDocument doc = XDocument.Load(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Base de Datos\Citas_Clinicas.xml");

            var lista = from c in doc.Descendants("Citas").Elements()
                        select new
                        {
                            N_CITA= c.Element("NuCita").Value,
                            NOMBRE_COMPLETO = c.Element("Nombre_Completo").Value,
                            CARNET = c.Element("Carnet").Value,
                            FECHA = c.Element("Fecha").Value,
                            HORA = c.Element("Hora").Value,
                            EPECIALIDAD = c.Element("Especialidad").Value,
                            TIPO = c.Element("Tipo").Value,
                            OBSERVACIONES = c.Element("Observaciones").Value,
                            CARACTERISTICA = c.Element("Caracteristica").Value
                        };
            tblPaciente.DataSource = lista.ToList();
        }

        public void NuCitas()
        {
            XDocument xml = XDocument.Load(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Base de Datos\Citas_Clinicas.xml");

            var urgente = (from c in xml.Descendants("Citas").Elements()
                           where (string)c.Element("Caracteristica") == "Cita Urgente"
                           select c).Count();
            var ordinaria = (from c in xml.Descendants("Citas").Elements()
                             where (string)c.Element("Caracteristica") == ""
                             select c).Count();

            lblNuCitaUrgente.Text = urgente.ToString();
            lblNuCitaOrdinaria.Text = ordinaria.ToString();
        }

        private void btnPacientesInicio_Click(object sender, EventArgs e)
        {
            frmHome frmHome = new frmHome();
            frmHome.Show();
            this.Hide();
        }

        private void btnPacientesBuscar_Click(object sender, EventArgs e)
        {
            frmBuscar frmBuscar = new frmBuscar();
            frmBuscar.Show();
            this.Hide();
        }

        private void btnPacientesRegistro_Click(object sender, EventArgs e)
        {
            frmRegistro frmRegistro = new frmRegistro();
            frmRegistro.Show();
            this.Hide();
        }

        private void btnPacientesAgenda_Click(object sender, EventArgs e)
        {
            frmAgenda frmAgenda = new frmAgenda();
            frmAgenda.Show();
            this.Hide();
        }

        private void btnPacientesModificar_Click(object sender, EventArgs e)
        {
            frmModificar frmModificar = new frmModificar();
            frmModificar.Show();
            this.Hide();
        }

        private void btnPacientesSalir_Click(object sender, EventArgs e)
        {
            frmSalir frmSalir = new frmSalir();
            frmSalir.Show();
        }

        private void mCalSearch_DateSelected(object sender, DateRangeEventArgs e)
        {
            XDocument doc = XDocument.Load(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Base de Datos\Citas_Clinicas.xml");

            var lista = from c in doc.Descendants("Citas").Elements()
                        where (string)c.Element("Fecha") == mCalSearch.SelectionStart.ToLongDateString()
                        select new
                        {
                            N_CITA = c.Element("NuCita").Value,
                            NOMBRE_COMPLETO = c.Element("Nombre_Completo").Value,
                            CARNET = c.Element("Carnet").Value,
                            FECHA = c.Element("Fecha").Value,
                            HORA = c.Element("Hora").Value,
                            EPECIALIDAD = c.Element("Especialidad").Value,
                            TIPO = c.Element("Tipo").Value,
                            OBSERVACIONES = c.Element("Observaciones").Value,
                            CARACTERISTICA = c.Element("Caracteristica").Value
                        };

            var citasOrd = (from nu in doc.Descendants("Citas").Elements()
                            where (string)nu.Element("Fecha") == mCalSearch.SelectionStart.ToLongDateString()
                            && (string)nu.Element("Caracteristica") == ""
                            select nu).Count();

            var citasUrg = (from nu in doc.Descendants("Citas").Elements()
                            where (string)nu.Element("Fecha") == mCalSearch.SelectionStart.ToLongDateString()
                            && (string)nu.Element("Caracteristica") == "Cita Urgente"
                            select nu).Count();

            lblNuCitaUrgente.Text = citasUrg.ToString();
            lblNuCitaOrdinaria.Text = citasOrd.ToString();

            tblPaciente.DataSource = lista.ToList();
        }

        private void btnPacientesPacientes_Click(object sender, EventArgs e)
        {
            frmPacientes frmPaciente = new frmPacientes();
            frmPaciente.Show();
            this.Hide();
        }

        private void cboxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboxTipo.SelectedItem.ToString() == "Cita Urgente")
            {
                CitaUrgente = "Cita Urgente";
            }
            else
                CitaUrgente = "";
        }

        private void cboxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            XDocument doc = XDocument.Load(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Base de Datos\Citas_Clinicas.xml");

            if (cboxMonth.SelectedItem.ToString() == "Enero") { month = 1 + ""; }
            if (cboxMonth.SelectedItem.ToString() == "Febrero") { month = 2 + ""; }
            if (cboxMonth.SelectedItem.ToString() == "Marzo") { month = 3 + ""; }
            if (cboxMonth.SelectedItem.ToString() == "Abril") { month = 4 + ""; }
            if (cboxMonth.SelectedItem.ToString() == "Mayo") { month = 5 + ""; }
            if (cboxMonth.SelectedItem.ToString() == "Junio") { month = 6 + ""; }
            if (cboxMonth.SelectedItem.ToString() == "Julio") { month = 7 + ""; }
            if (cboxMonth.SelectedItem.ToString() == "Agosto") { month = 8 + ""; }
            if (cboxMonth.SelectedItem.ToString() == "Septiembre") { month = 9 + ""; }
            if (cboxMonth.SelectedItem.ToString() == "Octubre") { month = 10 + ""; }
            if (cboxMonth.SelectedItem.ToString() == "Noviembre") { month = 11 + ""; }
            if (cboxMonth.SelectedItem.ToString() == "Diciembre") { month = 12 + ""; }

            var query = from c in doc.Descendants("Citas").Elements()
                        where (string)c.Element("Month") == month
                        select new
                        {
                            N_CITA = c.Element("NuCita").Value,
                            NOMBRE_COMPLETO = c.Element("Nombre_Completo").Value,
                            CARNET = c.Element("Carnet").Value,
                            FECHA = c.Element("Fecha").Value,
                            HORA = c.Element("Hora").Value,
                            EPECIALIDAD = c.Element("Especialidad").Value,
                            TIPO = c.Element("Tipo").Value,
                            OBSERVACIONES = c.Element("Observaciones").Value,
                            CARACTERISTICA = c.Element("Caracteristica").Value
                        };

            var citasOrd = (from nu in doc.Descendants("Citas").Elements()
                            where (string)nu.Element("Month") == month
                            && (string)nu.Element("Caracteristica") == ""
                            select nu).Count();

            var citasUrg = (from nu in doc.Descendants("Citas").Elements()
                            where (string)nu.Element("Month") == month
                            && (string)nu.Element("Caracteristica") == "Cita Urgente"
                            select nu).Count();

            lblNuCitaUrgente.Text = citasUrg.ToString();
            lblNuCitaOrdinaria.Text = citasOrd.ToString();
            tblPaciente.DataSource = query.ToList();
            cboxTipo.Text = "";


        }
        private void cboxTipo_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            XDocument doc = XDocument.Load(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Base de Datos\Citas_Clinicas.xml");

            var lista = from c in doc.Descendants("Citas").Elements()
                        where (string)c.Element("Month") == month
                        && (string)c.Element("Caracteristica") == CitaUrgente
                        select new
                        {
                            N_CITA = c.Element("NuCita").Value,
                            NOMBRE_COMPLETO = c.Element("Nombre_Completo").Value,
                            CARNET = c.Element("Carnet").Value,
                            FECHA = c.Element("Fecha").Value,
                            HORA = c.Element("Hora").Value,
                            EPECIALIDAD = c.Element("Especialidad").Value,
                            TIPO = c.Element("Tipo").Value,
                            OBSERVACIONES = c.Element("Observaciones").Value,
                            CARACTERISTICA = c.Element("Caracteristica").Value
                        };

            tblPaciente.DataSource = lista.ToList();
        }

        private void mCalSearch_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
