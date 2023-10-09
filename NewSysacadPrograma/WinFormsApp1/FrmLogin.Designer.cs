namespace NewSysacadFront
{
    partial class FrmLogin
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
            lblNewSysacad = new Label();
            btnIngreso = new Button();
            pictureBox1 = new PictureBox();
            tbxNombreUsuario = new TextBox();
            txbPassword = new TextBox();
            cbxUsuario = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(102, 97, 130);
            panel1.Controls.Add(lblNewSysacad);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(384, 81);
            panel1.TabIndex = 0;
            // 
            // lblNewSysacad
            // 
            lblNewSysacad.Dock = DockStyle.Fill;
            lblNewSysacad.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNewSysacad.ForeColor = Color.DarkRed;
            lblNewSysacad.Location = new Point(0, 0);
            lblNewSysacad.Name = "lblNewSysacad";
            lblNewSysacad.Size = new Size(384, 81);
            lblNewSysacad.TabIndex = 0;
            lblNewSysacad.Text = "NewSysacad";
            lblNewSysacad.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnIngreso
            // 
            btnIngreso.Dock = DockStyle.Bottom;
            btnIngreso.FlatAppearance.BorderSize = 0;
            btnIngreso.FlatAppearance.MouseDownBackColor = Color.Coral;
            btnIngreso.FlatAppearance.MouseOverBackColor = Color.FromArgb(102, 97, 130);
            btnIngreso.FlatStyle = FlatStyle.Flat;
            btnIngreso.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngreso.ForeColor = Color.DarkRed;
            btnIngreso.Location = new Point(0, 363);
            btnIngreso.Name = "btnIngreso";
            btnIngreso.Size = new Size(384, 98);
            btnIngreso.TabIndex = 1;
            btnIngreso.Text = "Ingresar";
            btnIngreso.UseVisualStyleBackColor = true;
            btnIngreso.Click += btnIngreso_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.UTN;
            pictureBox1.Location = new Point(150, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // tbxNombreUsuario
            // 
            tbxNombreUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbxNombreUsuario.Location = new Point(125, 224);
            tbxNombreUsuario.Name = "tbxNombreUsuario";
            tbxNombreUsuario.PlaceholderText = "Usuario";
            tbxNombreUsuario.Size = new Size(150, 27);
            tbxNombreUsuario.TabIndex = 3;
            tbxNombreUsuario.TextAlign = HorizontalAlignment.Center;
            // 
            // txbPassword
            // 
            txbPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txbPassword.Location = new Point(125, 277);
            txbPassword.Name = "txbPassword";
            txbPassword.PasswordChar = '*';
            txbPassword.PlaceholderText = "Password";
            txbPassword.Size = new Size(150, 27);
            txbPassword.TabIndex = 4;
            txbPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // cbxUsuario
            // 
            cbxUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbxUsuario.Items.AddRange(new object[] { "Estudiante", "Administrador" });
            cbxUsuario.Location = new Point(125, 329);
            cbxUsuario.Name = "cbxUsuario";
            cbxUsuario.Size = new Size(150, 28);
            cbxUsuario.TabIndex = 3;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(125, 121, 163);
            ClientSize = new Size(384, 461);
            Controls.Add(cbxUsuario);
            Controls.Add(txbPassword);
            Controls.Add(tbxNombreUsuario);
            Controls.Add(pictureBox1);
            Controls.Add(btnIngreso);
            Controls.Add(panel1);
            MaximumSize = new Size(400, 500);
            MinimumSize = new Size(400, 500);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingresar";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnIngreso;
        private Label lblNewSysacad;
        private PictureBox pictureBox1;
        private TextBox tbxNombreUsuario;
        private TextBox txbPassword;
        private ComboBox cbxUsuario;
    }
}