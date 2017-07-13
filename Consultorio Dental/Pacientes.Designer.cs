namespace Consultorio_Dental
{
    partial class frmPacientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPacientes));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNuCitaOrdinaria = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblNuCitaUrgente = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboxTipo = new System.Windows.Forms.ComboBox();
            this.cboxMonth = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mCalSearch = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.tblPaciente = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSalir = new System.Windows.Forms.Label();
            this.lblModificar = new System.Windows.Forms.Label();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.lblAgenda = new System.Windows.Forms.Label();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblIncio = new System.Windows.Forms.Label();
            this.btnPacientesSalir = new System.Windows.Forms.Button();
            this.btnPacientesModificar = new System.Windows.Forms.Button();
            this.btnPacientesPacientes = new System.Windows.Forms.Button();
            this.btnPacientesAgenda = new System.Windows.Forms.Button();
            this.btnPacientesRegistro = new System.Windows.Forms.Button();
            this.btnPacientesBuscar = new System.Windows.Forms.Button();
            this.btnPacientesInicio = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPaciente)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.lblNuCitaOrdinaria);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lblNuCitaUrgente);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.tblPaciente);
            this.panel2.Location = new System.Drawing.Point(161, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 464);
            this.panel2.TabIndex = 7;
            // 
            // lblNuCitaOrdinaria
            // 
            this.lblNuCitaOrdinaria.AutoSize = true;
            this.lblNuCitaOrdinaria.Location = new System.Drawing.Point(555, 438);
            this.lblNuCitaOrdinaria.Name = "lblNuCitaOrdinaria";
            this.lblNuCitaOrdinaria.Size = new System.Drawing.Size(35, 13);
            this.lblNuCitaOrdinaria.TabIndex = 48;
            this.lblNuCitaOrdinaria.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(416, 438);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 14);
            this.label8.TabIndex = 47;
            this.label8.Text = "Total de Citas Ordinarias:";
            // 
            // lblNuCitaUrgente
            // 
            this.lblNuCitaUrgente.AutoSize = true;
            this.lblNuCitaUrgente.Location = new System.Drawing.Point(139, 438);
            this.lblNuCitaUrgente.Name = "lblNuCitaUrgente";
            this.lblNuCitaUrgente.Size = new System.Drawing.Size(35, 13);
            this.lblNuCitaUrgente.TabIndex = 46;
            this.lblNuCitaUrgente.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 438);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 14);
            this.label5.TabIndex = 45;
            this.label5.Text = "Total de Citas Urgente:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Consultorio_Dental.Properties.Resources.ico1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 64);
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.mCalSearch);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(13, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(570, 168);
            this.panel3.TabIndex = 44;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.cboxTipo);
            this.groupBox1.Controls.Add(this.cboxMonth);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 93);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar pacientes por:";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::Consultorio_Dental.Properties.Resources.busPaciente;
            this.btnSearch.Location = new System.Drawing.Point(227, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(65, 76);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboxTipo
            // 
            this.cboxTipo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxTipo.FormattingEnabled = true;
            this.cboxTipo.Items.AddRange(new object[] {
            "Cita Urgente",
            "Cita Ordinaria"});
            this.cboxTipo.Location = new System.Drawing.Point(77, 57);
            this.cboxTipo.Name = "cboxTipo";
            this.cboxTipo.Size = new System.Drawing.Size(133, 24);
            this.cboxTipo.TabIndex = 3;
            this.cboxTipo.SelectedIndexChanged += new System.EventHandler(this.cboxTipo_SelectedIndexChanged);
            this.cboxTipo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cboxTipo_MouseClick);
            // 
            // cboxMonth
            // 
            this.cboxMonth.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxMonth.FormattingEnabled = true;
            this.cboxMonth.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cboxMonth.Location = new System.Drawing.Point(77, 18);
            this.cboxMonth.Name = "cboxMonth";
            this.cboxMonth.Size = new System.Drawing.Size(133, 24);
            this.cboxMonth.TabIndex = 2;
            this.cboxMonth.SelectedIndexChanged += new System.EventHandler(this.cboxMonth_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "TIPO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "MES:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 32);
            this.label2.TabIndex = 45;
            this.label2.Text = "PACIENTES";
            // 
            // mCalSearch
            // 
            this.mCalSearch.Location = new System.Drawing.Point(313, 9);
            this.mCalSearch.Name = "mCalSearch";
            this.mCalSearch.TabIndex = 46;
            this.mCalSearch.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mCalSearch_DateChanged);
            this.mCalSearch.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mCalSearch_DateSelected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "CITAS MEDICAS DE";
            // 
            // tblPaciente
            // 
            this.tblPaciente.AllowUserToOrderColumns = true;
            this.tblPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblPaciente.Location = new System.Drawing.Point(3, 202);
            this.tblPaciente.Name = "tblPaciente";
            this.tblPaciente.Size = new System.Drawing.Size(588, 224);
            this.tblPaciente.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.lblSalir);
            this.panel1.Controls.Add(this.lblModificar);
            this.panel1.Controls.Add(this.lblPaciente);
            this.panel1.Controls.Add(this.lblAgenda);
            this.panel1.Controls.Add(this.lblRegistro);
            this.panel1.Controls.Add(this.lblBuscar);
            this.panel1.Controls.Add(this.lblIncio);
            this.panel1.Controls.Add(this.btnPacientesSalir);
            this.panel1.Controls.Add(this.btnPacientesModificar);
            this.panel1.Controls.Add(this.btnPacientesPacientes);
            this.panel1.Controls.Add(this.btnPacientesAgenda);
            this.panel1.Controls.Add(this.btnPacientesRegistro);
            this.panel1.Controls.Add(this.btnPacientesBuscar);
            this.panel1.Controls.Add(this.btnPacientesInicio);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 464);
            this.panel1.TabIndex = 5;
            // 
            // lblSalir
            // 
            this.lblSalir.AutoSize = true;
            this.lblSalir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalir.Location = new System.Drawing.Point(67, 422);
            this.lblSalir.Name = "lblSalir";
            this.lblSalir.Size = new System.Drawing.Size(47, 16);
            this.lblSalir.TabIndex = 12;
            this.lblSalir.Text = "SALIR";
            // 
            // lblModificar
            // 
            this.lblModificar.AutoSize = true;
            this.lblModificar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificar.Location = new System.Drawing.Point(67, 356);
            this.lblModificar.Name = "lblModificar";
            this.lblModificar.Size = new System.Drawing.Size(81, 16);
            this.lblModificar.TabIndex = 11;
            this.lblModificar.Text = "MODIFICAR";
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPaciente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaciente.ForeColor = System.Drawing.Color.Red;
            this.lblPaciente.Location = new System.Drawing.Point(67, 290);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(82, 18);
            this.lblPaciente.TabIndex = 10;
            this.lblPaciente.Text = "PACIENTES";
            // 
            // lblAgenda
            // 
            this.lblAgenda.AutoSize = true;
            this.lblAgenda.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgenda.Location = new System.Drawing.Point(67, 224);
            this.lblAgenda.Name = "lblAgenda";
            this.lblAgenda.Size = new System.Drawing.Size(62, 16);
            this.lblAgenda.TabIndex = 9;
            this.lblAgenda.Text = "AGENDA";
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.Location = new System.Drawing.Point(67, 158);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(75, 16);
            this.lblRegistro.TabIndex = 8;
            this.lblRegistro.Text = "REGISTRO";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(67, 92);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(62, 16);
            this.lblBuscar.TabIndex = 7;
            this.lblBuscar.Text = "BUSCAR";
            // 
            // lblIncio
            // 
            this.lblIncio.AutoSize = true;
            this.lblIncio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncio.ForeColor = System.Drawing.Color.Black;
            this.lblIncio.Location = new System.Drawing.Point(67, 28);
            this.lblIncio.Name = "lblIncio";
            this.lblIncio.Size = new System.Drawing.Size(57, 19);
            this.lblIncio.TabIndex = 6;
            this.lblIncio.Text = "INICIO";
            // 
            // btnPacientesSalir
            // 
            this.btnPacientesSalir.Image = global::Consultorio_Dental.Properties.Resources.salirUsu;
            this.btnPacientesSalir.Location = new System.Drawing.Point(4, 400);
            this.btnPacientesSalir.Name = "btnPacientesSalir";
            this.btnPacientesSalir.Size = new System.Drawing.Size(63, 60);
            this.btnPacientesSalir.TabIndex = 2;
            this.btnPacientesSalir.UseVisualStyleBackColor = true;
            this.btnPacientesSalir.Click += new System.EventHandler(this.btnPacientesSalir_Click);
            // 
            // btnPacientesModificar
            // 
            this.btnPacientesModificar.Image = global::Consultorio_Dental.Properties.Resources.modificarUsu;
            this.btnPacientesModificar.Location = new System.Drawing.Point(4, 334);
            this.btnPacientesModificar.Name = "btnPacientesModificar";
            this.btnPacientesModificar.Size = new System.Drawing.Size(63, 60);
            this.btnPacientesModificar.TabIndex = 5;
            this.btnPacientesModificar.UseVisualStyleBackColor = true;
            this.btnPacientesModificar.Click += new System.EventHandler(this.btnPacientesModificar_Click);
            // 
            // btnPacientesPacientes
            // 
            this.btnPacientesPacientes.Image = global::Consultorio_Dental.Properties.Resources.pacientesUsu;
            this.btnPacientesPacientes.Location = new System.Drawing.Point(4, 268);
            this.btnPacientesPacientes.Name = "btnPacientesPacientes";
            this.btnPacientesPacientes.Size = new System.Drawing.Size(63, 60);
            this.btnPacientesPacientes.TabIndex = 4;
            this.btnPacientesPacientes.UseVisualStyleBackColor = true;
            this.btnPacientesPacientes.Click += new System.EventHandler(this.btnPacientesPacientes_Click);
            // 
            // btnPacientesAgenda
            // 
            this.btnPacientesAgenda.Image = global::Consultorio_Dental.Properties.Resources.agendaUsu;
            this.btnPacientesAgenda.Location = new System.Drawing.Point(4, 202);
            this.btnPacientesAgenda.Name = "btnPacientesAgenda";
            this.btnPacientesAgenda.Size = new System.Drawing.Size(63, 60);
            this.btnPacientesAgenda.TabIndex = 3;
            this.btnPacientesAgenda.UseVisualStyleBackColor = true;
            this.btnPacientesAgenda.Click += new System.EventHandler(this.btnPacientesAgenda_Click);
            // 
            // btnPacientesRegistro
            // 
            this.btnPacientesRegistro.Image = global::Consultorio_Dental.Properties.Resources.registroUsu;
            this.btnPacientesRegistro.Location = new System.Drawing.Point(4, 136);
            this.btnPacientesRegistro.Name = "btnPacientesRegistro";
            this.btnPacientesRegistro.Size = new System.Drawing.Size(63, 60);
            this.btnPacientesRegistro.TabIndex = 2;
            this.btnPacientesRegistro.UseVisualStyleBackColor = true;
            this.btnPacientesRegistro.Click += new System.EventHandler(this.btnPacientesRegistro_Click);
            // 
            // btnPacientesBuscar
            // 
            this.btnPacientesBuscar.Image = global::Consultorio_Dental.Properties.Resources.buscar;
            this.btnPacientesBuscar.Location = new System.Drawing.Point(4, 70);
            this.btnPacientesBuscar.Name = "btnPacientesBuscar";
            this.btnPacientesBuscar.Size = new System.Drawing.Size(63, 60);
            this.btnPacientesBuscar.TabIndex = 1;
            this.btnPacientesBuscar.UseVisualStyleBackColor = true;
            this.btnPacientesBuscar.Click += new System.EventHandler(this.btnPacientesBuscar_Click);
            // 
            // btnPacientesInicio
            // 
            this.btnPacientesInicio.Image = global::Consultorio_Dental.Properties.Resources.homeUsu;
            this.btnPacientesInicio.Location = new System.Drawing.Point(4, 4);
            this.btnPacientesInicio.Name = "btnPacientesInicio";
            this.btnPacientesInicio.Size = new System.Drawing.Size(63, 60);
            this.btnPacientesInicio.TabIndex = 0;
            this.btnPacientesInicio.UseVisualStyleBackColor = true;
            this.btnPacientesInicio.Click += new System.EventHandler(this.btnPacientesInicio_Click);
            // 
            // frmPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(764, 481);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pacientes";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPaciente)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSalir;
        private System.Windows.Forms.Label lblModificar;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Label lblAgenda;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label lblIncio;
        private System.Windows.Forms.Button btnPacientesSalir;
        private System.Windows.Forms.Button btnPacientesModificar;
        private System.Windows.Forms.Button btnPacientesPacientes;
        private System.Windows.Forms.Button btnPacientesAgenda;
        private System.Windows.Forms.Button btnPacientesRegistro;
        private System.Windows.Forms.Button btnPacientesBuscar;
        private System.Windows.Forms.Button btnPacientesInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tblPaciente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MonthCalendar mCalSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboxMonth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboxTipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNuCitaOrdinaria;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblNuCitaUrgente;
        private System.Windows.Forms.Label label5;
    }
}