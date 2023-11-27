namespace NewSysacadFront
{
    partial class FrmNotificacionLeida
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
            pnlMain = new Panel();
            pnl2 = new Panel();
            txbDescripcion = new TextBox();
            pnl1 = new Panel();
            txbTitulo = new TextBox();
            pnlMain.SuspendLayout();
            pnl2.SuspendLayout();
            pnl1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BorderStyle = BorderStyle.FixedSingle;
            pnlMain.Controls.Add(pnl2);
            pnlMain.Controls.Add(pnl1);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 3);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(584, 75);
            pnlMain.TabIndex = 1;
            // 
            // pnl2
            // 
            pnl2.Controls.Add(txbDescripcion);
            pnl2.Dock = DockStyle.Left;
            pnl2.Location = new Point(159, 0);
            pnl2.Name = "pnl2";
            pnl2.Size = new Size(420, 73);
            pnl2.TabIndex = 1;
            // 
            // txbDescripcion
            // 
            txbDescripcion.BackColor = Color.FromArgb(32, 29, 33);
            txbDescripcion.Dock = DockStyle.Fill;
            txbDescripcion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txbDescripcion.ForeColor = Color.Gainsboro;
            txbDescripcion.Location = new Point(0, 0);
            txbDescripcion.Multiline = true;
            txbDescripcion.Name = "txbDescripcion";
            txbDescripcion.ReadOnly = true;
            txbDescripcion.ScrollBars = ScrollBars.Vertical;
            txbDescripcion.ShortcutsEnabled = false;
            txbDescripcion.Size = new Size(420, 73);
            txbDescripcion.TabIndex = 1;
            // 
            // pnl1
            // 
            pnl1.Controls.Add(txbTitulo);
            pnl1.Dock = DockStyle.Left;
            pnl1.Location = new Point(0, 0);
            pnl1.Name = "pnl1";
            pnl1.Size = new Size(159, 73);
            pnl1.TabIndex = 0;
            // 
            // txbTitulo
            // 
            txbTitulo.BackColor = Color.FromArgb(32, 29, 33);
            txbTitulo.Dock = DockStyle.Fill;
            txbTitulo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txbTitulo.ForeColor = Color.Gainsboro;
            txbTitulo.Location = new Point(0, 0);
            txbTitulo.Multiline = true;
            txbTitulo.Name = "txbTitulo";
            txbTitulo.ReadOnly = true;
            txbTitulo.ScrollBars = ScrollBars.Vertical;
            txbTitulo.Size = new Size(159, 73);
            txbTitulo.TabIndex = 2;
            // 
            // FrmNotificacionLeida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 29, 33);
            ClientSize = new Size(584, 78);
            Controls.Add(pnlMain);
            ForeColor = Color.Gainsboro;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmNotificacionLeida";
            Padding = new Padding(0, 3, 0, 0);
            Text = "FrmPagoPendiente";
            pnlMain.ResumeLayout(false);
            pnl2.ResumeLayout(false);
            pnl2.PerformLayout();
            pnl1.ResumeLayout(false);
            pnl1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private Panel pnl2;
        private Panel pnl1;
        private TextBox txbDescripcion;
        private TextBox txbTitulo;
    }
}