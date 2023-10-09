namespace NewSysacadFront
{
    partial class FrmPagosRealizados
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
            pnlListaPagosRealizados = new Panel();
            pnlTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(568, 60);
            pnlTitulo.TabIndex = 2;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.Gainsboro;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Padding = new Padding(15, 0, 0, 0);
            lblTitulo.Size = new Size(568, 60);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Pagos realizados";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlListaPagosRealizados
            // 
            pnlListaPagosRealizados.AutoScroll = true;
            pnlListaPagosRealizados.Dock = DockStyle.Fill;
            pnlListaPagosRealizados.Location = new Point(0, 60);
            pnlListaPagosRealizados.Margin = new Padding(4);
            pnlListaPagosRealizados.Name = "pnlListaPagosRealizados";
            pnlListaPagosRealizados.Padding = new Padding(3);
            pnlListaPagosRealizados.Size = new Size(568, 362);
            pnlListaPagosRealizados.TabIndex = 6;
            // 
            // FrmPagosRealizados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 29, 33);
            ClientSize = new Size(568, 422);
            Controls.Add(pnlListaPagosRealizados);
            Controls.Add(pnlTitulo);
            ForeColor = Color.Gainsboro;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPagosRealizados";
            Text = "PagosRealizados";
            pnlTitulo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo;
        private Label lblTitulo;
        private Panel pnlListaPagosRealizados;
    }
}