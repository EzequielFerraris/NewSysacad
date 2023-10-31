namespace NewSysacadFront
{
    partial class FrmPagoRealizadoIndividual
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
            pnlCheck = new Panel();
            btnComprobante = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblCodigo = new Label();
            lblConcepto = new Label();
            lbl1 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            lblMonto = new Label();
            lbl4 = new Label();
            lblVencimiento = new Label();
            pnlMain.SuspendLayout();
            pnlCheck.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BorderStyle = BorderStyle.FixedSingle;
            pnlMain.Controls.Add(pnlCheck);
            pnlMain.Controls.Add(tableLayoutPanel1);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 3);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(568, 75);
            pnlMain.TabIndex = 1;
            // 
            // pnlCheck
            // 
            pnlCheck.Controls.Add(btnComprobante);
            pnlCheck.Dock = DockStyle.Right;
            pnlCheck.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pnlCheck.Location = new Point(477, 0);
            pnlCheck.Name = "pnlCheck";
            pnlCheck.Size = new Size(89, 73);
            pnlCheck.TabIndex = 2;
            // 
            // btnComprobante
            // 
            btnComprobante.BackColor = Color.Gray;
            btnComprobante.Dock = DockStyle.Bottom;
            btnComprobante.FlatAppearance.BorderSize = 0;
            btnComprobante.FlatAppearance.MouseDownBackColor = Color.Coral;
            btnComprobante.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            btnComprobante.FlatStyle = FlatStyle.Flat;
            btnComprobante.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnComprobante.ForeColor = Color.FromArgb(32, 29, 33);
            btnComprobante.Location = new Point(0, 39);
            btnComprobante.Name = "btnComprobante";
            btnComprobante.Size = new Size(89, 34);
            btnComprobante.TabIndex = 0;
            btnComprobante.Text = "Comprobante";
            btnComprobante.UseVisualStyleBackColor = false;
            btnComprobante.Click += btnComprobante_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Controls.Add(lblCodigo, 1, 1);
            tableLayoutPanel1.Controls.Add(lblConcepto, 1, 0);
            tableLayoutPanel1.Controls.Add(lbl1, 0, 0);
            tableLayoutPanel1.Controls.Add(lbl2, 0, 1);
            tableLayoutPanel1.Controls.Add(lbl3, 2, 0);
            tableLayoutPanel1.Controls.Add(lblMonto, 3, 0);
            tableLayoutPanel1.Controls.Add(lbl4, 2, 1);
            tableLayoutPanel1.Controls.Add(lblVencimiento, 3, 1);
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(0, 10, 0, 0);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(490, 73);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Dock = DockStyle.Fill;
            lblCodigo.ForeColor = Color.Gainsboro;
            lblCodigo.Location = new Point(101, 41);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(141, 32);
            lblCodigo.TabIndex = 4;
            lblCodigo.Text = "?";
            // 
            // lblConcepto
            // 
            lblConcepto.AutoSize = true;
            lblConcepto.Dock = DockStyle.Fill;
            lblConcepto.ForeColor = Color.Gainsboro;
            lblConcepto.Location = new Point(101, 10);
            lblConcepto.Name = "lblConcepto";
            lblConcepto.Size = new Size(141, 31);
            lblConcepto.TabIndex = 3;
            lblConcepto.Text = "?";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Dock = DockStyle.Fill;
            lbl1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl1.ForeColor = Color.Gainsboro;
            lbl1.Location = new Point(3, 10);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(92, 31);
            lbl1.TabIndex = 0;
            lbl1.Text = "Concepto:";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Dock = DockStyle.Fill;
            lbl2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl2.ForeColor = Color.Gainsboro;
            lbl2.Location = new Point(3, 41);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(92, 32);
            lbl2.TabIndex = 1;
            lbl2.Text = "Código:";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Dock = DockStyle.Fill;
            lbl3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl3.ForeColor = Color.Gainsboro;
            lbl3.Location = new Point(248, 10);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(92, 31);
            lbl3.TabIndex = 2;
            lbl3.Text = "Monto:";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Dock = DockStyle.Fill;
            lblMonto.ForeColor = Color.Gainsboro;
            lblMonto.Location = new Point(346, 10);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(141, 31);
            lblMonto.TabIndex = 5;
            lblMonto.Text = "?";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Dock = DockStyle.Fill;
            lbl4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl4.ForeColor = Color.Gainsboro;
            lbl4.Location = new Point(248, 41);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(92, 32);
            lbl4.TabIndex = 6;
            lbl4.Text = "Abonado:";
            // 
            // lblVencimiento
            // 
            lblVencimiento.AutoSize = true;
            lblVencimiento.Dock = DockStyle.Fill;
            lblVencimiento.ForeColor = Color.Gainsboro;
            lblVencimiento.Location = new Point(346, 41);
            lblVencimiento.Name = "lblVencimiento";
            lblVencimiento.Size = new Size(141, 32);
            lblVencimiento.TabIndex = 8;
            lblVencimiento.Text = "?";
            // 
            // FrmPagoRealizadoIndividual
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 29, 33);
            ClientSize = new Size(568, 78);
            Controls.Add(pnlMain);
            ForeColor = Color.Gainsboro;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPagoRealizadoIndividual";
            Padding = new Padding(0, 3, 0, 0);
            Text = "FrmPagoPendiente";
            pnlMain.ResumeLayout(false);
            pnlCheck.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblMonto;
        private Label lblCodigo;
        private Label lblConcepto;
        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private Label lbl4;
        private Label lblVencimiento;
        private Panel pnlCheck;
        private Button btnComprobante;
    }
}