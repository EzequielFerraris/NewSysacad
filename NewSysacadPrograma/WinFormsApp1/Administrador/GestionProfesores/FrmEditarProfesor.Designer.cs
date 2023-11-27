namespace NewSysacadFront
{
    partial class FrmEditarProfesor
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
            lblArea = new Label();
            txbArea = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.FromArgb(158, 153, 186);
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.Brown;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(584, 80);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Editar Perfil Profesor";
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
            // txbAltura
            // 
            txbAltura.Location = new Point(395, 113);
            txbAltura.Name = "txbAltura";
            txbAltura.Size = new Size(175, 23);
            txbAltura.TabIndex = 25;
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.ForeColor = Color.DarkRed;
            lblAltura.Location = new Point(298, 116);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(42, 15);
            lblAltura.TabIndex = 32;
            lblAltura.Text = "Altura:";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.ForeColor = Color.DarkRed;
            lblDireccion.Location = new Point(298, 74);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(36, 15);
            lblDireccion.TabIndex = 31;
            lblDireccion.Text = "Calle:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.ForeColor = Color.DarkRed;
            lblTelefono.Location = new Point(22, 239);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(55, 15);
            lblTelefono.TabIndex = 30;
            lblTelefono.Text = "Teléfono:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.ForeColor = Color.DarkRed;
            lblEmail.Location = new Point(22, 195);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 29;
            lblEmail.Text = "E-mail:";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.ForeColor = Color.DarkRed;
            lblDni.Location = new Point(22, 158);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(30, 15);
            lblDni.TabIndex = 28;
            lblDni.Text = "DNI:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.ForeColor = Color.DarkRed;
            lblApellido.Location = new Point(22, 74);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(54, 15);
            lblApellido.TabIndex = 27;
            lblApellido.Text = "Apellido:";
            // 
            // lblNomble
            // 
            lblNomble.AutoSize = true;
            lblNomble.ForeColor = Color.DarkRed;
            lblNomble.Location = new Point(22, 116);
            lblNomble.Name = "lblNomble";
            lblNomble.Size = new Size(54, 15);
            lblNomble.TabIndex = 26;
            lblNomble.Text = "Nombre:";
            // 
            // txbCalle
            // 
            txbCalle.Location = new Point(395, 74);
            txbCalle.Name = "txbCalle";
            txbCalle.Size = new Size(175, 23);
            txbCalle.TabIndex = 24;
            // 
            // txbTelefono
            // 
            txbTelefono.Location = new Point(99, 239);
            txbTelefono.Name = "txbTelefono";
            txbTelefono.Size = new Size(175, 23);
            txbTelefono.TabIndex = 23;
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(99, 195);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(175, 23);
            txbEmail.TabIndex = 22;
            // 
            // txbDni
            // 
            txbDni.Location = new Point(99, 158);
            txbDni.Name = "txbDni";
            txbDni.Size = new Size(175, 23);
            txbDni.TabIndex = 21;
            // 
            // txbNombre
            // 
            txbNombre.Location = new Point(99, 116);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(175, 23);
            txbNombre.TabIndex = 20;
            // 
            // txbApellido
            // 
            txbApellido.Location = new Point(99, 74);
            txbApellido.Name = "txbApellido";
            txbApellido.Size = new Size(175, 23);
            txbApellido.TabIndex = 19;
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.ForeColor = Color.DarkRed;
            lblArea.Location = new Point(298, 158);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(34, 15);
            lblArea.TabIndex = 33;
            lblArea.Text = "Área:";
            // 
            // txbArea
            // 
            txbArea.Location = new Point(395, 158);
            txbArea.Name = "txbArea";
            txbArea.Size = new Size(175, 23);
            txbArea.TabIndex = 34;
            // 
            // FrmEditarProfesor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(158, 153, 186);
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
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximumSize = new Size(600, 400);
            MinimumSize = new Size(600, 400);
            Name = "FrmEditarProfesor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Perfil Profesor";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Panel panel1;
        private Button btnCancelar;
        private Button btnModificar;
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
        private Label lblArea;
        private TextBox txbArea;
    }
}