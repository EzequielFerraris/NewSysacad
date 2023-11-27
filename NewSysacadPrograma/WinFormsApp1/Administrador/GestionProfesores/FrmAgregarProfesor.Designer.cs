namespace NewSysacadFront
{
    partial class FrmAgregarProfesor
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
            panelTop = new Panel();
            lblTitulo = new Label();
            panel1 = new Panel();
            btnRegistrar = new Button();
            txbArea = new TextBox();
            lblArea = new Label();
            txbAltura = new TextBox();
            lblAltura = new Label();
            lblDireccion = new Label();
            lblTelefono = new Label();
            lblEmail = new Label();
            lblDni = new Label();
            lblApellido = new Label();
            lblNomble = new Label();
            txbCalle = new TextBox();
            txbTelefono = new TextBox();
            txbEmail = new TextBox();
            txbDni = new TextBox();
            txbNombre = new TextBox();
            txbApellido = new TextBox();
            panelTop.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(lblTitulo);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(584, 80);
            panelTop.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.Brown;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(584, 80);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Agregar Profesor";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnRegistrar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 281);
            panel1.Name = "panel1";
            panel1.Size = new Size(584, 80);
            panel1.TabIndex = 1;
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
            btnRegistrar.TabIndex = 11;
            btnRegistrar.TabStop = false;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txbArea
            // 
            txbArea.Location = new Point(391, 170);
            txbArea.Name = "txbArea";
            txbArea.Size = new Size(175, 23);
            txbArea.TabIndex = 50;
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.ForeColor = Color.DarkRed;
            lblArea.Location = new Point(294, 170);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(34, 15);
            lblArea.TabIndex = 49;
            lblArea.Text = "Área:";
            // 
            // txbAltura
            // 
            txbAltura.Location = new Point(391, 125);
            txbAltura.Name = "txbAltura";
            txbAltura.Size = new Size(175, 23);
            txbAltura.TabIndex = 41;
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.ForeColor = Color.DarkRed;
            lblAltura.Location = new Point(294, 128);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(42, 15);
            lblAltura.TabIndex = 48;
            lblAltura.Text = "Altura:";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.ForeColor = Color.DarkRed;
            lblDireccion.Location = new Point(294, 86);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(36, 15);
            lblDireccion.TabIndex = 47;
            lblDireccion.Text = "Calle:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.ForeColor = Color.DarkRed;
            lblTelefono.Location = new Point(18, 251);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(55, 15);
            lblTelefono.TabIndex = 46;
            lblTelefono.Text = "Teléfono:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.ForeColor = Color.DarkRed;
            lblEmail.Location = new Point(18, 207);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 45;
            lblEmail.Text = "E-mail:";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.ForeColor = Color.DarkRed;
            lblDni.Location = new Point(18, 170);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(30, 15);
            lblDni.TabIndex = 44;
            lblDni.Text = "DNI:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.ForeColor = Color.DarkRed;
            lblApellido.Location = new Point(18, 86);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(54, 15);
            lblApellido.TabIndex = 43;
            lblApellido.Text = "Apellido:";
            // 
            // lblNomble
            // 
            lblNomble.AutoSize = true;
            lblNomble.ForeColor = Color.DarkRed;
            lblNomble.Location = new Point(18, 128);
            lblNomble.Name = "lblNomble";
            lblNomble.Size = new Size(54, 15);
            lblNomble.TabIndex = 42;
            lblNomble.Text = "Nombre:";
            // 
            // txbCalle
            // 
            txbCalle.Location = new Point(391, 86);
            txbCalle.Name = "txbCalle";
            txbCalle.Size = new Size(175, 23);
            txbCalle.TabIndex = 40;
            // 
            // txbTelefono
            // 
            txbTelefono.Location = new Point(95, 251);
            txbTelefono.Name = "txbTelefono";
            txbTelefono.Size = new Size(175, 23);
            txbTelefono.TabIndex = 39;
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(95, 207);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(175, 23);
            txbEmail.TabIndex = 38;
            // 
            // txbDni
            // 
            txbDni.Location = new Point(95, 170);
            txbDni.Name = "txbDni";
            txbDni.Size = new Size(175, 23);
            txbDni.TabIndex = 37;
            // 
            // txbNombre
            // 
            txbNombre.Location = new Point(95, 128);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(175, 23);
            txbNombre.TabIndex = 36;
            // 
            // txbApellido
            // 
            txbApellido.Location = new Point(95, 86);
            txbApellido.Name = "txbApellido";
            txbApellido.Size = new Size(175, 23);
            txbApellido.TabIndex = 35;
            // 
            // FrmAgregarProfesor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(125, 121, 163);
            ClientSize = new Size(584, 361);
            Controls.Add(txbArea);
            Controls.Add(lblArea);
            Controls.Add(txbAltura);
            Controls.Add(lblAltura);
            Controls.Add(lblDireccion);
            Controls.Add(lblTelefono);
            Controls.Add(lblEmail);
            Controls.Add(lblDni);
            Controls.Add(lblApellido);
            Controls.Add(lblNomble);
            Controls.Add(txbCalle);
            Controls.Add(txbTelefono);
            Controls.Add(txbEmail);
            Controls.Add(txbDni);
            Controls.Add(txbNombre);
            Controls.Add(txbApellido);
            Controls.Add(panel1);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(584, 361);
            MinimumSize = new Size(584, 361);
            Name = "FrmAgregarProfesor";
            Text = "FrmAgregarEstudiante";
            panelTop.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTop;
        private Label lblTitulo;
        private Panel panel1;
        private Button btnRegistrar;
        private TextBox txbArea;
        private Label lblArea;
        private TextBox txbAltura;
        private Label lblAltura;
        private Label lblDireccion;
        private Label lblTelefono;
        private Label lblEmail;
        private Label lblDni;
        private Label lblApellido;
        private Label lblNomble;
        private TextBox txbCalle;
        private TextBox txbTelefono;
        private TextBox txbEmail;
        private TextBox txbDni;
        private TextBox txbNombre;
        private TextBox txbApellido;
    }
}