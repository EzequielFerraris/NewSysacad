namespace NewSysacadFront
{
    partial class FrmCrearNotificacion
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
            lblTitulo = new Label();
            panel1 = new Panel();
            btnRegistrar = new Button();
            txbTitulo = new TextBox();
            txbDescripcion = new TextBox();
            lbl1 = new Label();
            lblCodigo = new Label();
            lbCupoMaximo = new Label();
            lbDescripcion = new Label();
            lblDia = new Label();
            lblTurno = new Label();
            lbl6 = new Label();
            cbxCarrera = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.Brown;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(584, 80);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Agregar Notificación";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnRegistrar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 281);
            panel1.Name = "panel1";
            panel1.Size = new Size(584, 80);
            panel1.TabIndex = 2;
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
            btnRegistrar.TabIndex = 6;
            btnRegistrar.TabStop = false;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txbTitulo
            // 
            txbTitulo.Location = new Point(66, 83);
            txbTitulo.Name = "txbTitulo";
            txbTitulo.Size = new Size(135, 23);
            txbTitulo.TabIndex = 0;
            // 
            // txbDescripcion
            // 
            txbDescripcion.Location = new Point(314, 103);
            txbDescripcion.Multiline = true;
            txbDescripcion.Name = "txbDescripcion";
            txbDescripcion.Size = new Size(239, 159);
            txbDescripcion.TabIndex = 5;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.ForeColor = Color.DarkRed;
            lbl1.Location = new Point(12, 83);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(40, 15);
            lbl1.TabIndex = 7;
            lbl1.Text = "Titulo:";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.ForeColor = Color.DarkRed;
            lblCodigo.Location = new Point(38, 121);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(0, 15);
            lblCodigo.TabIndex = 8;
            // 
            // lbCupoMaximo
            // 
            lbCupoMaximo.AutoSize = true;
            lbCupoMaximo.ForeColor = Color.DarkRed;
            lbCupoMaximo.Location = new Point(38, 161);
            lbCupoMaximo.Name = "lbCupoMaximo";
            lbCupoMaximo.Size = new Size(0, 15);
            lbCupoMaximo.TabIndex = 9;
            // 
            // lbDescripcion
            // 
            lbDescripcion.AutoSize = true;
            lbDescripcion.ForeColor = Color.DarkRed;
            lbDescripcion.Location = new Point(314, 80);
            lbDescripcion.Name = "lbDescripcion";
            lbDescripcion.Size = new Size(72, 15);
            lbDescripcion.TabIndex = 10;
            lbDescripcion.Text = "Descripción:";
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.ForeColor = Color.DarkRed;
            lblDia.Location = new Point(38, 200);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(0, 15);
            lblDia.TabIndex = 13;
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.ForeColor = Color.DarkRed;
            lblTurno.Location = new Point(38, 239);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(0, 15);
            lblTurno.TabIndex = 14;
            // 
            // lbl6
            // 
            lbl6.AutoSize = true;
            lbl6.ForeColor = Color.DarkRed;
            lbl6.Location = new Point(12, 136);
            lbl6.Name = "lbl6";
            lbl6.Size = new Size(48, 15);
            lbl6.TabIndex = 15;
            lbl6.Text = "Carrera:";
            // 
            // cbxCarrera
            // 
            cbxCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCarrera.FormattingEnabled = true;
            cbxCarrera.Items.AddRange(new object[] { "Tec. Univ. en Programación", "Tec. Univ. en Sistemas", "Licenciatura en Sistemas", "Ingeniería en Sistemas" });
            cbxCarrera.Location = new Point(66, 136);
            cbxCarrera.Name = "cbxCarrera";
            cbxCarrera.Size = new Size(210, 23);
            cbxCarrera.TabIndex = 16;
            // 
            // FrmCrearNotificacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(102, 97, 130);
            ClientSize = new Size(584, 361);
            Controls.Add(cbxCarrera);
            Controls.Add(lbl6);
            Controls.Add(lblTurno);
            Controls.Add(lblDia);
            Controls.Add(lbDescripcion);
            Controls.Add(lbCupoMaximo);
            Controls.Add(lblCodigo);
            Controls.Add(lbl1);
            Controls.Add(txbDescripcion);
            Controls.Add(txbTitulo);
            Controls.Add(panel1);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(584, 361);
            MinimumSize = new Size(584, 361);
            Name = "FrmCrearNotificacion";
            Text = "FrmAgregarCurso";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Panel panel1;
        private Button btnRegistrar;
        private TextBox txbTitulo;
        private TextBox txbDescripcion;
        private Label lbl1;
        private Label lblCodigo;
        private Label lbCupoMaximo;
        private Label lbDescripcion;
        private Label lblDia;
        private Label lblTurno;
        private Label lbl6;
        private ComboBox cbxCarrera;
    }
}