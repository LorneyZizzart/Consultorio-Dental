namespace Consultorio_Dental
{
    partial class frmBuscar
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label n__DE_CARNETLabel;
            System.Windows.Forms.Label nOMBRELabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscar));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAviso = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalVarones = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalMujeres = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalPacientes = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAlertaCarnet = new System.Windows.Forms.Label();
            this.lblAlerta = new System.Windows.Forms.Label();
            this.tblPaciente = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarNombre = new System.Windows.Forms.Button();
            this.btnBuscarCarnet = new System.Windows.Forms.Button();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baseDeDatos = new Consultorio_Dental.Base_de_Datos.BaseDeDatos();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSalir = new System.Windows.Forms.Label();
            this.lblModificar = new System.Windows.Forms.Label();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.lblAgenda = new System.Windows.Forms.Label();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblIncio = new System.Windows.Forms.Label();
            this.btnBuscarSalir = new System.Windows.Forms.Button();
            this.btnBuscarModificar = new System.Windows.Forms.Button();
            this.btnBuscarPacientes = new System.Windows.Forms.Button();
            this.btnBuscarAgenda = new System.Windows.Forms.Button();
            this.btnBuscarRegistro = new System.Windows.Forms.Button();
            this.btnBuscarBuscar = new System.Windows.Forms.Button();
            this.btnBuscarInicio = new System.Windows.Forms.Button();
            n__DE_CARNETLabel = new System.Windows.Forms.Label();
            nOMBRELabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPaciente)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDeDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // n__DE_CARNETLabel
            // 
            n__DE_CARNETLabel.AutoSize = true;
            n__DE_CARNETLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            n__DE_CARNETLabel.Location = new System.Drawing.Point(22, 30);
            n__DE_CARNETLabel.Name = "n__DE_CARNETLabel";
            n__DE_CARNETLabel.Size = new System.Drawing.Size(102, 16);
            n__DE_CARNETLabel.TabIndex = 1;
            n__DE_CARNETLabel.Text = "N° DE CARNET:";
            // 
            // nOMBRELabel
            // 
            nOMBRELabel.AutoSize = true;
            nOMBRELabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nOMBRELabel.Location = new System.Drawing.Point(52, 76);
            nOMBRELabel.Name = "nOMBRELabel";
            nOMBRELabel.Size = new System.Drawing.Size(68, 16);
            nOMBRELabel.TabIndex = 3;
            nOMBRELabel.Text = "NOMBRE:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.lblAviso);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblTotalVarones);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblTotalMujeres);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblTotalPacientes);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lblAlertaCarnet);
            this.panel2.Controls.Add(this.lblAlerta);
            this.panel2.Controls.Add(this.tblPaciente);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Location = new System.Drawing.Point(161, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 464);
            this.panel2.TabIndex = 5;
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Location = new System.Drawing.Point(108, 438);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(49, 13);
            this.lblAviso.TabIndex = 56;
            this.lblAviso.Text = "..............";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 14);
            this.label4.TabIndex = 55;
            this.label4.Text = "Nombre completo:";
            // 
            // lblTotalVarones
            // 
            this.lblTotalVarones.AutoSize = true;
            this.lblTotalVarones.Location = new System.Drawing.Point(511, 437);
            this.lblTotalVarones.Name = "lblTotalVarones";
            this.lblTotalVarones.Size = new System.Drawing.Size(15, 13);
            this.lblTotalVarones.TabIndex = 54;
            this.lblTotalVarones.Text = "la";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(459, 437);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 14);
            this.label5.TabIndex = 53;
            this.label5.Text = "Varones:";
            // 
            // lblTotalMujeres
            // 
            this.lblTotalMujeres.AutoSize = true;
            this.lblTotalMujeres.Location = new System.Drawing.Point(576, 437);
            this.lblTotalMujeres.Name = "lblTotalMujeres";
            this.lblTotalMujeres.Size = new System.Drawing.Size(15, 13);
            this.lblTotalMujeres.TabIndex = 52;
            this.lblTotalMujeres.Text = "la";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(524, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 14);
            this.label3.TabIndex = 51;
            this.label3.Text = "Mujeres:";
            // 
            // lblTotalPacientes
            // 
            this.lblTotalPacientes.AutoSize = true;
            this.lblTotalPacientes.Location = new System.Drawing.Point(407, 437);
            this.lblTotalPacientes.Name = "lblTotalPacientes";
            this.lblTotalPacientes.Size = new System.Drawing.Size(35, 13);
            this.lblTotalPacientes.TabIndex = 50;
            this.lblTotalPacientes.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(301, 437);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 14);
            this.label8.TabIndex = 49;
            this.label8.Text = "Total de Pacientes:";
            // 
            // lblAlertaCarnet
            // 
            this.lblAlertaCarnet.AutoSize = true;
            this.lblAlertaCarnet.BackColor = System.Drawing.Color.DarkGray;
            this.lblAlertaCarnet.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlertaCarnet.ForeColor = System.Drawing.Color.Red;
            this.lblAlertaCarnet.Location = new System.Drawing.Point(89, 262);
            this.lblAlertaCarnet.Name = "lblAlertaCarnet";
            this.lblAlertaCarnet.Size = new System.Drawing.Size(416, 74);
            this.lblAlertaCarnet.TabIndex = 46;
            this.lblAlertaCarnet.Text = "   No se encontro ningun \r\npaciente con ese CARNET";
            // 
            // lblAlerta
            // 
            this.lblAlerta.AutoSize = true;
            this.lblAlerta.BackColor = System.Drawing.Color.DarkGray;
            this.lblAlerta.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlerta.ForeColor = System.Drawing.Color.Red;
            this.lblAlerta.Location = new System.Drawing.Point(89, 263);
            this.lblAlerta.Name = "lblAlerta";
            this.lblAlerta.Size = new System.Drawing.Size(423, 74);
            this.lblAlerta.TabIndex = 45;
            this.lblAlerta.Text = "   No se encontro ningun \r\npaciente con ese NOMBRE";
            // 
            // tblPaciente
            // 
            this.tblPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblPaciente.Location = new System.Drawing.Point(3, 185);
            this.tblPaciente.Name = "tblPaciente";
            this.tblPaciente.Size = new System.Drawing.Size(590, 240);
            this.tblPaciente.TabIndex = 44;
            this.tblPaciente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblPaciente_CellClick);
            this.tblPaciente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblPaciente_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarNombre);
            this.groupBox1.Controls.Add(this.btnBuscarCarnet);
            this.groupBox1.Controls.Add(this.txtCarnet);
            this.groupBox1.Controls.Add(nOMBRELabel);
            this.groupBox1.Controls.Add(n__DE_CARNETLabel);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 112);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Pacientes por :";
            // 
            // btnBuscarNombre
            // 
            this.btnBuscarNombre.Image = global::Consultorio_Dental.Properties.Resources.buscar3;
            this.btnBuscarNombre.Location = new System.Drawing.Point(307, 67);
            this.btnBuscarNombre.Name = "btnBuscarNombre";
            this.btnBuscarNombre.Size = new System.Drawing.Size(35, 34);
            this.btnBuscarNombre.TabIndex = 6;
            this.btnBuscarNombre.UseVisualStyleBackColor = true;
            this.btnBuscarNombre.Click += new System.EventHandler(this.btnBuscarNombre_Click);
            // 
            // btnBuscarCarnet
            // 
            this.btnBuscarCarnet.Image = global::Consultorio_Dental.Properties.Resources.buscar3;
            this.btnBuscarCarnet.Location = new System.Drawing.Point(307, 21);
            this.btnBuscarCarnet.Name = "btnBuscarCarnet";
            this.btnBuscarCarnet.Size = new System.Drawing.Size(35, 34);
            this.btnBuscarCarnet.TabIndex = 5;
            this.btnBuscarCarnet.UseVisualStyleBackColor = true;
            this.btnBuscarCarnet.Click += new System.EventHandler(this.btnBuscarCarnet_Click);
            // 
            // txtCarnet
            // 
            this.txtCarnet.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "N°_DE_CARNET", true));
            this.txtCarnet.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarnet.Location = new System.Drawing.Point(126, 27);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(175, 22);
            this.txtCarnet.TabIndex = 2;
            this.txtCarnet.TextChanged += new System.EventHandler(this.txtCarnet_TextChanged);
            // 
            // pacienteBindingSource
            // 
            this.pacienteBindingSource.DataMember = "Paciente";
            this.pacienteBindingSource.DataSource = this.baseDeDatos;
            // 
            // baseDeDatos
            // 
            this.baseDeDatos.DataSetName = "BaseDeDatos";
            this.baseDeDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "NOMBRE", true));
            this.txtNombre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(126, 73);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(175, 22);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Consultorio_Dental.Properties.Resources.ico1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 65);
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "BUSCAR PACIENTES REGISTRADOS";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::Consultorio_Dental.Properties.Resources.modificarBus;
            this.btnBuscar.Location = new System.Drawing.Point(383, 65);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(101, 109);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::Consultorio_Dental.Properties.Resources.eliminarBus;
            this.btnEliminar.Location = new System.Drawing.Point(490, 68);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(90, 102);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.panel1.Controls.Add(this.btnBuscarSalir);
            this.panel1.Controls.Add(this.btnBuscarModificar);
            this.panel1.Controls.Add(this.btnBuscarPacientes);
            this.panel1.Controls.Add(this.btnBuscarAgenda);
            this.panel1.Controls.Add(this.btnBuscarRegistro);
            this.panel1.Controls.Add(this.btnBuscarBuscar);
            this.panel1.Controls.Add(this.btnBuscarInicio);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 464);
            this.panel1.TabIndex = 4;
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
            this.lblPaciente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaciente.Location = new System.Drawing.Point(67, 290);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(80, 16);
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
            this.lblBuscar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBuscar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.Color.Red;
            this.lblBuscar.Location = new System.Drawing.Point(67, 92);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(64, 18);
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
            // btnBuscarSalir
            // 
            this.btnBuscarSalir.Image = global::Consultorio_Dental.Properties.Resources.salirUsu;
            this.btnBuscarSalir.Location = new System.Drawing.Point(4, 400);
            this.btnBuscarSalir.Name = "btnBuscarSalir";
            this.btnBuscarSalir.Size = new System.Drawing.Size(63, 60);
            this.btnBuscarSalir.TabIndex = 2;
            this.btnBuscarSalir.UseVisualStyleBackColor = true;
            this.btnBuscarSalir.Click += new System.EventHandler(this.btnBuscarSalir_Click);
            // 
            // btnBuscarModificar
            // 
            this.btnBuscarModificar.Image = global::Consultorio_Dental.Properties.Resources.modificarUsu;
            this.btnBuscarModificar.Location = new System.Drawing.Point(4, 334);
            this.btnBuscarModificar.Name = "btnBuscarModificar";
            this.btnBuscarModificar.Size = new System.Drawing.Size(63, 60);
            this.btnBuscarModificar.TabIndex = 5;
            this.btnBuscarModificar.UseVisualStyleBackColor = true;
            this.btnBuscarModificar.Click += new System.EventHandler(this.btnBuscarModificar_Click);
            // 
            // btnBuscarPacientes
            // 
            this.btnBuscarPacientes.Image = global::Consultorio_Dental.Properties.Resources.pacientesUsu;
            this.btnBuscarPacientes.Location = new System.Drawing.Point(4, 268);
            this.btnBuscarPacientes.Name = "btnBuscarPacientes";
            this.btnBuscarPacientes.Size = new System.Drawing.Size(63, 60);
            this.btnBuscarPacientes.TabIndex = 4;
            this.btnBuscarPacientes.UseVisualStyleBackColor = true;
            this.btnBuscarPacientes.Click += new System.EventHandler(this.btnBuscarPacientes_Click);
            // 
            // btnBuscarAgenda
            // 
            this.btnBuscarAgenda.Image = global::Consultorio_Dental.Properties.Resources.agendaUsu;
            this.btnBuscarAgenda.Location = new System.Drawing.Point(4, 202);
            this.btnBuscarAgenda.Name = "btnBuscarAgenda";
            this.btnBuscarAgenda.Size = new System.Drawing.Size(63, 60);
            this.btnBuscarAgenda.TabIndex = 3;
            this.btnBuscarAgenda.UseVisualStyleBackColor = true;
            this.btnBuscarAgenda.Click += new System.EventHandler(this.btnBuscarAgenda_Click);
            // 
            // btnBuscarRegistro
            // 
            this.btnBuscarRegistro.Image = global::Consultorio_Dental.Properties.Resources.registroUsu;
            this.btnBuscarRegistro.Location = new System.Drawing.Point(4, 136);
            this.btnBuscarRegistro.Name = "btnBuscarRegistro";
            this.btnBuscarRegistro.Size = new System.Drawing.Size(63, 60);
            this.btnBuscarRegistro.TabIndex = 2;
            this.btnBuscarRegistro.UseVisualStyleBackColor = true;
            this.btnBuscarRegistro.Click += new System.EventHandler(this.btnBuscarRegistro_Click);
            // 
            // btnBuscarBuscar
            // 
            this.btnBuscarBuscar.Image = global::Consultorio_Dental.Properties.Resources.buscar;
            this.btnBuscarBuscar.Location = new System.Drawing.Point(4, 70);
            this.btnBuscarBuscar.Name = "btnBuscarBuscar";
            this.btnBuscarBuscar.Size = new System.Drawing.Size(63, 60);
            this.btnBuscarBuscar.TabIndex = 1;
            this.btnBuscarBuscar.UseVisualStyleBackColor = true;
            this.btnBuscarBuscar.Click += new System.EventHandler(this.btnBuscarBuscar_Click);
            // 
            // btnBuscarInicio
            // 
            this.btnBuscarInicio.Image = global::Consultorio_Dental.Properties.Resources.homeUsu;
            this.btnBuscarInicio.Location = new System.Drawing.Point(4, 4);
            this.btnBuscarInicio.Name = "btnBuscarInicio";
            this.btnBuscarInicio.Size = new System.Drawing.Size(63, 60);
            this.btnBuscarInicio.TabIndex = 0;
            this.btnBuscarInicio.UseVisualStyleBackColor = true;
            this.btnBuscarInicio.Click += new System.EventHandler(this.btnBuscarInicio_Click);
            // 
            // frmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(764, 479);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmBuscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPaciente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDeDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button btnBuscarSalir;
        private System.Windows.Forms.Button btnBuscarModificar;
        private System.Windows.Forms.Button btnBuscarPacientes;
        private System.Windows.Forms.Button btnBuscarAgenda;
        private System.Windows.Forms.Button btnBuscarRegistro;
        private System.Windows.Forms.Button btnBuscarBuscar;
        private System.Windows.Forms.Button btnBuscarInicio;
        private System.Windows.Forms.BindingSource pacienteBindingSource;
        private Base_de_Datos.BaseDeDatos baseDeDatos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarNombre;
        private System.Windows.Forms.Button btnBuscarCarnet;
        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView tblPaciente;
        private System.Windows.Forms.Label lblAlerta;
        private System.Windows.Forms.Label lblAlertaCarnet;
        private System.Windows.Forms.Label lblTotalVarones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalMujeres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalPacientes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Label label4;
    }
}