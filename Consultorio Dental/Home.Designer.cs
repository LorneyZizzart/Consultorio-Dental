namespace Consultorio_Dental
{
    partial class frmHome
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
            System.Windows.Forms.Label fOTOGRAFIALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.gboxPassword = new System.Windows.Forms.GroupBox();
            this.picturePassword = new System.Windows.Forms.PictureBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureFotografia = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSalir = new System.Windows.Forms.Label();
            this.lblModificar = new System.Windows.Forms.Label();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.lblAgenda = new System.Windows.Forms.Label();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblIncio = new System.Windows.Forms.Label();
            this.btnInicioSalir = new System.Windows.Forms.Button();
            this.btnInicioModificar = new System.Windows.Forms.Button();
            this.btnInicioPacientes = new System.Windows.Forms.Button();
            this.btnInicioAgenda = new System.Windows.Forms.Button();
            this.btnInicioRegistro = new System.Windows.Forms.Button();
            this.btnInicioBuscar = new System.Windows.Forms.Button();
            this.btnInicioInicio = new System.Windows.Forms.Button();
            fOTOGRAFIALabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.gboxPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFotografia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fOTOGRAFIALabel
            // 
            fOTOGRAFIALabel.AutoSize = true;
            fOTOGRAFIALabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fOTOGRAFIALabel.Location = new System.Drawing.Point(455, 271);
            fOTOGRAFIALabel.Name = "fOTOGRAFIALabel";
            fOTOGRAFIALabel.Size = new System.Drawing.Size(93, 16);
            fOTOGRAFIALabel.TabIndex = 20;
            fOTOGRAFIALabel.Text = "FOTOGRAFIA";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Controls.Add(this.gboxPassword);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(fOTOGRAFIALabel);
            this.panel2.Controls.Add(this.pictureFotografia);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(161, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 464);
            this.panel2.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(166, 144);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(259, 96);
            this.listBox1.TabIndex = 36;
            // 
            // gboxPassword
            // 
            this.gboxPassword.Controls.Add(this.picturePassword);
            this.gboxPassword.Controls.Add(this.btnConfirmar);
            this.gboxPassword.Controls.Add(this.txtPassword);
            this.gboxPassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxPassword.Location = new System.Drawing.Point(28, 23);
            this.gboxPassword.Name = "gboxPassword";
            this.gboxPassword.Size = new System.Drawing.Size(537, 36);
            this.gboxPassword.TabIndex = 23;
            this.gboxPassword.TabStop = false;
            this.gboxPassword.Text = " CONFIRMAR CONTRASEÑA";
            // 
            // picturePassword
            // 
            this.picturePassword.Location = new System.Drawing.Point(367, 4);
            this.picturePassword.Name = "picturePassword";
            this.picturePassword.Size = new System.Drawing.Size(16, 16);
            this.picturePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picturePassword.TabIndex = 47;
            this.picturePassword.TabStop = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(399, -1);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(102, 27);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(193, 1);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(169, 22);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(6, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 38);
            this.label1.TabIndex = 22;
            this.label1.Text = "INICIO SESIÓN LA PERSONA";
            // 
            // pictureFotografia
            // 
            this.pictureFotografia.BackgroundImage = global::Consultorio_Dental.Properties.Resources.Fotografia;
            this.pictureFotografia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureFotografia.Location = new System.Drawing.Point(430, 119);
            this.pictureFotografia.Name = "pictureFotografia";
            this.pictureFotografia.Size = new System.Drawing.Size(147, 147);
            this.pictureFotografia.TabIndex = 21;
            this.pictureFotografia.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Consultorio_Dental.Properties.Resources.INICIO;
            this.pictureBox1.Location = new System.Drawing.Point(3, 186);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(579, 275);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.panel1.Controls.Add(this.btnInicioSalir);
            this.panel1.Controls.Add(this.btnInicioModificar);
            this.panel1.Controls.Add(this.btnInicioPacientes);
            this.panel1.Controls.Add(this.btnInicioAgenda);
            this.panel1.Controls.Add(this.btnInicioRegistro);
            this.panel1.Controls.Add(this.btnInicioBuscar);
            this.panel1.Controls.Add(this.btnInicioInicio);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 464);
            this.panel1.TabIndex = 2;
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
            this.lblIncio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIncio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncio.ForeColor = System.Drawing.Color.Red;
            this.lblIncio.Location = new System.Drawing.Point(67, 28);
            this.lblIncio.Name = "lblIncio";
            this.lblIncio.Size = new System.Drawing.Size(59, 21);
            this.lblIncio.TabIndex = 6;
            this.lblIncio.Text = "INICIO";
            // 
            // btnInicioSalir
            // 
            this.btnInicioSalir.Image = global::Consultorio_Dental.Properties.Resources.salirUsu;
            this.btnInicioSalir.Location = new System.Drawing.Point(4, 400);
            this.btnInicioSalir.Name = "btnInicioSalir";
            this.btnInicioSalir.Size = new System.Drawing.Size(63, 60);
            this.btnInicioSalir.TabIndex = 2;
            this.btnInicioSalir.UseVisualStyleBackColor = true;
            this.btnInicioSalir.Click += new System.EventHandler(this.btnInicioSalir_Click);
            // 
            // btnInicioModificar
            // 
            this.btnInicioModificar.Image = global::Consultorio_Dental.Properties.Resources.modificarUsu;
            this.btnInicioModificar.Location = new System.Drawing.Point(4, 334);
            this.btnInicioModificar.Name = "btnInicioModificar";
            this.btnInicioModificar.Size = new System.Drawing.Size(63, 60);
            this.btnInicioModificar.TabIndex = 5;
            this.btnInicioModificar.UseVisualStyleBackColor = true;
            this.btnInicioModificar.Click += new System.EventHandler(this.btnInicioModificar_Click);
            // 
            // btnInicioPacientes
            // 
            this.btnInicioPacientes.Image = global::Consultorio_Dental.Properties.Resources.pacientesUsu;
            this.btnInicioPacientes.Location = new System.Drawing.Point(4, 268);
            this.btnInicioPacientes.Name = "btnInicioPacientes";
            this.btnInicioPacientes.Size = new System.Drawing.Size(63, 60);
            this.btnInicioPacientes.TabIndex = 4;
            this.btnInicioPacientes.UseVisualStyleBackColor = true;
            this.btnInicioPacientes.Click += new System.EventHandler(this.btnInicioPacientes_Click);
            // 
            // btnInicioAgenda
            // 
            this.btnInicioAgenda.Image = global::Consultorio_Dental.Properties.Resources.agendaUsu;
            this.btnInicioAgenda.Location = new System.Drawing.Point(4, 202);
            this.btnInicioAgenda.Name = "btnInicioAgenda";
            this.btnInicioAgenda.Size = new System.Drawing.Size(63, 60);
            this.btnInicioAgenda.TabIndex = 3;
            this.btnInicioAgenda.UseVisualStyleBackColor = true;
            this.btnInicioAgenda.Click += new System.EventHandler(this.btnInicioAgenda_Click);
            // 
            // btnInicioRegistro
            // 
            this.btnInicioRegistro.Image = global::Consultorio_Dental.Properties.Resources.registroUsu;
            this.btnInicioRegistro.Location = new System.Drawing.Point(4, 136);
            this.btnInicioRegistro.Name = "btnInicioRegistro";
            this.btnInicioRegistro.Size = new System.Drawing.Size(63, 60);
            this.btnInicioRegistro.TabIndex = 2;
            this.btnInicioRegistro.UseVisualStyleBackColor = true;
            this.btnInicioRegistro.Click += new System.EventHandler(this.btnInicioRegistro_Click);
            // 
            // btnInicioBuscar
            // 
            this.btnInicioBuscar.Image = global::Consultorio_Dental.Properties.Resources.buscar;
            this.btnInicioBuscar.Location = new System.Drawing.Point(4, 70);
            this.btnInicioBuscar.Name = "btnInicioBuscar";
            this.btnInicioBuscar.Size = new System.Drawing.Size(63, 60);
            this.btnInicioBuscar.TabIndex = 1;
            this.btnInicioBuscar.UseVisualStyleBackColor = true;
            this.btnInicioBuscar.Click += new System.EventHandler(this.btnInicioBuscar_Click);
            // 
            // btnInicioInicio
            // 
            this.btnInicioInicio.Image = global::Consultorio_Dental.Properties.Resources.homeUsu;
            this.btnInicioInicio.Location = new System.Drawing.Point(4, 4);
            this.btnInicioInicio.Name = "btnInicioInicio";
            this.btnInicioInicio.Size = new System.Drawing.Size(63, 60);
            this.btnInicioInicio.TabIndex = 0;
            this.btnInicioInicio.UseVisualStyleBackColor = true;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(764, 481);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOME";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gboxPassword.ResumeLayout(false);
            this.gboxPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFotografia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureFotografia;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSalir;
        private System.Windows.Forms.Label lblModificar;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Label lblAgenda;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label lblIncio;
        private System.Windows.Forms.Button btnInicioSalir;
        private System.Windows.Forms.Button btnInicioModificar;
        private System.Windows.Forms.Button btnInicioPacientes;
        private System.Windows.Forms.Button btnInicioAgenda;
        private System.Windows.Forms.Button btnInicioRegistro;
        private System.Windows.Forms.Button btnInicioBuscar;
        private System.Windows.Forms.Button btnInicioInicio;
        private System.Windows.Forms.GroupBox gboxPassword;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox picturePassword;
        private System.Windows.Forms.ListBox listBox1;

    }
}