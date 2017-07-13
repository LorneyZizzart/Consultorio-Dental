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
    public partial class frmAgenda : Form
    {
        int posicion;
        string nu, day, month, year;

        //PARA LA MODIFICACION DE LA CITA MEDICA
        string nombreCompleto, carnet, observaciones;
        
        public frmAgenda()
        {
            InitializeComponent();
            gboxReservas.Enabled = false;
            lblAlerta.Visible = false;
            lblAlertaAgenda.Visible = false;
            btnReserva.Enabled = false;
            btnGuardar.Visible = false;
            btnGuardarUrgente.Visible = false;

        }

        //ACCESOS DIRECTOS DE PARA LOS FORMS
        private void btnAgendaInico_Click(object sender, EventArgs e)
        {
            frmHome frmHome = new frmHome();
            frmHome.Show();
            this.Hide();
        }

        private void btnAgendaBuscar_Click(object sender, EventArgs e)
        {
            frmBuscar frmAgenda = new frmBuscar();
            frmAgenda.Show();
            this.Hide();
        }

        private void btnAgendaRegistro_Click(object sender, EventArgs e)
        {
            frmRegistro frmRegistro = new frmRegistro();
            frmRegistro.Show();
            this.Hide();
        }

        private void btnAgendaPacientes_Click(object sender, EventArgs e)
        {
            frmPacientes frmPacientes = new frmPacientes();
            frmPacientes.Show();
            this.Hide();
        }

        private void btnAgendaModificar_Click(object sender, EventArgs e)
        {
            frmModificar frmModificar = new frmModificar();
            frmModificar.Show();
            this.Hide();
        }

        private void btnAgendaSalir_Click(object sender, EventArgs e)
        {
            frmSalir frmSalir = new frmSalir();
            frmSalir.Show();
        }

        private void btnBuscarNombre_Click(object sender, EventArgs e)
        {
            //PARA BUSCAR AL PACIENTE POR SU NAME 
            XDocument doc = XDocument.Load(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Base de Datos\Pacientes.xml");
            NuCita();
            var iniciar = (from a in doc.Descendants("Pacientes").Elements()
                           where (string)a.Element("Nombre") == txtNombreBuscar.Text
                           select a).Count();

            if (iniciar != 0)
            {
                lblAlerta.Visible = false;
                var query = from c in doc.Descendants("Pacientes").Elements()
                            where (((string)c.Element("Nombre") == txtNombreBuscar.Text))
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
                                COMENTARIO = c.Element("Comentario").Value,
                            };

                tblPaciente.DataSource = query.ToList();

                //PARA BUSCAR AL PACIENTE EN LA AGENDA, SI TIENE UNA CITA PENDIENTE

                XDocument registro = XDocument.Load(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Base de Datos\Citas_Clinicas.xml");

                posicion = tblPaciente.CurrentRow.Index;

                var i = (from a in registro.Descendants("Citas").Elements()
                         where (string)a.Element("Nombre_Completo") == (tblPaciente[1, posicion].Value.ToString()) + " " + (tblPaciente[2, posicion].Value.ToString())
                         select a).Count();
                if (i != 0)
                {
                    var agendados = from c in doc.Descendants("Citas").Elements()
                                    where (string)c.Element("Nombre_Completo") == (tblPaciente[1, posicion].Value.ToString()) + " " + (tblPaciente[2, posicion].Value.ToString())
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
                    tblEliminar.DataSource = agendados.ToList();
                    tblModificar.DataSource = agendados.ToList();
                    tblAgenda.DataSource = agendados.ToList();
                    lblAlertaAgenda.Visible = false;
                    btnReserva.Enabled = false;
                    btnReservarUrg.Enabled = false;

                }
                else
                {
                    tblEliminar.DataSource = null;
                    tblModificar.DataSource = null;
                    tblAgenda.DataSource = null;
                    lblAlertaAgenda.Visible = true;
                    btnReserva.Enabled = true;
                    btnReservarUrg.Enabled = false;
                }
                gboxReservas.Enabled = true;
            }
            else
            {
                lblAlerta.Visible = true;
                gboxReservas.Enabled = false;
                tblPaciente.DataSource = null;
            }

        }

        private void btnBuscarCarnet_Click(object sender, EventArgs e)
        {
            //BUSCAR AL PACIENTE POR SU CARNET
            XDocument doc = XDocument.Load(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Base de Datos\Pacientes.xml");
            NuCita();

            var iniciar = (from a in doc.Descendants("Pacientes").Elements()
                           where (string)a.Element("Carnet") == txtCarnetBuscar.Text
                select a).Count();

            if (iniciar != 0)
            {
                lblAlerta.Visible = false;

                var query = from c in doc.Descendants("Pacientes").Elements()
                            where (string)c.Element("Carnet") == txtCarnetBuscar.Text
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

                //PARA BUSCAR AL PACIENTE POR SU CARNET SI TIENE UNA CITA PENDIENTE

                XDocument registro = XDocument.Load(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Base de Datos\Citas_Clinicas.xml");

                posicion = tblPaciente.CurrentRow.Index;

                var i = (from a in registro.Descendants("Citas").Elements()
                               where (string)a.Element("Nombre_Completo") == (tblPaciente[1, posicion].Value.ToString()) + " " + (tblPaciente[2, posicion].Value.ToString())
                               select a).Count();
                if (i != 0)
                {
                    var agendados = from c in doc.Descendants("Citas").Elements()
                                    where (string)c.Element("Nombre_Completo") == (tblPaciente[1, posicion].Value.ToString()) + " " + (tblPaciente[2, posicion].Value.ToString())
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
                    tblEliminar.DataSource = agendados.ToList();
                    tblModificar.DataSource = agendados.ToList();
                    tblAgenda.DataSource = agendados.ToList();
                    lblAlertaAgenda.Visible = false;
                    btnReserva.Enabled = false;

                }
                else
                {
                    tblEliminar.DataSource = null;
                    tblModificar.DataSource = null;
                    tblAgenda.DataSource = null;
                    lblAlertaAgenda.Visible = true;
                    btnReserva.Enabled = true;
                }

                gboxReservas.Enabled = true;
            }
            else
            {
                lblAlerta.Visible = true;
                gboxReservas.Enabled = false;
                tblPaciente.DataSource = null;
            }
        }

        private void tclAgenda_Click(object sender, EventArgs e)
        {
            //PARA KE AUTOMATICO SE CARGUE LAS TABLAS
            XDocument doc = XDocument.Load(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Base de Datos\Citas_Clinicas.xml");
            posicion = tblPaciente.CurrentRow.Index;

            var iniciar = (from a in doc.Descendants("Citas").Elements()
                           where (string)a.Element("Nombre_Completo") == (tblPaciente[1, posicion].Value.ToString()) + " " + (tblPaciente[2, posicion].Value.ToString())
                           select a).Count();

            if (iniciar != 0)
            {
                var agendados = from c in doc.Descendants("Citas").Elements()
                                where (string)c.Element("Nombre_Completo") == (tblPaciente[1, posicion].Value.ToString()) + " " + (tblPaciente[2, posicion].Value.ToString())
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

                tblAgenda.DataSource = agendados.ToList();
                tblEliminar.DataSource = agendados.ToList();
                tblModificar.DataSource = agendados.ToList();
                lblAlertaAgenda.Visible = false;
                btnReserva.Enabled = false;
                btnReservarUrg.Enabled = false;
            }
            else
            {
                tblAgenda.DataSource = null;
                lblAlertaAgenda.Visible = true;
                btnReserva.Enabled = true;
                btnReservarUrg.Enabled = true;
            }
        }

        private void tabAgenda_Click(object sender, EventArgs e)
        {        }

        private void tblPaciente_CellClick(object sender, DataGridViewCellEventArgs e)
        {        }

        private void txtFechaCita_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void mCalCita_DateChanged(object sender, DateRangeEventArgs e)
        {
            //PARA CARGAR EL CALENDARIO
            txtFechaCita.Text = mCalCita.SelectionStart.ToLongDateString();
            day = mCalCita.SelectionStart.Day.ToString();
            month = mCalCita.SelectionStart.Month.ToString();
            year = mCalCita.SelectionStart.Year.ToString();
        }

        //UN CONTADOR DE CARGA DE REGISTRO DE PACIENTES
        public void NuCita()
        {
            XDocument doc = XDocument.Load(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Base de Datos\Citas_Clinicas.xml");
            int nuCita;
            var query = (from c in doc.Descendants("Citas").Elements()
                             select c).Count();

            nuCita = (int)query;

            txtNuCita.Text = (nuCita + 1).ToString();
            txtNuCitaUrg.Text = (nuCita + 1).ToString();
            
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            //PARA UNA RESERVA DE UNA CITA ORDINARIA 
           var docu = XElement.Load(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Base de Datos\Citas_Clinicas.xml");
           
           posicion = tblPaciente.CurrentRow.Index; 

           if (tblPaciente.DataSource != null)
               {
                   
                   if (docu != null)
                   {
                       var cita = new XElement("Cita",
                           new XElement("NuCita", txtNuCita.Text),
                           new XElement("Nombre_Completo", (tblPaciente[1, posicion].Value.ToString()) + " " + (tblPaciente[2, posicion].Value.ToString())),
                           new XElement("Carnet", tblPaciente[4, posicion].Value.ToString()),
                           new XElement("Day", day),
                           new XElement("Month", month),
                           new XElement("Year", year),
                           new XElement("Fecha", txtFechaCita.Text),
                           new XElement("Hora", cboxHora.SelectedItem),
                           new XElement("Especialidad", cboxEspecialidad.SelectedItem),
                           new XElement("Tipo", cboxTipo.SelectedItem),
                           new XElement("Observaciones", tblPaciente[8, posicion].Value.ToString()),
                           new XElement("Caracteristica", "")
                           );

                       docu.Add(cita);
                       docu.Save(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Base de Datos\Citas_Clinicas.xml");
                       MessageBox.Show("Se logro reservar una cita\n      EXITOSAMENTE", "FELICIDADES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   }
                   else
                       MessageBox.Show("Se produjo un error al guardar la cita medica", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
               else
               {
                   MessageBox.Show("No se logro capturar los datos necesarios del paciente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
           tabAgenda.Refresh();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        //BUSCADOR PARA ELIMINAR UNA CITA MEDICA
        private void btnBuscarEliminar_Click(object sender, EventArgs e)
        {
            XDocument doc = XDocument.Load(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Base de Datos\Citas_Clinicas.xml");

            var query = from c in doc.Descendants("Citas").Elements()
                           where (string)c.Element("Nombre_Completo") == txtEliminar.Text
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

            tblEliminar.DataSource = query.ToList();
        }
        //ELIMINA UNA CITA MEDICA
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            XDocument doc = XDocument.Load(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Base de Datos\Citas_Clinicas.xml");

            var pas = (from c in doc.Descendants("Citas").Elements()
                       where (string)c.Element("Nombre_Completo") == txtEliminar.Text
                       select c).Count();
            if (pas != 0)
            {
                var eliminar = from c in doc.Descendants("Citas").Elements()
                               where (string)c.Element("Nombre_Completo") == txtEliminar.Text
                               select c;

                eliminar.Remove();
                doc.Save(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Base de Datos\Citas_Clinicas.xml");
                MessageBox.Show("La cita médica se elimino exitosamente", "ELIMINCAIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                tblEliminar.DataSource = null;
                btnReserva.Enabled = true;
                btnReservarUrg.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se encontro al paciente registrado en la Agenda", "ERROR AL ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Error);   
            }

        }
        //VACIA EL TEXTBOX Y EL DATAGRIEDIEW
        private void btnCancelar1_Click(object sender, EventArgs e)
        {
            txtEliminar.Text = "";
            tblEliminar.DataSource = null;
        }

        private void tabEliminar_Click(object sender, EventArgs e)
        {        }
        private void txtFechaCitaUrg_TextChanged(object sender, EventArgs e)
        {
        }

        //CARGAR LA FECHA PARA LA RESERVA
        private void mcalCitaUrg_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtFechaCitaUrg.Text = mcalCitaUrg.SelectionStart.ToLongDateString();
            day = mcalCitaUrg.SelectionStart.Day.ToString();
            month = mcalCitaUrg.SelectionStart.Month.ToString();
            year = mcalCitaUrg.SelectionStart.Year.ToString();
        }
        //CREAR UNA RESERVA URGENTE
        private void btnReservarUrg_Click(object sender, EventArgs e)
        {
            var docu = XElement.Load(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Base de Datos\Citas_Clinicas.xml");

            posicion = tblPaciente.CurrentRow.Index;

            if (tblPaciente.DataSource != null)
            {
                nu = txtNuCitaUrg.Text;

                if (docu != null)
                {
                    var cita = new XElement("Cita",
                        new XElement("NuCita", nu + "  [U]"),
                        new XElement("Nombre_Completo", (tblPaciente[1, posicion].Value.ToString()) + " " + (tblPaciente[2, posicion].Value.ToString())),
                        new XElement("Carnet", tblPaciente[4, posicion].Value.ToString()),
                        new XElement("Day", day),
                        new XElement("Month", month),
                        new XElement("Year", year),
                        new XElement("Fecha", txtFechaCitaUrg.Text),
                        new XElement("Hora", cboxHoraUrg.SelectedItem),
                        new XElement("Especialidad", cboxEspecialidadUrg.SelectedItem),
                        new XElement("Tipo", cboxTipoUrg.SelectedItem),
                        new XElement("Observaciones", tblPaciente[8, posicion].Value.ToString()),
                        new XElement("Caracteristica", txtUrgente.Text)
                        );

                    docu.Add(cita);
                    docu.Save(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Base de Datos\Citas_Clinicas.xml");
                    MessageBox.Show("Se logro reservar una cita\n      EXITOSAMENTE", "FELICIDADES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Se produjo un error al guardar la cita medica", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("No se logro capturar los datos necesarios del paciente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tabAgenda.Refresh();
        }
        //CARGAR NOMBRE COMPLETO EN EL TEXTBOX
        private void tblEliminar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = tblEliminar.CurrentRow.Index;
            txtEliminar.Text = tblEliminar[1, posicion].Value.ToString();
        }
        //NO IMPORTA
        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
        private void txtEliminar_TextChanged(object sender, EventArgs e)
        {

        }
        private void tblEliminar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //BUSCAR UNA CITA MEDICA PARA MODIFICAR
        private void btnBuscarModificar_Click(object sender, EventArgs e)
        {
            XDocument doc = XDocument.Load(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Base de Datos\Citas_Clinicas.xml");

            var query = from c in doc.Descendants("Citas").Elements()
                        where (string)c.Element("Nombre_Completo") == txtModificar.Text
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

            tblModificar.DataSource = query.ToList();
            
        }
        //VACIAR EL DATAGRIEDIEW
        private void btnCancelar2_Click(object sender, EventArgs e)
        {
            tblModificar.DataSource = null;
        }
        //PARA ESCRIBIR EL NOMBRE AUTOMATICO EN TEXTBOX
        private void tblModificar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = tblModificar.CurrentRow.Index;
            txtModificar.Text = tblModificar[1, posicion].Value.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            posicion = tblModificar.CurrentRow.Index;
            XDocument doc = XDocument.Load(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Base de Datos\Citas_Clinicas.xml");

            var pas = (from c in doc.Descendants("Citas").Elements()
                       where (string)c.Element("Nombre_Completo") == txtModificar.Text
                       select c).Count();

            //DATOS DE COMPLEMENTACION PARA LA MODIFICACION
            nombreCompleto = tblModificar[1, posicion].Value.ToString();
            carnet = tblModificar[2, posicion].Value.ToString();
            observaciones = tblModificar[7, posicion].Value.ToString();

            //RESERVAR NORMAL
            txtFechaCita.Text = tblModificar[3, posicion].Value.ToString();
            txtNuCita.Text = tblModificar[0, posicion].Value.ToString();
            cboxEspecialidad.Text = tblModificar[5, posicion].Value.ToString();
            cboxTipo.Text = tblModificar[6, posicion].Value.ToString();
            cboxHora.Text = tblModificar[4, posicion].Value.ToString();

            //RESERVA URGENTE
            txtFechaCitaUrg.Text = tblModificar[3, posicion].Value.ToString();
            txtNuCitaUrg.Text = tblModificar[0, posicion].Value.ToString();
            cboxEspecialidadUrg.Text = tblModificar[5, posicion].Value.ToString();
            cboxTipoUrg.Text = tblModificar[6, posicion].Value.ToString();
            cboxHoraUrg.Text = tblModificar[4, posicion].Value.ToString();

            //ELIMINAR Y LUEGO MODIFCAR
            if (pas != 0)
            {
                var eliminar = from c in doc.Descendants("Citas").Elements()
                               where (string)c.Element("Nombre_Completo") == txtModificar.Text
                               select c;

                eliminar.Remove();
                doc.Save(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Base de Datos\Citas_Clinicas.xml");
                tblEliminar.DataSource = null;
                btnReserva.Enabled = true;
                btnReservarUrg.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se encontro al paciente registrado en la Agenda", "ERROR AL ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //IR A RESERVA NORMAL
            tabNuevo.Show();
            btnGuardarUrgente.Visible = true;
            btnGuardar.Visible = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var doc = XElement.Load(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Base de Datos\Citas_Clinicas.xml");
            
            if (tblModificar.DataSource != null)
            {

                if (doc != null)
                {
                        var newCita = new XElement("Cita",
                                    new XElement("NuCita", txtNuCita.Text),
                                    new XElement("Nombre_Completo", nombreCompleto),
                                    new XElement("Carnet", carnet),
                                    new XElement("Day", day),
                                    new XElement("Month", month),
                                    new XElement("Year", year),
                                    new XElement("Fecha", txtFechaCita.Text),
                                    new XElement("Hora", cboxHora.SelectedItem),
                                    new XElement("Especialidad", cboxEspecialidad.SelectedItem),
                                    new XElement("Tipo", cboxTipo.SelectedItem),
                                    new XElement("Observaciones", observaciones),
                                    new XElement("Caracteristica", "")
                                    );

                        doc.Add(newCita);
                        doc.Save(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Base de Datos\Citas_Clinicas.xml");
                        MessageBox.Show("Se logro modificar la cita medica del paciente\n\t   EXITOSAMENTE", "FELICIDADES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnGuardar.Visible = false;
                        btnGuardarUrgente.Visible = false;
                        btnReserva.Enabled = false;
                        btnReservarUrg.Enabled = false;
                }
                else
                    MessageBox.Show("Se produjo un error al guardar la cita medica", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("No se logro capturar los datos necesarios del paciente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            tabAgenda.Refresh();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarUrgente_Click(object sender, EventArgs e)
        {
            var doc = XElement.Load(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Base de Datos\Citas_Clinicas.xml");

            if (tblModificar.DataSource != null)
            {

                if (doc != null)
                {
                    var newCita = new XElement("Cita",
                                new XElement("NuCita", txtNuCitaUrg.Text + " [U]"),
                                new XElement("Nombre_Completo", nombreCompleto),
                                new XElement("Carnet", carnet),
                                new XElement("Day", day),
                                new XElement("Month", month),
                                new XElement("Year", year),
                                new XElement("Fecha", txtFechaCitaUrg.Text),
                                new XElement("Hora", cboxHoraUrg.SelectedItem),
                                new XElement("Especialidad", cboxEspecialidadUrg.SelectedItem),
                                new XElement("Tipo", cboxTipoUrg.SelectedItem),
                                new XElement("Observaciones", observaciones),
                                new XElement("Caracteristica", txtUrgente.Text)
                                );

                    doc.Add(newCita);
                    doc.Save(@"F:\5 Semestre\Estructura de Datos II\Proyecto de Consultorio Dental\Consultorio Dental\Consultorio Dental\Base de Datos\Citas_Clinicas.xml");
                    MessageBox.Show("Se logro modificar la cita medica del paciente\n\t   EXITOSAMENTE", "FELICIDADES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnGuardar.Visible = false;
                    btnGuardarUrgente.Visible = false;
                    btnReserva.Enabled = false;
                    btnReservarUrg.Enabled = false;
                }
                else
                    MessageBox.Show("Se produjo un error al guardar la cita medica", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("No se logro capturar los datos necesarios del paciente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            tabAgenda.Refresh();
        }
     }
}