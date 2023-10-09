namespace NewSysacadFront
{
    partial class FrmEditarCurso
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
            btnCancelar = new Button();
            btnModificar = new Button();
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
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Editar Curso";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnModificar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 281);
            panel1.Name = "panel1";
            panel1.Size = new Size(584, 80);
            panel1.TabIndex = 3;
            // 
            // btnCancelar
            // 
            btnCancelar.Dock = DockStyle.Right;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.Coral;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(102, 97, 130);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.Brown;
            btnCancelar.Location = new Point(0, 0);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(292, 80);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Dock = DockStyle.Right;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatAppearance.MouseDownBackColor = Color.Coral;
            btnModificar.FlatAppearance.MouseOverBackColor = Color.FromArgb(102, 97, 130);
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.Brown;
            btnModificar.Location = new Point(292, 0);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(292, 80);
            btnModificar.TabIndex = 0;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // txbNombre
            // 
            txbNombre.Location = new Point(157, 83);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(135, 23);
            txbNombre.TabIndex = 4;
            // 
            // txbCodigo
            // 
            txbCodigo.Location = new Point(157, 120);
            txbCodigo.Name = "txbCodigo";
            txbCodigo.Size = new Size(135, 23);
            txbCodigo.TabIndex = 5;
            // 
            // txbCupoMax
            // 
            txbCupoMax.Location = new Point(157, 157);
            txbCupoMax.Name = "txbCupoMax";
            txbCupoMax.Size = new Size(135, 23);
            txbCupoMax.TabIndex = 6;
            // 
            // txbDescripcion
            // 
            txbDescripcion.Location = new Point(331, 101);
            txbDescripcion.Multiline = true;
            txbDescripcion.Name = "txbDescripcion";
            txbDescripcion.Size = new Size(187, 155);
            txbDescripcion.TabIndex = 7;
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(50, 80);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(54, 15);
            lbNombre.TabIndex = 8;
            lbNombre.Text = "Nombre:";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(50, 120);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(49, 15);
            lblCodigo.TabIndex = 9;
            lblCodigo.Text = "Código:";
            // 
            // lbCupoMaximo
            // 
            lbCupoMaximo.AutoSize = true;
            lbCupoMaximo.Location = new Point(50, 157);
            lbCupoMaximo.Name = "lbCupoMaximo";
            lbCupoMaximo.Size = new Size(86, 15);
            lbCupoMaximo.TabIndex = 10;
            lbCupoMaximo.Text = "Cupo máximo:";
            // 
            // lbDescripcion
            // 
            lbDescripcion.AutoSize = true;
            lbDescripcion.Location = new Point(331, 80);
            lbDescripcion.Name = "lbDescripcion";
            lbDescripcion.Size = new Size(72, 15);
            lbDescripcion.TabIndex = 11;
            lbDescripcion.Text = "Descripción:";
            // 
            // cbxDia
            // 
            cbxDia.FormattingEnabled = true;
            cbxDia.Location = new Point(157, 195);
            cbxDia.Name = "cbxDia";
            cbxDia.Size = new Size(135, 23);
            cbxDia.TabIndex = 12;
            // 
            // cbxTurno
            // 
            cbxTurno.FormattingEnabled = true;
            cbxTurno.Location = new Point(157, 233);
            cbxTurno.Name = "cbxTurno";
            cbxTurno.Size = new Size(135, 23);
            cbxTurno.TabIndex = 13;
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.Location = new Point(50, 195);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(87, 15);
            lblDia.TabIndex = 14;
            lblDia.Text = "Día de cursada:";
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Location = new Point(50, 233);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(41, 15);
            lblTurno.TabIndex = 15;
            lblTurno.Text = "Turno:";
            // 
            // FrmEditarCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(102, 97, 130);
            ClientSize = new Size(584, 361);
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
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximumSize = new Size(600, 400);
            MinimumSize = new Size(600, 400);
            Name = "FrmEditarCurso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Curso";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Panel panel1;
        private Button btnCancelar;
        private Button btnModificar;
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
    }
}