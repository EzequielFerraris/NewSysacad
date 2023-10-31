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
            panel1 = new Panel();
            btnDescargarPDF = new Button();
            btnAceptar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            lblFechaInicio = new Label();
            lblFechaFinal = new Label();
            lblCantidadInscriptos = new Label();
            lblPorcentaje = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(13, 109);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 2;
            label1.Text = "Fecha Inicio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(13, 149);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 3;
            label2.Text = "Fecha Final:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(13, 189);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 4;
            label3.Text = "Inscriptos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkRed;
            label4.Location = new Point(13, 69);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 5;
            label4.Text = "Carrera:";
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
            // label7
            // 
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkRed;
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(304, 48);
            label7.TabIndex = 8;
            label7.Text = "INFORME: inscripciones";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(label7);
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
            lblFechaInicio.Location = new Point(121, 109);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(12, 15);
            lblFechaInicio.TabIndex = 10;
            lblFechaInicio.Text = "?";
            // 
            // lblFechaFinal
            // 
            lblFechaFinal.AutoSize = true;
            lblFechaFinal.ForeColor = Color.Brown;
            lblFechaFinal.Location = new Point(121, 149);
            lblFechaFinal.Name = "lblFechaFinal";
            lblFechaFinal.Size = new Size(12, 15);
            lblFechaFinal.TabIndex = 11;
            lblFechaFinal.Text = "?";
            // 
            // lblCantidadInscriptos
            // 
            lblCantidadInscriptos.AutoSize = true;
            lblCantidadInscriptos.ForeColor = Color.Brown;
            lblCantidadInscriptos.Location = new Point(121, 189);
            lblCantidadInscriptos.Name = "lblCantidadInscriptos";
            lblCantidadInscriptos.Size = new Size(12, 15);
            lblCantidadInscriptos.TabIndex = 12;
            lblCantidadInscriptos.Text = "?";
            // 
            // lblPorcentaje
            // 
            lblPorcentaje.AutoSize = true;
            lblPorcentaje.ForeColor = Color.Brown;
            lblPorcentaje.Location = new Point(121, 69);
            lblPorcentaje.Name = "lblPorcentaje";
            lblPorcentaje.Size = new Size(12, 15);
            lblPorcentaje.TabIndex = 13;
            lblPorcentaje.Text = "?";
            // 
            // FrmReporteInscripcionesCarrera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(102, 97, 130);
            ClientSize = new Size(304, 366);
            Controls.Add(lblPorcentaje);
            Controls.Add(lblCantidadInscriptos);
            Controls.Add(lblFechaFinal);
            Controls.Add(lblFechaInicio);
            Controls.Add(panel2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "FrmReporteInscripcionesCarrera";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Comprobante";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnAceptar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Panel panel2;
        private Label lblFechaInicio;
        private Label lblFechaFinal;
        private Label lblCantidadInscriptos;
        private Label lblPorcentaje;
        private Button btnDescargarPDF;
    }
}