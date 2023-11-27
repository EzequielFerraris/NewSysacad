namespace NewSysacadFront
{
    partial class FrmNotificacion
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
            btnMarcarLeida = new Button();
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
            pnl2.Controls.Add(btnMarcarLeida);
            pnl2.Controls.Add(txbDescripcion);
            pnl2.Dock = DockStyle.Left;
            pnl2.Location = new Point(159, 0);
            pnl2.Name = "pnl2";
            pnl2.Size = new Size(423, 73);
            pnl2.TabIndex = 1;
            // 
            // btnMarcarLeida
            // 
            btnMarcarLeida.BackColor = Color.FromArgb(124, 114, 140);
            btnMarcarLeida.Dock = DockStyle.Fill;
            btnMarcarLeida.FlatAppearance.BorderSize = 0;
            btnMarcarLeida.FlatAppearance.MouseDownBackColor = Color.Coral;
            btnMarcarLeida.FlatAppearance.MouseOverBackColor = Color.FromArgb(125, 121, 163);
            btnMarcarLeida.FlatStyle = FlatStyle.Flat;
            btnMarcarLeida.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMarcarLeida.ForeColor = Color.FromArgb(32, 29, 33);
            btnMarcarLeida.Location = new Point(330, 0);
            btnMarcarLeida.Name = "btnMarcarLeida";
            btnMarcarLeida.Size = new Size(93, 73);
            btnMarcarLeida.TabIndex = 27;
            btnMarcarLeida.Text = "MARCAR COMO LEÍDA";
            btnMarcarLeida.UseVisualStyleBackColor = false;
            btnMarcarLeida.Click += btnMarcarLeida_Click;
            // 
            // txbDescripcion
            // 
            txbDescripcion.BackColor = Color.FromArgb(124, 114, 140);
            txbDescripcion.Dock = DockStyle.Left;
            txbDescripcion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txbDescripcion.ForeColor = Color.FromArgb(32, 29, 33);
            txbDescripcion.Location = new Point(0, 0);
            txbDescripcion.Multiline = true;
            txbDescripcion.Name = "txbDescripcion";
            txbDescripcion.ReadOnly = true;
            txbDescripcion.ScrollBars = ScrollBars.Vertical;
            txbDescripcion.Size = new Size(330, 73);
            txbDescripcion.TabIndex = 1;
            // 
            // pnl1
            // 
            pnl1.BackColor = Color.FromArgb(124, 114, 140);
            pnl1.Controls.Add(txbTitulo);
            pnl1.Dock = DockStyle.Left;
            pnl1.Location = new Point(0, 0);
            pnl1.Name = "pnl1";
            pnl1.Size = new Size(159, 73);
            pnl1.TabIndex = 0;
            // 
            // txbTitulo
            // 
            txbTitulo.BackColor = Color.FromArgb(124, 114, 140);
            txbTitulo.Dock = DockStyle.Fill;
            txbTitulo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txbTitulo.ForeColor = Color.FromArgb(32, 29, 33);
            txbTitulo.Location = new Point(0, 0);
            txbTitulo.Multiline = true;
            txbTitulo.Name = "txbTitulo";
            txbTitulo.ReadOnly = true;
            txbTitulo.ScrollBars = ScrollBars.Vertical;
            txbTitulo.Size = new Size(159, 73);
            txbTitulo.TabIndex = 2;
            // 
            // FrmNotificacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 29, 33);
            ClientSize = new Size(584, 78);
            Controls.Add(pnlMain);
            ForeColor = Color.Gainsboro;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmNotificacion";
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
        private TextBox txbDescripcion;
        private Button btnMarcarLeida;
        private Panel pnl1;
        private TextBox txbTitulo;
    }
}