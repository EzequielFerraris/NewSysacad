﻿namespace NewSysacadFront
{
    partial class FrmAgregarEstudiante
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
            panelTop = new Panel();
            lblTitulo = new Label();
            panel1 = new Panel();
            cbxEnviarMail = new CheckBox();
            btnRegistrar = new Button();
            txbApellido = new TextBox();
            txbNombre = new TextBox();
            txbDni = new TextBox();
            txEmail = new TextBox();
            txbNombreUsuario = new TextBox();
            txbTelefono = new TextBox();
            txbCalle = new TextBox();
            cbxCambiarPassword = new CheckBox();
            lblNomble = new Label();
            lblApellido = new Label();
            lblDni = new Label();
            lblEmail = new Label();
            lblNombreUsuario = new Label();
            lblTelefono = new Label();
            lblDireccion = new Label();
            label1 = new Label();
            txbAltura = new TextBox();
            label2 = new Label();
            cbxCarrera = new ComboBox();
            panelTop.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(lblTitulo);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(584, 80);
            panelTop.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.Brown;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(584, 80);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Agregar nuevo estudiante";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(cbxEnviarMail);
            panel1.Controls.Add(btnRegistrar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 281);
            panel1.Name = "panel1";
            panel1.Size = new Size(584, 80);
            panel1.TabIndex = 1;
            // 
            // cbxEnviarMail
            // 
            cbxEnviarMail.ForeColor = Color.DarkRed;
            cbxEnviarMail.Location = new Point(12, 21);
            cbxEnviarMail.Name = "cbxEnviarMail";
            cbxEnviarMail.Size = new Size(278, 45);
            cbxEnviarMail.TabIndex = 12;
            cbxEnviarMail.Text = "Enviar correo electrónico al estudiante";
            cbxEnviarMail.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Dock = DockStyle.Right;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatAppearance.MouseDownBackColor = Color.Coral;
            btnRegistrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(102, 97, 130);
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrar.ForeColor = Color.Brown;
            btnRegistrar.Location = new Point(359, 0);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(225, 80);
            btnRegistrar.TabIndex = 11;
            btnRegistrar.TabStop = false;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txbApellido
            // 
            txbApellido.Location = new Point(89, 72);
            txbApellido.Name = "txbApellido";
            txbApellido.Size = new Size(175, 23);
            txbApellido.TabIndex = 1;
            // 
            // txbNombre
            // 
            txbNombre.Location = new Point(89, 114);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(175, 23);
            txbNombre.TabIndex = 2;
            // 
            // txbDni
            // 
            txbDni.Location = new Point(89, 156);
            txbDni.Name = "txbDni";
            txbDni.Size = new Size(175, 23);
            txbDni.TabIndex = 3;
            // 
            // txEmail
            // 
            txEmail.Location = new Point(89, 193);
            txEmail.Name = "txEmail";
            txEmail.Size = new Size(175, 23);
            txEmail.TabIndex = 4;
            // 
            // txbNombreUsuario
            // 
            txbNombreUsuario.Location = new Point(385, 72);
            txbNombreUsuario.Name = "txbNombreUsuario";
            txbNombreUsuario.Size = new Size(175, 23);
            txbNombreUsuario.TabIndex = 6;
            // 
            // txbTelefono
            // 
            txbTelefono.Location = new Point(89, 237);
            txbTelefono.Name = "txbTelefono";
            txbTelefono.Size = new Size(175, 23);
            txbTelefono.TabIndex = 5;
            // 
            // txbCalle
            // 
            txbCalle.Location = new Point(385, 114);
            txbCalle.Name = "txbCalle";
            txbCalle.Size = new Size(175, 23);
            txbCalle.TabIndex = 7;
            // 
            // cbxCambiarPassword
            // 
            cbxCambiarPassword.ForeColor = Color.DarkRed;
            cbxCambiarPassword.Location = new Point(282, 237);
            cbxCambiarPassword.Name = "cbxCambiarPassword";
            cbxCambiarPassword.Size = new Size(278, 45);
            cbxCambiarPassword.TabIndex = 10;
            cbxCambiarPassword.Text = "Permitir cambiar contraseña al iniciar por primera vez";
            cbxCambiarPassword.UseVisualStyleBackColor = true;
            // 
            // lblNomble
            // 
            lblNomble.AutoSize = true;
            lblNomble.ForeColor = Color.DarkRed;
            lblNomble.Location = new Point(12, 114);
            lblNomble.Name = "lblNomble";
            lblNomble.Size = new Size(54, 15);
            lblNomble.TabIndex = 11;
            lblNomble.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.ForeColor = Color.DarkRed;
            lblApellido.Location = new Point(12, 72);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(54, 15);
            lblApellido.TabIndex = 12;
            lblApellido.Text = "Apellido:";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.ForeColor = Color.DarkRed;
            lblDni.Location = new Point(12, 156);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(30, 15);
            lblDni.TabIndex = 13;
            lblDni.Text = "DNI:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.ForeColor = Color.DarkRed;
            lblEmail.Location = new Point(12, 193);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 14;
            lblEmail.Text = "E-mail:";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.ForeColor = Color.DarkRed;
            lblNombreUsuario.Location = new Point(282, 75);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(97, 15);
            lblNombreUsuario.TabIndex = 15;
            lblNombreUsuario.Text = "Nombre Usuario:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.ForeColor = Color.DarkRed;
            lblTelefono.Location = new Point(12, 237);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(55, 15);
            lblTelefono.TabIndex = 16;
            lblTelefono.Text = "Teléfono:";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.ForeColor = Color.DarkRed;
            lblDireccion.Location = new Point(282, 114);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(36, 15);
            lblDireccion.TabIndex = 17;
            lblDireccion.Text = "Calle:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(282, 159);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 18;
            label1.Text = "Altura:";
            // 
            // txbAltura
            // 
            txbAltura.Location = new Point(385, 156);
            txbAltura.Name = "txbAltura";
            txbAltura.Size = new Size(175, 23);
            txbAltura.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(282, 204);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 20;
            label2.Text = "Carrera:";
            // 
            // cbxCarrera
            // 
            cbxCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCarrera.FormattingEnabled = true;
            cbxCarrera.Items.AddRange(new object[] { "Tec. Univ. en Programación", "Tec. Univ. en Sistemas", "Licenciatura en Sistemas", "Ingeniería en Sistemas" });
            cbxCarrera.Location = new Point(385, 201);
            cbxCarrera.Name = "cbxCarrera";
            cbxCarrera.Size = new Size(175, 23);
            cbxCarrera.TabIndex = 9;
            // 
            // FrmAgregarEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(125, 121, 163);
            ClientSize = new Size(584, 361);
            Controls.Add(cbxCarrera);
            Controls.Add(label2);
            Controls.Add(txbAltura);
            Controls.Add(label1);
            Controls.Add(lblDireccion);
            Controls.Add(lblTelefono);
            Controls.Add(lblNombreUsuario);
            Controls.Add(lblEmail);
            Controls.Add(lblDni);
            Controls.Add(lblApellido);
            Controls.Add(lblNomble);
            Controls.Add(cbxCambiarPassword);
            Controls.Add(txbCalle);
            Controls.Add(txbTelefono);
            Controls.Add(txbNombreUsuario);
            Controls.Add(txEmail);
            Controls.Add(txbDni);
            Controls.Add(txbNombre);
            Controls.Add(txbApellido);
            Controls.Add(panel1);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(584, 361);
            MinimumSize = new Size(584, 361);
            Name = "FrmAgregarEstudiante";
            Text = "FrmAgregarEstudiante";
            panelTop.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTop;
        private Label lblTitulo;
        private Panel panel1;
        private TextBox txbApellido;
        private TextBox txbNombre;
        private TextBox txbDni;
        private TextBox txEmail;
        private TextBox txbNombreUsuario;
        private TextBox txbTelefono;
        private TextBox txbCalle;
        private CheckBox cbxCambiarPassword;
        private Label lblNomble;
        private Label lblApellido;
        private Label lblDni;
        private Label lblEmail;
        private Label lblNombreUsuario;
        private Label lblTelefono;
        private Button btnRegistrar;
        private Label lblDireccion;
        private Label label1;
        private TextBox txbAltura;
        private Label label2;
        private ComboBox cbxCarrera;
        private CheckBox cbxEnviarMail;
    }
}