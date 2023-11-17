namespace NewSysacadFront
{
    partial class FrmPagoTransferencia
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
            txbTitular = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txbNroCuenta = new TextBox();
            txbTransaccion = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl1.ForeColor = Color.Gainsboro;
            lbl1.Location = new Point(292, 144);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(139, 32);
            lbl1.TabIndex = 1;
            lbl1.Text = "Número de transacción:\r\n(8 dígitos)";
            // 
            // txbTitular
            // 
            txbTitular.CharacterCasing = CharacterCasing.Upper;
            txbTitular.Location = new Point(437, 92);
            txbTitular.Name = "txbTitular";
            txbTitular.Size = new Size(135, 23);
            txbTitular.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(292, 92);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 10;
            label1.Text = "Titular de la cuenta:";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(292, 113);
            label2.Name = "label2";
            label2.Size = new Size(114, 31);
            label2.TabIndex = 11;
            label2.Text = "Número de cuenta:\r\n(16 dígitos)";
            // 
            // txbNroCuenta
            // 
            txbNroCuenta.Location = new Point(437, 121);
            txbNroCuenta.Name = "txbNroCuenta";
            txbNroCuenta.Size = new Size(135, 23);
            txbNroCuenta.TabIndex = 12;
            // 
            // txbTransaccion
            // 
            txbTransaccion.Location = new Point(437, 150);
            txbTransaccion.Name = "txbTransaccion";
            txbTransaccion.Size = new Size(135, 23);
            txbTransaccion.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(127, 15);
            label3.TabIndex = 14;
            label3.Text = "Gracias por tu compra.";
            // 
            // label4
            // 
            label4.Location = new Point(12, 26);
            label4.Name = "label4";
            label4.Size = new Size(192, 56);
            label4.TabIndex = 15;
            label4.Text = "Para concretar el pago podés hacer una transferencia o depósito a la siguiente cuenta:";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 80);
            label5.Name = "label5";
            label5.Size = new Size(123, 91);
            label5.TabIndex = 16;
            label5.Text = "Nombre del Banco: \r\nNúmero de cuenta: \r\nCBU:\r\nAlias:\r\nTitular de la Cuenta:\r\nCUIT: ";
            // 
            // label6
            // 
            label6.Location = new Point(210, 9);
            label6.Name = "label6";
            label6.Size = new Size(349, 38);
            label6.TabIndex = 17;
            label6.Text = "Luego es necesario que nos envíes el comprobante a administracion@utnfra.edu.com para que confirmemos el pago.\r\n";
            // 
            // label7
            // 
            label7.Location = new Point(210, 43);
            label7.Name = "label7";
            label7.Size = new Size(349, 38);
            label7.TabIndex = 18;
            label7.Text = "Podés agilizar el trámite transcribiendo debajo los datos correspondientes.\r\nMuchas gracias!";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Location = new Point(130, 81);
            label8.Name = "label8";
            label8.Size = new Size(141, 92);
            label8.TabIndex = 19;
            label8.Text = "Banco Provincia\r\n1235569875\r\n9963531235569875445875\r\nUTN.FRA.TUPSI\r\nUTNFRA\r\n30546671166\r\n";
            // 
            // FrmPagoTransferencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 29, 33);
            ClientSize = new Size(584, 180);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txbTransaccion);
            Controls.Add(txbNroCuenta);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txbTitular);
            Controls.Add(lbl1);
            ForeColor = Color.Gainsboro;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPagoTransferencia";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmPagoTransferencia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private TextBox txbTitular;
        private Label label1;
        private Label label2;
        private TextBox txbNroCuenta;
        private TextBox txbTransaccion;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}