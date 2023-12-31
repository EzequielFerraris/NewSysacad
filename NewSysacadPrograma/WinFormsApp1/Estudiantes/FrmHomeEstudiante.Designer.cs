﻿namespace NewSysacadFront
{
    partial class FrmHomeEstudiante
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
            panel1 = new Panel();
            pnlSubMenuGE = new Panel();
            btnPagosRealizados = new Button();
            btnPagosPendientes = new Button();
            btnRealizarPagos = new Button();
            btnSalir = new Button();
            btnConsultarHorario = new Button();
            btnInscripcionCursos = new Button();
            panel3 = new Panel();
            pbxNotificaciones = new PictureBox();
            pictureBox1 = new PictureBox();
            lbNombreEstudiante = new Label();
            pnlDisplay = new Panel();
            btnPreferencias = new Button();
            panel1.SuspendLayout();
            pnlSubMenuGE.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxNotificaciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(124, 114, 140);
            panel1.Controls.Add(btnPreferencias);
            panel1.Controls.Add(pnlSubMenuGE);
            panel1.Controls.Add(btnRealizarPagos);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(btnConsultarHorario);
            panel1.Controls.Add(btnInscripcionCursos);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 461);
            panel1.TabIndex = 1;
            // 
            // pnlSubMenuGE
            // 
            pnlSubMenuGE.BackColor = Color.FromArgb(102, 97, 130);
            pnlSubMenuGE.Controls.Add(btnPagosRealizados);
            pnlSubMenuGE.Controls.Add(btnPagosPendientes);
            pnlSubMenuGE.Dock = DockStyle.Top;
            pnlSubMenuGE.Location = new Point(0, 250);
            pnlSubMenuGE.Name = "pnlSubMenuGE";
            pnlSubMenuGE.Size = new Size(200, 61);
            pnlSubMenuGE.TabIndex = 6;
            // 
            // btnPagosRealizados
            // 
            btnPagosRealizados.BackColor = Color.FromArgb(158, 153, 186);
            btnPagosRealizados.Dock = DockStyle.Top;
            btnPagosRealizados.FlatAppearance.BorderSize = 0;
            btnPagosRealizados.FlatAppearance.MouseDownBackColor = Color.Coral;
            btnPagosRealizados.FlatAppearance.MouseOverBackColor = Color.FromArgb(102, 97, 130);
            btnPagosRealizados.FlatStyle = FlatStyle.Flat;
            btnPagosRealizados.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPagosRealizados.ForeColor = Color.Gainsboro;
            btnPagosRealizados.Location = new Point(0, 30);
            btnPagosRealizados.Name = "btnPagosRealizados";
            btnPagosRealizados.Padding = new Padding(10, 0, 0, 0);
            btnPagosRealizados.Size = new Size(200, 30);
            btnPagosRealizados.TabIndex = 1;
            btnPagosRealizados.Text = "Realizados";
            btnPagosRealizados.TextAlign = ContentAlignment.MiddleLeft;
            btnPagosRealizados.UseVisualStyleBackColor = false;
            btnPagosRealizados.Click += btnPagosRealizados_Click;
            // 
            // btnPagosPendientes
            // 
            btnPagosPendientes.BackColor = Color.FromArgb(158, 153, 186);
            btnPagosPendientes.Dock = DockStyle.Top;
            btnPagosPendientes.FlatAppearance.BorderSize = 0;
            btnPagosPendientes.FlatAppearance.MouseDownBackColor = Color.Coral;
            btnPagosPendientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(125, 121, 163);
            btnPagosPendientes.FlatStyle = FlatStyle.Flat;
            btnPagosPendientes.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPagosPendientes.ForeColor = Color.Gainsboro;
            btnPagosPendientes.Location = new Point(0, 0);
            btnPagosPendientes.Name = "btnPagosPendientes";
            btnPagosPendientes.Padding = new Padding(10, 0, 0, 0);
            btnPagosPendientes.Size = new Size(200, 30);
            btnPagosPendientes.TabIndex = 0;
            btnPagosPendientes.Text = "Pendientes";
            btnPagosPendientes.TextAlign = ContentAlignment.MiddleLeft;
            btnPagosPendientes.UseVisualStyleBackColor = false;
            btnPagosPendientes.Click += btnPagosPendientes_Click;
            // 
            // btnRealizarPagos
            // 
            btnRealizarPagos.Dock = DockStyle.Top;
            btnRealizarPagos.FlatAppearance.BorderSize = 0;
            btnRealizarPagos.FlatAppearance.MouseDownBackColor = Color.Coral;
            btnRealizarPagos.FlatAppearance.MouseOverBackColor = Color.FromArgb(102, 97, 130);
            btnRealizarPagos.FlatStyle = FlatStyle.Flat;
            btnRealizarPagos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRealizarPagos.ForeColor = Color.Gainsboro;
            btnRealizarPagos.Location = new Point(0, 210);
            btnRealizarPagos.Name = "btnRealizarPagos";
            btnRealizarPagos.Padding = new Padding(10, 0, 0, 0);
            btnRealizarPagos.Size = new Size(200, 40);
            btnRealizarPagos.TabIndex = 5;
            btnRealizarPagos.Text = "Pagos";
            btnRealizarPagos.TextAlign = ContentAlignment.MiddleLeft;
            btnRealizarPagos.UseVisualStyleBackColor = true;
            btnRealizarPagos.Click += btnRealizarPagos_Click;
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Bottom;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatAppearance.MouseDownBackColor = Color.Coral;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(102, 97, 130);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.Gainsboro;
            btnSalir.Location = new Point(0, 381);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(200, 80);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnConsultarHorario
            // 
            btnConsultarHorario.Dock = DockStyle.Top;
            btnConsultarHorario.FlatAppearance.BorderSize = 0;
            btnConsultarHorario.FlatAppearance.MouseDownBackColor = Color.Coral;
            btnConsultarHorario.FlatAppearance.MouseOverBackColor = Color.FromArgb(102, 97, 130);
            btnConsultarHorario.FlatStyle = FlatStyle.Flat;
            btnConsultarHorario.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnConsultarHorario.ForeColor = Color.Gainsboro;
            btnConsultarHorario.Location = new Point(0, 170);
            btnConsultarHorario.Name = "btnConsultarHorario";
            btnConsultarHorario.Padding = new Padding(10, 0, 0, 0);
            btnConsultarHorario.Size = new Size(200, 40);
            btnConsultarHorario.TabIndex = 2;
            btnConsultarHorario.Text = "Consultar Horario";
            btnConsultarHorario.TextAlign = ContentAlignment.MiddleLeft;
            btnConsultarHorario.UseVisualStyleBackColor = true;
            btnConsultarHorario.Click += btnConsultarHorario_Click;
            // 
            // btnInscripcionCursos
            // 
            btnInscripcionCursos.Dock = DockStyle.Top;
            btnInscripcionCursos.FlatAppearance.BorderSize = 0;
            btnInscripcionCursos.FlatAppearance.MouseDownBackColor = Color.Coral;
            btnInscripcionCursos.FlatAppearance.MouseOverBackColor = Color.FromArgb(102, 97, 130);
            btnInscripcionCursos.FlatStyle = FlatStyle.Flat;
            btnInscripcionCursos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnInscripcionCursos.ForeColor = Color.Gainsboro;
            btnInscripcionCursos.Location = new Point(0, 130);
            btnInscripcionCursos.Name = "btnInscripcionCursos";
            btnInscripcionCursos.Padding = new Padding(10, 0, 0, 0);
            btnInscripcionCursos.Size = new Size(200, 40);
            btnInscripcionCursos.TabIndex = 1;
            btnInscripcionCursos.Text = "Inscripción de cursos";
            btnInscripcionCursos.TextAlign = ContentAlignment.MiddleLeft;
            btnInscripcionCursos.UseVisualStyleBackColor = true;
            btnInscripcionCursos.Click += btnInscripcionCursos_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(pbxNotificaciones);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(lbNombreEstudiante);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 130);
            panel3.TabIndex = 0;
            // 
            // pbxNotificaciones
            // 
            pbxNotificaciones.Image = Properties.Resources.notificationClear;
            pbxNotificaciones.Location = new Point(171, 100);
            pbxNotificaciones.Name = "pbxNotificaciones";
            pbxNotificaciones.Size = new Size(26, 24);
            pbxNotificaciones.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxNotificaciones.TabIndex = 4;
            pbxNotificaciones.TabStop = false;
            pbxNotificaciones.Click += pbxNotificaciones_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.UTN;
            pictureBox1.Location = new Point(50, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lbNombreEstudiante
            // 
            lbNombreEstudiante.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbNombreEstudiante.ForeColor = Color.Brown;
            lbNombreEstudiante.Location = new Point(0, 105);
            lbNombreEstudiante.Name = "lbNombreEstudiante";
            lbNombreEstudiante.Padding = new Padding(10, 0, 0, 0);
            lbNombreEstudiante.Size = new Size(168, 25);
            lbNombreEstudiante.TabIndex = 0;
            lbNombreEstudiante.Text = "?";
            lbNombreEstudiante.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlDisplay
            // 
            pnlDisplay.Dock = DockStyle.Fill;
            pnlDisplay.Location = new Point(200, 0);
            pnlDisplay.Name = "pnlDisplay";
            pnlDisplay.Size = new Size(584, 461);
            pnlDisplay.TabIndex = 2;
            // 
            // btnPreferencias
            // 
            btnPreferencias.Dock = DockStyle.Top;
            btnPreferencias.FlatAppearance.BorderSize = 0;
            btnPreferencias.FlatAppearance.MouseDownBackColor = Color.Coral;
            btnPreferencias.FlatAppearance.MouseOverBackColor = Color.FromArgb(102, 97, 130);
            btnPreferencias.FlatStyle = FlatStyle.Flat;
            btnPreferencias.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPreferencias.ForeColor = Color.Gainsboro;
            btnPreferencias.Location = new Point(0, 311);
            btnPreferencias.Name = "btnPreferencias";
            btnPreferencias.Padding = new Padding(10, 0, 0, 0);
            btnPreferencias.Size = new Size(200, 40);
            btnPreferencias.TabIndex = 7;
            btnPreferencias.Text = "Preferencias";
            btnPreferencias.TextAlign = ContentAlignment.MiddleLeft;
            btnPreferencias.UseVisualStyleBackColor = true;
            btnPreferencias.Click += btnPreferencias_Click;
            // 
            // FrmHomeEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 29, 33);
            ClientSize = new Size(784, 461);
            Controls.Add(pnlDisplay);
            Controls.Add(panel1);
            MaximumSize = new Size(800, 500);
            MinimumSize = new Size(800, 500);
            Name = "FrmHomeEstudiante";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Panel de Control (Estudiante)";
            panel1.ResumeLayout(false);
            pnlSubMenuGE.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbxNotificaciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnSalir;
        private Button btnConsultarHorario;
        private Button btnInscripcionCursos;
        private Panel panel3;
        private Label lbNombreEstudiante;
        private Button btnRealizarPagos;
        private PictureBox pictureBox1;
        private Panel pnlDisplay;
        private Panel pnlSubMenuGE;
        private Button btnPagosRealizados;
        private Button btnPagosPendientes;
        private PictureBox pbxNotificaciones;
        private Button btnPreferencias;
    }
}