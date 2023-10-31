namespace NewSysacadFront
{
    partial class FrmPagosPendientes
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
            btnPagar = new Button();
            lblTitulo = new Label();
            pnlListaPagosPendientes = new Panel();
            pnlTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.Controls.Add(btnPagar);
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(584, 60);
            pnlTitulo.TabIndex = 1;
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.Gray;
            btnPagar.Dock = DockStyle.Right;
            btnPagar.FlatAppearance.MouseDownBackColor = Color.Coral;
            btnPagar.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            btnPagar.FlatStyle = FlatStyle.Flat;
            btnPagar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnPagar.ForeColor = Color.FromArgb(32, 29, 33);
            btnPagar.Location = new Point(430, 0);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(154, 60);
            btnPagar.TabIndex = 2;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
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
            lblTitulo.Text = "Pagos pendientes";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlListaPagosPendientes
            // 
            pnlListaPagosPendientes.AutoScroll = true;
            pnlListaPagosPendientes.Dock = DockStyle.Fill;
            pnlListaPagosPendientes.Location = new Point(0, 60);
            pnlListaPagosPendientes.Margin = new Padding(4);
            pnlListaPagosPendientes.Name = "pnlListaPagosPendientes";
            pnlListaPagosPendientes.Padding = new Padding(3);
            pnlListaPagosPendientes.Size = new Size(584, 401);
            pnlListaPagosPendientes.TabIndex = 5;
            // 
            // FrmPagosPendientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 29, 33);
            ClientSize = new Size(584, 461);
            Controls.Add(pnlListaPagosPendientes);
            Controls.Add(pnlTitulo);
            ForeColor = Color.Gainsboro;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPagosPendientes";
            Text = "FrmPagos";
            pnlTitulo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo;
        private Label lblTitulo;
        private Panel pnlListaPagosPendientes;
        private Button btnPagar;
    }
}