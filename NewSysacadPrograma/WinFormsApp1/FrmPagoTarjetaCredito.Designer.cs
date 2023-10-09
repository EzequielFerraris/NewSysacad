namespace NewSysacadFront
{
    partial class FrmPagoTarjetaCredito
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
            lbl1 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txbTitular = new TextBox();
            txbNumeroTarjeta = new TextBox();
            txbVencimientoMes = new TextBox();
            txbCodigoSeg = new TextBox();
            txbMail = new TextBox();
            txbDni = new TextBox();
            txbCalle = new TextBox();
            txbAltura = new TextBox();
            txbVencimientoAnio = new TextBox();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl1.ForeColor = Color.Gainsboro;
            lbl1.Location = new Point(12, 18);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(115, 15);
            lbl1.TabIndex = 1;
            lbl1.Text = "Titular de la tarjeta:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(12, 59);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 2;
            label1.Text = "Número de la Tarjeta:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(12, 97);
            label2.Name = "label2";
            label2.Size = new Size(129, 15);
            label2.TabIndex = 3;
            label2.Text = "Vencimiento (MMAA):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(309, 18);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 4;
            label3.Text = "E-mail:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(17, 136);
            label4.Name = "label4";
            label4.Size = new Size(124, 15);
            label4.TabIndex = 5;
            label4.Text = "Código de Seguridad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(309, 59);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 6;
            label5.Text = "Documento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Gainsboro;
            label6.Location = new Point(309, 97);
            label6.Name = "label6";
            label6.Size = new Size(100, 15);
            label6.TabIndex = 7;
            label6.Text = "Dirección (Calle):";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Gainsboro;
            label7.Location = new Point(309, 136);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 8;
            label7.Text = "Altura:";
            // 
            // txbTitular
            // 
            txbTitular.Location = new Point(159, 18);
            txbTitular.Name = "txbTitular";
            txbTitular.Size = new Size(135, 23);
            txbTitular.TabIndex = 9;
            // 
            // txbNumeroTarjeta
            // 
            txbNumeroTarjeta.Location = new Point(159, 59);
            txbNumeroTarjeta.Name = "txbNumeroTarjeta";
            txbNumeroTarjeta.Size = new Size(135, 23);
            txbNumeroTarjeta.TabIndex = 10;
            // 
            // txbVencimientoMes
            // 
            txbVencimientoMes.Location = new Point(159, 97);
            txbVencimientoMes.Name = "txbVencimientoMes";
            txbVencimientoMes.Size = new Size(34, 23);
            txbVencimientoMes.TabIndex = 11;
            // 
            // txbCodigoSeg
            // 
            txbCodigoSeg.Location = new Point(159, 136);
            txbCodigoSeg.Name = "txbCodigoSeg";
            txbCodigoSeg.PasswordChar = '*';
            txbCodigoSeg.Size = new Size(135, 23);
            txbCodigoSeg.TabIndex = 12;
            // 
            // txbMail
            // 
            txbMail.Location = new Point(439, 18);
            txbMail.Name = "txbMail";
            txbMail.Size = new Size(135, 23);
            txbMail.TabIndex = 13;
            // 
            // txbDni
            // 
            txbDni.Location = new Point(439, 59);
            txbDni.Name = "txbDni";
            txbDni.Size = new Size(135, 23);
            txbDni.TabIndex = 14;
            // 
            // txbCalle
            // 
            txbCalle.Location = new Point(439, 97);
            txbCalle.Name = "txbCalle";
            txbCalle.Size = new Size(135, 23);
            txbCalle.TabIndex = 15;
            // 
            // txbAltura
            // 
            txbAltura.Location = new Point(439, 136);
            txbAltura.Name = "txbAltura";
            txbAltura.Size = new Size(135, 23);
            txbAltura.TabIndex = 16;
            // 
            // txbVencimientoAnio
            // 
            txbVencimientoAnio.Location = new Point(214, 97);
            txbVencimientoAnio.Name = "txbVencimientoAnio";
            txbVencimientoAnio.Size = new Size(34, 23);
            txbVencimientoAnio.TabIndex = 17;
            // 
            // FrmPagoTarjeta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 29, 33);
            ClientSize = new Size(584, 180);
            Controls.Add(txbVencimientoAnio);
            Controls.Add(txbAltura);
            Controls.Add(txbCalle);
            Controls.Add(txbDni);
            Controls.Add(txbMail);
            Controls.Add(txbCodigoSeg);
            Controls.Add(txbVencimientoMes);
            Controls.Add(txbNumeroTarjeta);
            Controls.Add(txbTitular);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbl1);
            ForeColor = Color.Gainsboro;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPagoTarjeta";
            Text = "FrmPagoTarjeta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txbTitular;
        private TextBox txbNumeroTarjeta;
        private TextBox txbVencimientoMes;
        private TextBox txbCodigoSeg;
        private TextBox txbMail;
        private TextBox txbDni;
        private TextBox txbCalle;
        private TextBox txbAltura;
        private TextBox txbVencimientoAnio;
    }
}