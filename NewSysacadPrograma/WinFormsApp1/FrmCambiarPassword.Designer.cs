namespace NewSysacadFront
{
    partial class FrmCambiarPassword
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
            pictureBox1 = new PictureBox();
            txbNuevoPass2 = new TextBox();
            panel2 = new Panel();
            btnCambiar = new Button();
            txbNuevoPass1 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(124, 114, 140);
            panel1.Controls.Add(lblNewSysacad);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(384, 188);
            panel1.TabIndex = 0;
            // 
            // lblNewSysacad
            // 
            lblNewSysacad.Dock = DockStyle.Top;
            lblNewSysacad.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNewSysacad.ForeColor = Color.DarkRed;
            lblNewSysacad.Location = new Point(0, 0);
            lblNewSysacad.Name = "lblNewSysacad";
            lblNewSysacad.Size = new Size(384, 64);
            lblNewSysacad.TabIndex = 4;
            lblNewSysacad.Text = "Cambiar Password";
            lblNewSysacad.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.UTN;
            pictureBox1.Location = new Point(144, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // txbNuevoPass2
            // 
            txbNuevoPass2.Location = new Point(116, 291);
            txbNuevoPass2.Name = "txbNuevoPass2";
            txbNuevoPass2.PasswordChar = '*';
            txbNuevoPass2.PlaceholderText = "Nuevo password";
            txbNuevoPass2.Size = new Size(153, 23);
            txbNuevoPass2.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCambiar);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 376);
            panel2.Name = "panel2";
            panel2.Size = new Size(384, 85);
            panel2.TabIndex = 3;
            // 
            // btnCambiar
            // 
            btnCambiar.BackColor = Color.Gray;
            btnCambiar.FlatAppearance.MouseDownBackColor = Color.Coral;
            btnCambiar.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            btnCambiar.FlatStyle = FlatStyle.Flat;
            btnCambiar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCambiar.ForeColor = Color.FromArgb(32, 29, 33);
            btnCambiar.Location = new Point(124, 3);
            btnCambiar.Name = "btnCambiar";
            btnCambiar.Size = new Size(139, 74);
            btnCambiar.TabIndex = 2;
            btnCambiar.Text = "Cambiar";
            btnCambiar.UseVisualStyleBackColor = false;
            btnCambiar.Click += btnCambiar_Click;
            // 
            // txbNuevoPass1
            // 
            txbNuevoPass1.Location = new Point(116, 238);
            txbNuevoPass1.Name = "txbNuevoPass1";
            txbNuevoPass1.PasswordChar = '*';
            txbNuevoPass1.PlaceholderText = "Nuevo password";
            txbNuevoPass1.Size = new Size(153, 23);
            txbNuevoPass1.TabIndex = 4;
            // 
            // FrmCambiarPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 29, 33);
            ClientSize = new Size(384, 461);
            Controls.Add(txbNuevoPass1);
            Controls.Add(panel2);
            Controls.Add(txbNuevoPass2);
            Controls.Add(panel1);
            Name = "FrmCambiarPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cambiar Password";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lblNewSysacad;
        private TextBox txbNuevoPass2;
        private Panel panel2;
        private Button btnCambiar;
        private TextBox txbNuevoPass1;
    }
}