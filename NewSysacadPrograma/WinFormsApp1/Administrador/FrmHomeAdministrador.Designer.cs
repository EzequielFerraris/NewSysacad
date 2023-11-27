namespace NewSysacadFront
{
    partial class FrmHomeAdministrador
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
            btnListasEspera = new Button();
            btnRequisitosAcademicos = new Button();
            btnReportes = new Button();
            btnSalir = new Button();
            pnlSubMenuGE = new Panel();
            btnAgregarCurso = new Button();
            btnGestionarCursos = new Button();
            btnAgregarEstudiante = new Button();
            panel3 = new Panel();
            lbNombreAdmin = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pnlDisplay = new Panel();
            btnGenerarNotificacion = new Button();
            panel1.SuspendLayout();
            pnlSubMenuGE.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(102, 97, 130);
            panel1.Controls.Add(btnGenerarNotificacion);
            panel1.Controls.Add(btnListasEspera);
            panel1.Controls.Add(btnRequisitosAcademicos);
            panel1.Controls.Add(btnReportes);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(pnlSubMenuGE);
            panel1.Controls.Add(btnGestionarCursos);
            panel1.Controls.Add(btnAgregarEstudiante);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 461);
            panel1.TabIndex = 0;
            // 
            // btnListasEspera
            // 
            btnListasEspera.Dock = DockStyle.Top;
            btnListasEspera.FlatAppearance.BorderSize = 0;
            btnListasEspera.FlatAppearance.MouseDownBackColor = Color.Coral;
            btnListasEspera.FlatAppearance.MouseOverBackColor = Color.FromArgb(125, 121, 163);
            btnListasEspera.FlatStyle = FlatStyle.Flat;
            btnListasEspera.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnListasEspera.ForeColor = Color.DarkRed;
            btnListasEspera.Location = new Point(0, 306);
            btnListasEspera.Name = "btnListasEspera";
            btnListasEspera.Size = new Size(200, 46);
            btnListasEspera.TabIndex = 7;
            btnListasEspera.Text = "Manejar Listas de Espera";
            btnListasEspera.UseVisualStyleBackColor = true;
            btnListasEspera.Click += btnListasEspera_Click;
            // 
            // btnRequisitosAcademicos
            // 
            btnRequisitosAcademicos.Dock = DockStyle.Top;
            btnRequisitosAcademicos.FlatAppearance.BorderSize = 0;
            btnRequisitosAcademicos.FlatAppearance.MouseDownBackColor = Color.Coral;
            btnRequisitosAcademicos.FlatAppearance.MouseOverBackColor = Color.FromArgb(125, 121, 163);
            btnRequisitosAcademicos.FlatStyle = FlatStyle.Flat;
            btnRequisitosAcademicos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRequisitosAcademicos.ForeColor = Color.DarkRed;
            btnRequisitosAcademicos.Location = new Point(0, 260);
            btnRequisitosAcademicos.Name = "btnRequisitosAcademicos";
            btnRequisitosAcademicos.Size = new Size(200, 46);
            btnRequisitosAcademicos.TabIndex = 6;
            btnRequisitosAcademicos.Text = "Gestionar Requisitos Académicos";
            btnRequisitosAcademicos.UseVisualStyleBackColor = true;
            btnRequisitosAcademicos.Click += btnRequisitosAcademicos_Click;
            // 
            // btnReportes
            // 
            btnReportes.Dock = DockStyle.Top;
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatAppearance.MouseDownBackColor = Color.Coral;
            btnReportes.FlatAppearance.MouseOverBackColor = Color.FromArgb(125, 121, 163);
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnReportes.ForeColor = Color.DarkRed;
            btnReportes.Location = new Point(0, 220);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(200, 40);
            btnReportes.TabIndex = 5;
            btnReportes.Text = "Generar Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Bottom;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatAppearance.MouseDownBackColor = Color.Coral;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(125, 121, 163);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.DarkRed;
            btnSalir.Location = new Point(0, 421);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(200, 40);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // pnlSubMenuGE
            // 
            pnlSubMenuGE.BackColor = Color.FromArgb(158, 153, 186);
            pnlSubMenuGE.Controls.Add(btnAgregarCurso);
            pnlSubMenuGE.Dock = DockStyle.Top;
            pnlSubMenuGE.Location = new Point(0, 180);
            pnlSubMenuGE.Name = "pnlSubMenuGE";
            pnlSubMenuGE.Size = new Size(200, 40);
            pnlSubMenuGE.TabIndex = 3;
            // 
            // btnAgregarCurso
            // 
            btnAgregarCurso.Dock = DockStyle.Fill;
            btnAgregarCurso.FlatAppearance.BorderSize = 0;
            btnAgregarCurso.FlatAppearance.MouseDownBackColor = Color.Coral;
            btnAgregarCurso.FlatAppearance.MouseOverBackColor = Color.FromArgb(125, 121, 163);
            btnAgregarCurso.FlatStyle = FlatStyle.Flat;
            btnAgregarCurso.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarCurso.ForeColor = Color.DarkRed;
            btnAgregarCurso.Location = new Point(0, 0);
            btnAgregarCurso.Name = "btnAgregarCurso";
            btnAgregarCurso.Size = new Size(200, 40);
            btnAgregarCurso.TabIndex = 0;
            btnAgregarCurso.Text = "Agregar curso";
            btnAgregarCurso.UseVisualStyleBackColor = true;
            btnAgregarCurso.Click += btnAgregarCurso_Click;
            // 
            // btnGestionarCursos
            // 
            btnGestionarCursos.Dock = DockStyle.Top;
            btnGestionarCursos.FlatAppearance.BorderSize = 0;
            btnGestionarCursos.FlatAppearance.MouseDownBackColor = Color.Coral;
            btnGestionarCursos.FlatAppearance.MouseOverBackColor = Color.FromArgb(125, 121, 163);
            btnGestionarCursos.FlatStyle = FlatStyle.Flat;
            btnGestionarCursos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGestionarCursos.ForeColor = Color.DarkRed;
            btnGestionarCursos.Location = new Point(0, 140);
            btnGestionarCursos.Name = "btnGestionarCursos";
            btnGestionarCursos.Size = new Size(200, 40);
            btnGestionarCursos.TabIndex = 2;
            btnGestionarCursos.Text = "Gestionar Cursos";
            btnGestionarCursos.UseVisualStyleBackColor = true;
            btnGestionarCursos.Click += btnGestionarCursos_Click;
            // 
            // btnAgregarEstudiante
            // 
            btnAgregarEstudiante.Dock = DockStyle.Top;
            btnAgregarEstudiante.FlatAppearance.BorderSize = 0;
            btnAgregarEstudiante.FlatAppearance.MouseDownBackColor = Color.Coral;
            btnAgregarEstudiante.FlatAppearance.MouseOverBackColor = Color.FromArgb(125, 121, 163);
            btnAgregarEstudiante.FlatStyle = FlatStyle.Flat;
            btnAgregarEstudiante.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarEstudiante.ForeColor = Color.DarkRed;
            btnAgregarEstudiante.Location = new Point(0, 100);
            btnAgregarEstudiante.Name = "btnAgregarEstudiante";
            btnAgregarEstudiante.Size = new Size(200, 40);
            btnAgregarEstudiante.TabIndex = 1;
            btnAgregarEstudiante.Text = "Agregar Estudiante";
            btnAgregarEstudiante.UseVisualStyleBackColor = true;
            btnAgregarEstudiante.Click += btnAgregarEstudiante_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(lbNombreAdmin);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 100);
            panel3.TabIndex = 0;
            // 
            // lbNombreAdmin
            // 
            lbNombreAdmin.Dock = DockStyle.Fill;
            lbNombreAdmin.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbNombreAdmin.ForeColor = Color.DarkRed;
            lbNombreAdmin.Location = new Point(0, 0);
            lbNombreAdmin.Name = "lbNombreAdmin";
            lbNombreAdmin.Size = new Size(200, 100);
            lbNombreAdmin.TabIndex = 0;
            lbNombreAdmin.Text = "?";
            lbNombreAdmin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(200, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(584, 100);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(158, 153, 186);
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = Properties.Resources.UTN;
            pictureBox1.Location = new Point(484, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(158, 153, 186);
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(484, 100);
            label1.TabIndex = 0;
            label1.Text = "New Sysacad";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlDisplay
            // 
            pnlDisplay.Dock = DockStyle.Fill;
            pnlDisplay.Location = new Point(200, 100);
            pnlDisplay.Name = "pnlDisplay";
            pnlDisplay.Size = new Size(584, 361);
            pnlDisplay.TabIndex = 2;
            // 
            // btnGenerarNotificacion
            // 
            btnGenerarNotificacion.Dock = DockStyle.Top;
            btnGenerarNotificacion.FlatAppearance.BorderSize = 0;
            btnGenerarNotificacion.FlatAppearance.MouseDownBackColor = Color.Coral;
            btnGenerarNotificacion.FlatAppearance.MouseOverBackColor = Color.FromArgb(125, 121, 163);
            btnGenerarNotificacion.FlatStyle = FlatStyle.Flat;
            btnGenerarNotificacion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGenerarNotificacion.ForeColor = Color.DarkRed;
            btnGenerarNotificacion.Location = new Point(0, 352);
            btnGenerarNotificacion.Name = "btnGenerarNotificacion";
            btnGenerarNotificacion.Size = new Size(200, 46);
            btnGenerarNotificacion.TabIndex = 8;
            btnGenerarNotificacion.Text = "Nueva Notificación";
            btnGenerarNotificacion.UseVisualStyleBackColor = true;
            btnGenerarNotificacion.Click += btnGenerarNotificacion_Click;
            // 
            // FrmHomeAdministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(125, 121, 163);
            ClientSize = new Size(784, 461);
            Controls.Add(pnlDisplay);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximumSize = new Size(800, 500);
            MinimumSize = new Size(800, 500);
            Name = "FrmHomeAdministrador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Panel de Control (Administrador)";
            panel1.ResumeLayout(false);
            pnlSubMenuGE.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label lbNombreAdmin;
        private Panel pnlSubMenuGE;
        private Button btnGestionarCursos;
        private Button btnAgregarEstudiante;
        private Label label1;
        private Button btnSalir;
        private Button btnAgregarCurso;
        private Panel pnlDisplay;
        private PictureBox pictureBox1;
        private Button btnReportes;
        private Button btnRequisitosAcademicos;
        private Button btnListasEspera;
        private Button btnGenerarNotificacion;
    }
}