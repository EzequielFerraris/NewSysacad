namespace NewSysacadFront
{
    partial class FrmReporteInscripcionesCarrera
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnDescargarPDF = new Button();
            btnAceptar = new Button();
            lbl2 = new Label();
            lbl3 = new Label();
            lbl4 = new Label();
            lbl1 = new Label();
            label5 = new Label();
            lblTitulo = new Label();
            panel2 = new Panel();
            lblFechaInicio = new Label();
            lblFechaFinal = new Label();
            lblAlumnosTotales = new Label();
            lblCarrera = new Label();
            dgvInscripciones = new DataGridView();
            lbl5 = new Label();
            lblInscriptos = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInscripciones).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDescargarPDF);
            panel1.Controls.Add(btnAceptar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 301);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(3);
            panel1.Size = new Size(304, 65);
            panel1.TabIndex = 0;
            // 
            // btnDescargarPDF
            // 
            btnDescargarPDF.BackColor = Color.FromArgb(158, 153, 186);
            btnDescargarPDF.FlatAppearance.BorderSize = 0;
            btnDescargarPDF.FlatAppearance.MouseDownBackColor = Color.Coral;
            btnDescargarPDF.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            btnDescargarPDF.FlatStyle = FlatStyle.Flat;
            btnDescargarPDF.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDescargarPDF.ForeColor = Color.Brown;
            btnDescargarPDF.ImageAlign = ContentAlignment.TopRight;
            btnDescargarPDF.Location = new Point(12, 6);
            btnDescargarPDF.Name = "btnDescargarPDF";
            btnDescargarPDF.Size = new Size(121, 54);
            btnDescargarPDF.TabIndex = 14;
            btnDescargarPDF.Text = "Descargar PDF";
            btnDescargarPDF.UseVisualStyleBackColor = false;
            btnDescargarPDF.Click += btnDescargarPDF_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(158, 153, 186);
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatAppearance.MouseDownBackColor = Color.Coral;
            btnAceptar.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.Brown;
            btnAceptar.ImageAlign = ContentAlignment.TopRight;
            btnAceptar.Location = new Point(171, 6);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(121, 54);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl2.ForeColor = Color.DarkRed;
            lbl2.Location = new Point(11, 84);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(74, 15);
            lbl2.TabIndex = 2;
            lbl2.Text = "Fecha Inicio:";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl3.ForeColor = Color.DarkRed;
            lbl3.Location = new Point(13, 108);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(69, 15);
            lbl3.TabIndex = 3;
            lbl3.Text = "Fecha Final:";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl4.ForeColor = Color.DarkRed;
            lbl4.Location = new Point(13, 132);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(96, 15);
            lbl4.TabIndex = 4;
            lbl4.Text = "Alumnos totales:";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl1.ForeColor = Color.DarkRed;
            lbl1.Location = new Point(12, 60);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(47, 15);
            lbl1.TabIndex = 5;
            lbl1.Text = "Carrera:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(12, 180);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 6;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.DarkRed;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(304, 48);
            lblTitulo.TabIndex = 8;
            lblTitulo.Text = "INFORME: Inscripciones Carrera";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblTitulo);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(304, 48);
            panel2.TabIndex = 9;
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.ForeColor = Color.Brown;
            lblFechaInicio.Location = new Point(88, 84);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(12, 15);
            lblFechaInicio.TabIndex = 10;
            lblFechaInicio.Text = "?";
            // 
            // lblFechaFinal
            // 
            lblFechaFinal.AutoSize = true;
            lblFechaFinal.ForeColor = Color.Brown;
            lblFechaFinal.Location = new Point(88, 108);
            lblFechaFinal.Name = "lblFechaFinal";
            lblFechaFinal.Size = new Size(12, 15);
            lblFechaFinal.TabIndex = 11;
            lblFechaFinal.Text = "?";
            // 
            // lblAlumnosTotales
            // 
            lblAlumnosTotales.AutoSize = true;
            lblAlumnosTotales.ForeColor = Color.Brown;
            lblAlumnosTotales.Location = new Point(115, 132);
            lblAlumnosTotales.Name = "lblAlumnosTotales";
            lblAlumnosTotales.Size = new Size(12, 15);
            lblAlumnosTotales.TabIndex = 12;
            lblAlumnosTotales.Text = "?";
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.ForeColor = Color.Brown;
            lblCarrera.Location = new Point(65, 60);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(12, 15);
            lblCarrera.TabIndex = 13;
            lblCarrera.Text = "?";
            // 
            // dgvInscripciones
            // 
            dgvInscripciones.AllowUserToAddRows = false;
            dgvInscripciones.AllowUserToDeleteRows = false;
            dgvInscripciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvInscripciones.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvInscripciones.BackgroundColor = Color.FromArgb(158, 153, 186);
            dgvInscripciones.BorderStyle = BorderStyle.None;
            dgvInscripciones.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(125, 121, 163);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.DarkRed;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(125, 121, 163);
            dataGridViewCellStyle1.SelectionForeColor = Color.DarkRed;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvInscripciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvInscripciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInscripciones.EnableHeadersVisualStyles = false;
            dgvInscripciones.GridColor = Color.FromArgb(125, 121, 163);
            dgvInscripciones.Location = new Point(11, 189);
            dgvInscripciones.Name = "dgvInscripciones";
            dgvInscripciones.ReadOnly = true;
            dgvInscripciones.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(158, 153, 186);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.DarkRed;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(102, 97, 130);
            dataGridViewCellStyle2.SelectionForeColor = Color.LightCoral;
            dgvInscripciones.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvInscripciones.RowTemplate.Height = 25;
            dgvInscripciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInscripciones.Size = new Size(281, 106);
            dgvInscripciones.TabIndex = 18;
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl5.ForeColor = Color.DarkRed;
            lbl5.Location = new Point(13, 159);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(134, 15);
            lbl5.TabIndex = 19;
            lbl5.Text = "Inscriptos en el período:";
            // 
            // lblInscriptos
            // 
            lblInscriptos.AutoSize = true;
            lblInscriptos.ForeColor = Color.Brown;
            lblInscriptos.Location = new Point(153, 159);
            lblInscriptos.Name = "lblInscriptos";
            lblInscriptos.Size = new Size(12, 15);
            lblInscriptos.TabIndex = 20;
            lblInscriptos.Text = "?";
            // 
            // FrmReporteInscripcionesCarrera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(102, 97, 130);
            ClientSize = new Size(304, 366);
            Controls.Add(lblInscriptos);
            Controls.Add(lbl5);
            Controls.Add(dgvInscripciones);
            Controls.Add(lblCarrera);
            Controls.Add(lblAlumnosTotales);
            Controls.Add(lblFechaFinal);
            Controls.Add(lblFechaInicio);
            Controls.Add(panel2);
            Controls.Add(label5);
            Controls.Add(lbl1);
            Controls.Add(lbl4);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(panel1);
            Name = "FrmReporteInscripcionesCarrera";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Comprobante";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInscripciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnAceptar;
        private Label lbl2;
        private Label lbl3;
        private Label lbl4;
        private Label lbl1;
        private Label label5;
        private Label lblTitulo;
        private Panel panel2;
        private Label lblFechaInicio;
        private Label lblFechaFinal;
        private Label lblAlumnosTotales;
        private Label lblCarrera;
        private Button btnDescargarPDF;
        private DataGridView dgvInscripciones;
        private Label lbl5;
        private Label lblInscriptos;
    }
}