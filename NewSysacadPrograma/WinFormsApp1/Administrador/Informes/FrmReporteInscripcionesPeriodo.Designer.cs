﻿namespace NewSysacadFront
{
    partial class FrmReporteInscripcionesPeriodo
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
            lbl1 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            label5 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            lblFechaInicio = new Label();
            lblFechaFinal = new Label();
            lblCantidadInscriptos = new Label();
            lbl4 = new Label();
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
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl1.ForeColor = Color.DarkRed;
            lbl1.Location = new Point(12, 69);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(74, 15);
            lbl1.TabIndex = 2;
            lbl1.Text = "Fecha Inicio:";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl2.ForeColor = Color.DarkRed;
            lbl2.Location = new Point(12, 109);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(69, 15);
            lbl2.TabIndex = 3;
            lbl2.Text = "Fecha Final:";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl3.ForeColor = Color.DarkRed;
            lbl3.Location = new Point(12, 149);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(62, 15);
            lbl3.TabIndex = 4;
            lbl3.Text = "Inscriptos:";
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
            lblFechaInicio.Location = new Point(139, 69);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(12, 15);
            lblFechaInicio.TabIndex = 10;
            lblFechaInicio.Text = "?";
            // 
            // lblFechaFinal
            // 
            lblFechaFinal.AutoSize = true;
            lblFechaFinal.ForeColor = Color.Brown;
            lblFechaFinal.Location = new Point(139, 109);
            lblFechaFinal.Name = "lblFechaFinal";
            lblFechaFinal.Size = new Size(12, 15);
            lblFechaFinal.TabIndex = 11;
            lblFechaFinal.Text = "?";
            // 
            // lblCantidadInscriptos
            // 
            lblCantidadInscriptos.AutoSize = true;
            lblCantidadInscriptos.ForeColor = Color.Brown;
            lblCantidadInscriptos.Location = new Point(139, 149);
            lblCantidadInscriptos.Name = "lblCantidadInscriptos";
            lblCantidadInscriptos.Size = new Size(12, 15);
            lblCantidadInscriptos.TabIndex = 12;
            lblCantidadInscriptos.Text = "?";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl4.ForeColor = Color.DarkRed;
            lbl4.Location = new Point(12, 189);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(112, 15);
            lbl4.TabIndex = 13;
            lbl4.Text = "Porcentaje del total:";
            // 
            // lblPorcentaje
            // 
            lblPorcentaje.AutoSize = true;
            lblPorcentaje.ForeColor = Color.Brown;
            lblPorcentaje.Location = new Point(139, 189);
            lblPorcentaje.Name = "lblPorcentaje";
            lblPorcentaje.Size = new Size(12, 15);
            lblPorcentaje.TabIndex = 14;
            lblPorcentaje.Text = "?";
            // 
            // FrmReporteInscripcionesPeriodo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(102, 97, 130);
            ClientSize = new Size(304, 366);
            Controls.Add(lblPorcentaje);
            Controls.Add(lbl4);
            Controls.Add(lblCantidadInscriptos);
            Controls.Add(lblFechaFinal);
            Controls.Add(lblFechaInicio);
            Controls.Add(panel2);
            Controls.Add(label5);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(panel1);
            Name = "FrmReporteInscripcionesPeriodo";
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
        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private Label label5;
        private Label label7;
        private Panel panel2;
        private Label lblFechaInicio;
        private Label lblFechaFinal;
        private Label lblCantidadInscriptos;
        private Button btnDescargarPDF;
        private Label lbl4;
        private Label lblPorcentaje;
    }
}