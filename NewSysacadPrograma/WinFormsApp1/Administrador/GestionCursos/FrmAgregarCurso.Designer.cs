namespace NewSysacadFront
{
    partial class FrmAgregarCurso
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
            txbNombre = new TextBox();
            txbCodigo = new TextBox();
            txbCupoMax = new TextBox();
            txbDescripcion = new TextBox();
            lbNombre = new Label();
            lblCodigo = new Label();
            lbCupoMaximo = new Label();
            lbDescripcion = new Label();
            cbxDia = new ComboBox();
            cbxTurno = new ComboBox();
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
            lblTitulo.Text = "Agregar nuevo Curso";
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
            // txbNombre
            // 
            txbNombre.Location = new Point(130, 83);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(135, 23);
            txbNombre.TabIndex = 0;
            // 
            // txbCodigo
            // 
            txbCodigo.Location = new Point(130, 121);
            txbCodigo.Name = "txbCodigo";
            txbCodigo.Size = new Size(135, 23);
            txbCodigo.TabIndex = 1;
            // 
            // txbCupoMax
            // 
            txbCupoMax.Location = new Point(130, 161);
            txbCupoMax.Name = "txbCupoMax";
            txbCupoMax.Size = new Size(135, 23);
            txbCupoMax.TabIndex = 2;
            // 
            // txbDescripcion
            // 
            txbDescripcion.Location = new Point(371, 156);
            txbDescripcion.Multiline = true;
            txbDescripcion.Name = "txbDescripcion";
            txbDescripcion.Size = new Size(182, 106);
            txbDescripcion.TabIndex = 5;
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.ForeColor = Color.DarkRed;
            lbNombre.Location = new Point(38, 83);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(54, 15);
            lbNombre.TabIndex = 7;
            lbNombre.Text = "Nombre:";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.ForeColor = Color.DarkRed;
            lblCodigo.Location = new Point(38, 121);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(49, 15);
            lblCodigo.TabIndex = 8;
            lblCodigo.Text = "Código:";
            // 
            // lbCupoMaximo
            // 
            lbCupoMaximo.AutoSize = true;
            lbCupoMaximo.ForeColor = Color.DarkRed;
            lbCupoMaximo.Location = new Point(38, 161);
            lbCupoMaximo.Name = "lbCupoMaximo";
            lbCupoMaximo.Size = new Size(86, 15);
            lbCupoMaximo.TabIndex = 9;
            lbCupoMaximo.Text = "Cupo máximo:";
            // 
            // lbDescripcion
            // 
            lbDescripcion.AutoSize = true;
            lbDescripcion.ForeColor = Color.DarkRed;
            lbDescripcion.Location = new Point(297, 156);
            lbDescripcion.Name = "lbDescripcion";
            lbDescripcion.Size = new Size(72, 15);
            lbDescripcion.TabIndex = 10;
            lbDescripcion.Text = "Descripción:";
            // 
            // cbxDia
            // 
            cbxDia.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxDia.FormattingEnabled = true;
            cbxDia.Location = new Point(130, 200);
            cbxDia.Name = "cbxDia";
            cbxDia.Size = new Size(135, 23);
            cbxDia.TabIndex = 3;
            // 
            // cbxTurno
            // 
            cbxTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTurno.FormattingEnabled = true;
            cbxTurno.Items.AddRange(new object[] { "Mañana", "Tarde", "Noche" });
            cbxTurno.Location = new Point(130, 239);
            cbxTurno.Name = "cbxTurno";
            cbxTurno.Size = new Size(135, 23);
            cbxTurno.TabIndex = 4;
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.ForeColor = Color.DarkRed;
            lblDia.Location = new Point(38, 200);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(87, 15);
            lblDia.TabIndex = 13;
            lblDia.Text = "Día de cursada:";
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.ForeColor = Color.DarkRed;
            lblTurno.Location = new Point(38, 239);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(41, 15);
            lblTurno.TabIndex = 14;
            lblTurno.Text = "Turno:";
            // 
            // lbl6
            // 
            lbl6.AutoSize = true;
            lbl6.ForeColor = Color.DarkRed;
            lbl6.Location = new Point(297, 83);
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
            cbxCarrera.Location = new Point(371, 83);
            cbxCarrera.Name = "cbxCarrera";
            cbxCarrera.Size = new Size(182, 23);
            cbxCarrera.TabIndex = 16;
            // 
            // FrmAgregarCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(102, 97, 130);
            ClientSize = new Size(584, 361);
            Controls.Add(cbxCarrera);
            Controls.Add(lbl6);
            Controls.Add(lblTurno);
            Controls.Add(lblDia);
            Controls.Add(cbxTurno);
            Controls.Add(cbxDia);
            Controls.Add(lbDescripcion);
            Controls.Add(lbCupoMaximo);
            Controls.Add(lblCodigo);
            Controls.Add(lbNombre);
            Controls.Add(txbDescripcion);
            Controls.Add(txbCupoMax);
            Controls.Add(txbCodigo);
            Controls.Add(txbNombre);
            Controls.Add(panel1);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(584, 361);
            MinimumSize = new Size(584, 361);
            Name = "FrmAgregarCurso";
            Text = "FrmAgregarCurso";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Panel panel1;
        private Button btnRegistrar;
        private TextBox txbNombre;
        private TextBox txbCodigo;
        private TextBox txbCupoMax;
        private TextBox txbDescripcion;
        private Label lbNombre;
        private Label lblCodigo;
        private Label lbCupoMaximo;
        private Label lbDescripcion;
        private ComboBox cbxDia;
        private ComboBox cbxTurno;
        private Label lblDia;
        private Label lblTurno;
        private Label lbl6;
        private ComboBox cbxCarrera;
    }
}