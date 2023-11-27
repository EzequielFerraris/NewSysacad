namespace NewSysacadFront
{
    partial class FrmListaNotificaciones
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
            pnlListaNotificaciones = new Panel();
            pnlTitulo.SuspendLayout();
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
            lblTitulo.Text = "Notificaciones:";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlListaNotificaciones
            // 
            pnlListaNotificaciones.AutoScroll = true;
            pnlListaNotificaciones.Dock = DockStyle.Fill;
            pnlListaNotificaciones.Location = new Point(0, 60);
            pnlListaNotificaciones.Margin = new Padding(4);
            pnlListaNotificaciones.Name = "pnlListaNotificaciones";
            pnlListaNotificaciones.Padding = new Padding(3);
            pnlListaNotificaciones.Size = new Size(584, 401);
            pnlListaNotificaciones.TabIndex = 5;
            // 
            // FrmListaNotificaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 29, 33);
            ClientSize = new Size(584, 461);
            Controls.Add(pnlListaNotificaciones);
            Controls.Add(pnlTitulo);
            ForeColor = Color.Gainsboro;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmListaNotificaciones";
            Text = "FrmPagos";
            pnlTitulo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo;
        private Label lblTitulo;
        private Panel pnlListaNotificaciones;
    }
}