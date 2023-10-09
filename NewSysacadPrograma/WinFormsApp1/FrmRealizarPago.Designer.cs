namespace NewSysacadFront
{
    partial class FrmRealizarPago
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
            pnlMenuPago = new Panel();
            pnlBotonPago = new Panel();
            btnPagar = new Button();
            pnlFormaPago = new Panel();
            label1 = new Label();
            cbxFormaPago = new ComboBox();
            lblTitulo = new Label();
            pnlInfoPago = new Panel();
            pnlDatosPago = new Panel();
            pnlInfo = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblCodigo = new Label();
            lblConcepto = new Label();
            lbl1 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            lblMonto = new Label();
            pnlMenuPago.SuspendLayout();
            pnlBotonPago.SuspendLayout();
            pnlFormaPago.SuspendLayout();
            pnlInfoPago.SuspendLayout();
            pnlInfo.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenuPago
            // 
            pnlMenuPago.Controls.Add(pnlBotonPago);
            pnlMenuPago.Controls.Add(pnlFormaPago);
            pnlMenuPago.Controls.Add(lblTitulo);
            pnlMenuPago.Dock = DockStyle.Top;
            pnlMenuPago.Location = new Point(0, 0);
            pnlMenuPago.Name = "pnlMenuPago";
            pnlMenuPago.Size = new Size(584, 74);
            pnlMenuPago.TabIndex = 0;
            // 
            // pnlBotonPago
            // 
            pnlBotonPago.Controls.Add(btnPagar);
            pnlBotonPago.Dock = DockStyle.Fill;
            pnlBotonPago.Location = new Point(445, 0);
            pnlBotonPago.Name = "pnlBotonPago";
            pnlBotonPago.Size = new Size(139, 74);
            pnlBotonPago.TabIndex = 4;
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
            btnPagar.Location = new Point(0, 0);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(139, 74);
            btnPagar.TabIndex = 1;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // pnlFormaPago
            // 
            pnlFormaPago.Controls.Add(label1);
            pnlFormaPago.Controls.Add(cbxFormaPago);
            pnlFormaPago.Dock = DockStyle.Left;
            pnlFormaPago.Location = new Point(225, 0);
            pnlFormaPago.Name = "pnlFormaPago";
            pnlFormaPago.Size = new Size(220, 74);
            pnlFormaPago.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(30, 10);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 1;
            label1.Text = "Forma de Pago:";
            // 
            // cbxFormaPago
            // 
            cbxFormaPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxFormaPago.FormattingEnabled = true;
            cbxFormaPago.Location = new Point(31, 35);
            cbxFormaPago.Name = "cbxFormaPago";
            cbxFormaPago.Size = new Size(161, 23);
            cbxFormaPago.TabIndex = 0;
            cbxFormaPago.SelectedIndexChanged += cbxFormaPago_SelectedIndexChanged;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Left;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.Gainsboro;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Padding = new Padding(15, 0, 0, 0);
            lblTitulo.Size = new Size(225, 74);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Realizar Pago";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlInfoPago
            // 
            pnlInfoPago.Controls.Add(pnlDatosPago);
            pnlInfoPago.Controls.Add(pnlInfo);
            pnlInfoPago.Dock = DockStyle.Fill;
            pnlInfoPago.Location = new Point(0, 74);
            pnlInfoPago.Name = "pnlInfoPago";
            pnlInfoPago.Size = new Size(584, 287);
            pnlInfoPago.TabIndex = 1;
            // 
            // pnlDatosPago
            // 
            pnlDatosPago.Dock = DockStyle.Fill;
            pnlDatosPago.Location = new Point(0, 107);
            pnlDatosPago.Name = "pnlDatosPago";
            pnlDatosPago.Size = new Size(584, 180);
            pnlDatosPago.TabIndex = 1;
            // 
            // pnlInfo
            // 
            pnlInfo.Controls.Add(tableLayoutPanel1);
            pnlInfo.Dock = DockStyle.Top;
            pnlInfo.Location = new Point(0, 0);
            pnlInfo.Name = "pnlInfo";
            pnlInfo.Padding = new Padding(0, 10, 0, 0);
            pnlInfo.Size = new Size(584, 107);
            pnlInfo.TabIndex = 0;
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
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(584, 97);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Dock = DockStyle.Fill;
            lblCodigo.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCodigo.ForeColor = Color.Gainsboro;
            lblCodigo.Location = new Point(119, 48);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(169, 49);
            lblCodigo.TabIndex = 4;
            lblCodigo.Text = "?";
            // 
            // lblConcepto
            // 
            lblConcepto.AutoSize = true;
            lblConcepto.Dock = DockStyle.Fill;
            lblConcepto.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblConcepto.ForeColor = Color.Gainsboro;
            lblConcepto.Location = new Point(119, 0);
            lblConcepto.Name = "lblConcepto";
            lblConcepto.Size = new Size(169, 48);
            lblConcepto.TabIndex = 3;
            lblConcepto.Text = "?";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Dock = DockStyle.Fill;
            lbl1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl1.ForeColor = Color.Gainsboro;
            lbl1.Location = new Point(3, 0);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(110, 48);
            lbl1.TabIndex = 0;
            lbl1.Text = "Concepto:";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Dock = DockStyle.Fill;
            lbl2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl2.ForeColor = Color.Gainsboro;
            lbl2.Location = new Point(3, 48);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(110, 49);
            lbl2.TabIndex = 1;
            lbl2.Text = "Código:";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Dock = DockStyle.Fill;
            lbl3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl3.ForeColor = Color.Gainsboro;
            lbl3.Location = new Point(294, 0);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(110, 48);
            lbl3.TabIndex = 2;
            lbl3.Text = "Monto:";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Dock = DockStyle.Fill;
            lblMonto.ForeColor = Color.Gainsboro;
            lblMonto.Location = new Point(410, 0);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(171, 48);
            lblMonto.TabIndex = 5;
            lblMonto.Text = "?";
            // 
            // FrmRealizarPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 29, 33);
            ClientSize = new Size(584, 361);
            Controls.Add(pnlInfoPago);
            Controls.Add(pnlMenuPago);
            Name = "FrmRealizarPago";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Realizar Pago";
            pnlMenuPago.ResumeLayout(false);
            pnlBotonPago.ResumeLayout(false);
            pnlFormaPago.ResumeLayout(false);
            pnlFormaPago.PerformLayout();
            pnlInfoPago.ResumeLayout(false);
            pnlInfo.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenuPago;
        private Panel pnlInfoPago;
        private Panel pnlBotonPago;
        private Panel pnlFormaPago;
        private Label label1;
        private ComboBox cbxFormaPago;
        private Label lblTitulo;
        private Button btnPagar;
        private Panel pnlInfo;
        private Panel pnlDatosPago;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblCodigo;
        private Label lblConcepto;
        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private Label lblMonto;
    }
}