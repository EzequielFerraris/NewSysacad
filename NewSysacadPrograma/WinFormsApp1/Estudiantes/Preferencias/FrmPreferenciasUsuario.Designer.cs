namespace NewSysacadFront
{
    partial class FrmPreferenciasUsuario
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
            pnlTitulo = new Panel();
            lblTitulo = new Label();
            pnlListaPreferencias = new Panel();
            btnGuardar = new Button();
            chbxMails = new CheckBox();
            chbxNotificaciones = new CheckBox();
            label2 = new Label();
            label1 = new Label();
            pnlTitulo.SuspendLayout();
            pnlListaPreferencias.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(584, 60);
            pnlTitulo.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.Gainsboro;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Padding = new Padding(15, 0, 0, 0);
            lblTitulo.Size = new Size(584, 60);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Preferencias del usuario:";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlListaPreferencias
            // 
            pnlListaPreferencias.AutoScroll = true;
            pnlListaPreferencias.Controls.Add(btnGuardar);
            pnlListaPreferencias.Controls.Add(chbxMails);
            pnlListaPreferencias.Controls.Add(chbxNotificaciones);
            pnlListaPreferencias.Controls.Add(label2);
            pnlListaPreferencias.Controls.Add(label1);
            pnlListaPreferencias.Dock = DockStyle.Fill;
            pnlListaPreferencias.Location = new Point(0, 60);
            pnlListaPreferencias.Margin = new Padding(4);
            pnlListaPreferencias.Name = "pnlListaPreferencias";
            pnlListaPreferencias.Padding = new Padding(3);
            pnlListaPreferencias.Size = new Size(584, 401);
            pnlListaPreferencias.TabIndex = 5;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Gray;
            btnGuardar.FlatAppearance.MouseDownBackColor = Color.Coral;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.Location = new Point(418, 329);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(154, 60);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // chbxMails
            // 
            chbxMails.AutoSize = true;
            chbxMails.Location = new Point(327, 92);
            chbxMails.Name = "chbxMails";
            chbxMails.Size = new Size(54, 19);
            chbxMails.TabIndex = 6;
            chbxMails.Text = "Mails";
            chbxMails.UseVisualStyleBackColor = true;
        
            // 
            // chbxNotificaciones
            // 
            chbxNotificaciones.AutoSize = true;
            chbxNotificaciones.Location = new Point(327, 41);
            chbxNotificaciones.Name = "chbxNotificaciones";
            chbxNotificaciones.Size = new Size(102, 19);
            chbxNotificaciones.TabIndex = 5;
            chbxNotificaciones.Text = "Notificaciones";
            chbxNotificaciones.UseVisualStyleBackColor = true;
           
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(28, 92);
            label2.Name = "label2";
            label2.Size = new Size(243, 15);
            label2.TabIndex = 4;
            label2.Text = "Recibir notificaciones por correo electrónico:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(28, 41);
            label1.Name = "label1";
            label1.Size = new Size(199, 15);
            label1.TabIndex = 3;
            label1.Text = "Recibir notificaciones por el sistema:";
            // 
            // FrmPreferenciasUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 29, 33);
            ClientSize = new Size(584, 461);
            Controls.Add(pnlListaPreferencias);
            Controls.Add(pnlTitulo);
            ForeColor = Color.Gainsboro;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPreferenciasUsuario";
            Text = "FrmPagos";
            pnlTitulo.ResumeLayout(false);
            pnlListaPreferencias.ResumeLayout(false);
            pnlListaPreferencias.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo;
        private Label lblTitulo;
        private Panel pnlListaPreferencias;
        private CheckBox chbxMails;
        private CheckBox chbxNotificaciones;
        private Label label2;
        private Label label1;
        private Button btnGuardar;
    }
}