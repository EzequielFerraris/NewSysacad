namespace NewSysacadFront
{
    partial class FrmControlReportes
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
            pnlControlReportes = new Panel();
            pnlOpciones = new Panel();
            cbxReportes = new ComboBox();
            pnlTitulo = new Panel();
            lblTitulo = new Label();
            pnlDisplayOpcionesReporte = new Panel();
            pnlControlReportes.SuspendLayout();
            pnlOpciones.SuspendLayout();
            pnlTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // pnlControlReportes
            // 
            pnlControlReportes.Controls.Add(pnlOpciones);
            pnlControlReportes.Controls.Add(pnlTitulo);
            pnlControlReportes.Dock = DockStyle.Top;
            pnlControlReportes.Location = new Point(0, 0);
            pnlControlReportes.Name = "pnlControlReportes";
            pnlControlReportes.Size = new Size(584, 62);
            pnlControlReportes.TabIndex = 0;
            // 
            // pnlOpciones
            // 
            pnlOpciones.Controls.Add(cbxReportes);
            pnlOpciones.Dock = DockStyle.Left;
            pnlOpciones.Location = new Point(244, 0);
            pnlOpciones.Name = "pnlOpciones";
            pnlOpciones.Size = new Size(228, 62);
            pnlOpciones.TabIndex = 1;
            // 
            // cbxReportes
            // 
            cbxReportes.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxReportes.FormattingEnabled = true;
            cbxReportes.Items.AddRange(new object[] { "Inscripciones por período", "Estudiantes inscriptos en curso", "Ingresos", "Inscripción por carrera", "Lista de espera curso" });
            cbxReportes.Location = new Point(22, 23);
            cbxReportes.Name = "cbxReportes";
            cbxReportes.Size = new Size(187, 23);
            cbxReportes.TabIndex = 0;
            cbxReportes.SelectedIndexChanged += cbxReportes_SelectedIndexChanged;
            // 
            // pnlTitulo
            // 
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Dock = DockStyle.Left;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(244, 62);
            pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.Brown;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(244, 62);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Generar informe";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlDisplayOpcionesReporte
            // 
            pnlDisplayOpcionesReporte.Dock = DockStyle.Fill;
            pnlDisplayOpcionesReporte.Location = new Point(0, 62);
            pnlDisplayOpcionesReporte.Name = "pnlDisplayOpcionesReporte";
            pnlDisplayOpcionesReporte.Size = new Size(584, 299);
            pnlDisplayOpcionesReporte.TabIndex = 1;
            // 
            // FrmControlReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(125, 121, 163);
            ClientSize = new Size(584, 361);
            Controls.Add(pnlDisplayOpcionesReporte);
            Controls.Add(pnlControlReportes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmControlReportes";
            Text = "FrmControlReportes";
            pnlControlReportes.ResumeLayout(false);
            pnlOpciones.ResumeLayout(false);
            pnlTitulo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlControlReportes;
        private Panel pnlOpciones;
        private Panel pnlTitulo;
        private Panel pnlDisplayOpcionesReporte;
        private ComboBox cbxReportes;
        private Label lblTitulo;
    }
}