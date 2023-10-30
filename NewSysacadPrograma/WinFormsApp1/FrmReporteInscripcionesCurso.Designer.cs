namespace NewSysacadFront
{
    partial class FrmReporteInscripcionesCurso
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
            label3 = new Label();
            label5 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            lblCurso = new Label();
            lblCantidad = new Label();
            label4 = new Label();
            txbNombres = new TextBox();
            label1 = new Label();
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(12, 96);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 4;
            label3.Text = "Cantidad:";
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
            label7.Text = "INFORME: inscriptos en curso";
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
            // lblCurso
            // 
            lblCurso.AutoSize = true;
            lblCurso.ForeColor = Color.Brown;
            lblCurso.Location = new Point(247, 69);
            lblCurso.Name = "lblCurso";
            lblCurso.Size = new Size(12, 15);
            lblCurso.TabIndex = 10;
            lblCurso.Text = "?";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.ForeColor = Color.Brown;
            lblCantidad.Location = new Point(247, 96);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(12, 15);
            lblCantidad.TabIndex = 12;
            lblCantidad.Text = "?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkRed;
            label4.Location = new Point(12, 121);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 13;
            label4.Text = "Inscriptos:";
            // 
            // txbNombres
            // 
            txbNombres.BackColor = Color.FromArgb(102, 97, 140);
            txbNombres.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txbNombres.ForeColor = Color.DarkRed;
            txbNombres.Location = new Point(12, 152);
            txbNombres.Multiline = true;
            txbNombres.Name = "txbNombres";
            txbNombres.ReadOnly = true;
            txbNombres.ScrollBars = ScrollBars.Vertical;
            txbNombres.Size = new Size(280, 143);
            txbNombres.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(12, 69);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 2;
            label1.Text = "Curso:";
            // 
            // FrmReporteInscripcionesCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(102, 97, 130);
            ClientSize = new Size(304, 366);
            Controls.Add(txbNombres);
            Controls.Add(label4);
            Controls.Add(lblCantidad);
            Controls.Add(lblCurso);
            Controls.Add(panel2);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "FrmReporteInscripcionesCurso";
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
        private Label label3;
        private Label label5;
        private Label label7;
        private Panel panel2;
        private Label lblCurso;
        private Label lblCantidad;
        private Button btnDescargarPDF;
        private Label label4;
        private TextBox txbNombres;
        private Label label1;
    }
}