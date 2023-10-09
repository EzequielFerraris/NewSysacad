namespace NewSysacadFront
{
    partial class FrmComprobantePago
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
            btnAceptar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            lblConcepto = new Label();
            lblFormaDePago = new Label();
            lblTransaccion = new Label();
            lblMonto = new Label();
            lblFechaPago = new Label();
            label6 = new Label();
            lblTarjetaCuenta = new Label();
            label8 = new Label();
            lblTitular = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAceptar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 309);
            panel1.Name = "panel1";
            panel1.Size = new Size(304, 57);
            panel1.TabIndex = 0;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.Gray;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatAppearance.MouseDownBackColor = Color.Coral;
            btnAceptar.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.FromArgb(32, 29, 33);
            btnAceptar.ImageAlign = ContentAlignment.TopRight;
            btnAceptar.Location = new Point(92, 3);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(121, 54);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(12, 69);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 2;
            label1.Text = "Concepto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(12, 98);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 3;
            label2.Text = "Forma de Pago:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(12, 133);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 4;
            label3.Text = "Transacción:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(12, 167);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 5;
            label4.Text = "Monto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(12, 199);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 6;
            label5.Text = "Fecha de pago:";
            // 
            // label7
            // 
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Gainsboro;
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(304, 48);
            label7.TabIndex = 8;
            label7.Text = "Comprobante de Pago";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(label7);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(304, 48);
            panel2.TabIndex = 9;
            // 
            // lblConcepto
            // 
            lblConcepto.AutoSize = true;
            lblConcepto.ForeColor = Color.Gainsboro;
            lblConcepto.Location = new Point(123, 69);
            lblConcepto.Name = "lblConcepto";
            lblConcepto.Size = new Size(12, 15);
            lblConcepto.TabIndex = 10;
            lblConcepto.Text = "?";
            // 
            // lblFormaDePago
            // 
            lblFormaDePago.AutoSize = true;
            lblFormaDePago.ForeColor = Color.Gainsboro;
            lblFormaDePago.Location = new Point(123, 98);
            lblFormaDePago.Name = "lblFormaDePago";
            lblFormaDePago.Size = new Size(12, 15);
            lblFormaDePago.TabIndex = 11;
            lblFormaDePago.Text = "?";
            // 
            // lblTransaccion
            // 
            lblTransaccion.AutoSize = true;
            lblTransaccion.ForeColor = Color.Gainsboro;
            lblTransaccion.Location = new Point(123, 133);
            lblTransaccion.Name = "lblTransaccion";
            lblTransaccion.Size = new Size(12, 15);
            lblTransaccion.TabIndex = 12;
            lblTransaccion.Text = "?";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.ForeColor = Color.Gainsboro;
            lblMonto.Location = new Point(123, 167);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(12, 15);
            lblMonto.TabIndex = 13;
            lblMonto.Text = "?";
            // 
            // lblFechaPago
            // 
            lblFechaPago.AutoSize = true;
            lblFechaPago.ForeColor = Color.Gainsboro;
            lblFechaPago.Location = new Point(123, 199);
            lblFechaPago.Name = "lblFechaPago";
            lblFechaPago.Size = new Size(12, 15);
            lblFechaPago.TabIndex = 14;
            lblFechaPago.Text = "?";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Gainsboro;
            label6.Location = new Point(12, 253);
            label6.Name = "label6";
            label6.Size = new Size(93, 15);
            label6.TabIndex = 15;
            label6.Text = "Tarjeta / Cuenta:";
            // 
            // lblTarjetaCuenta
            // 
            lblTarjetaCuenta.AutoSize = true;
            lblTarjetaCuenta.ForeColor = Color.Gainsboro;
            lblTarjetaCuenta.Location = new Point(123, 253);
            lblTarjetaCuenta.Name = "lblTarjetaCuenta";
            lblTarjetaCuenta.Size = new Size(12, 15);
            lblTarjetaCuenta.TabIndex = 16;
            lblTarjetaCuenta.Text = "?";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Gainsboro;
            label8.Location = new Point(12, 228);
            label8.Name = "label8";
            label8.Size = new Size(44, 15);
            label8.TabIndex = 17;
            label8.Text = "Titular:";
            // 
            // lblTitular
            // 
            lblTitular.AutoSize = true;
            lblTitular.ForeColor = Color.Gainsboro;
            lblTitular.Location = new Point(123, 228);
            lblTitular.Name = "lblTitular";
            lblTitular.Size = new Size(12, 15);
            lblTitular.TabIndex = 18;
            lblTitular.Text = "?";
            // 
            // FrmComprobantePago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 29, 33);
            ClientSize = new Size(304, 366);
            Controls.Add(lblTitular);
            Controls.Add(label8);
            Controls.Add(lblTarjetaCuenta);
            Controls.Add(label6);
            Controls.Add(lblFechaPago);
            Controls.Add(lblMonto);
            Controls.Add(lblTransaccion);
            Controls.Add(lblFormaDePago);
            Controls.Add(lblConcepto);
            Controls.Add(panel2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "FrmComprobantePago";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Comprobante";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnAceptar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Panel panel2;
        private Label lblConcepto;
        private Label lblFormaDePago;
        private Label lblTransaccion;
        private Label lblMonto;
        private Label lblFechaPago;
        private Label label6;
        private Label lblTarjetaCuenta;
        private Label label8;
        private Label lblTitular;
    }
}