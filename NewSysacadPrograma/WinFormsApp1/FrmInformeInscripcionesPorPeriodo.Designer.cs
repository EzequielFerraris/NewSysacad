namespace NewSysacadFront
{
    partial class FrmInformeInscripcionesPorPeriodo
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dtimerInicio = new DateTimePicker();
            dtimerFinal = new DateTimePicker();
            txbAnioComparacion = new TextBox();
            fecha = new Label();
            panel1 = new Panel();
            btnGenerar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(45, 49);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Desde:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(45, 98);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 1;
            label2.Text = "Hasta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Brown;
            label3.Location = new Point(43, 148);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 2;
            label3.Text = "Año referencia:";
            // 
            // dtimerInicio
            // 
            dtimerInicio.Location = new Point(155, 43);
            dtimerInicio.Name = "dtimerInicio";
            dtimerInicio.Size = new Size(224, 23);
            dtimerInicio.TabIndex = 3;
            // 
            // dtimerFinal
            // 
            dtimerFinal.Location = new Point(155, 92);
            dtimerFinal.Name = "dtimerFinal";
            dtimerFinal.Size = new Size(224, 23);
            dtimerFinal.TabIndex = 4;
            // 
            // txbAnioComparacion
            // 
            txbAnioComparacion.Location = new Point(157, 145);
            txbAnioComparacion.Name = "txbAnioComparacion";
            txbAnioComparacion.Size = new Size(85, 23);
            txbAnioComparacion.TabIndex = 5;
            // 
            // fecha
            // 
            fecha.AutoSize = true;
            fecha.Location = new Point(52, 223);
            fecha.Name = "fecha";
            fecha.Size = new Size(0, 15);
            fecha.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnGenerar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 237);
            panel1.Name = "panel1";
            panel1.Size = new Size(584, 62);
            panel1.TabIndex = 7;
            // 
            // btnGenerar
            // 
            btnGenerar.Dock = DockStyle.Fill;
            btnGenerar.FlatAppearance.BorderSize = 0;
            btnGenerar.FlatAppearance.MouseDownBackColor = Color.Coral;
            btnGenerar.FlatAppearance.MouseOverBackColor = Color.FromArgb(102, 97, 130);
            btnGenerar.FlatStyle = FlatStyle.Flat;
            btnGenerar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGenerar.ForeColor = Color.Brown;
            btnGenerar.Location = new Point(0, 0);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(584, 62);
            btnGenerar.TabIndex = 2;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // FrmInformeInscripcionesPorPeriodo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(125, 121, 163);
            ClientSize = new Size(584, 299);
            Controls.Add(panel1);
            Controls.Add(fecha);
            Controls.Add(txbAnioComparacion);
            Controls.Add(dtimerFinal);
            Controls.Add(dtimerInicio);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmInformeInscripcionesPorPeriodo";
            Text = "FrmInformeInscripcionesPorPeriodo";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dtimerInicio;
        private DateTimePicker dtimerFinal;
        private TextBox txbAnioComparacion;
        private Label fecha;
        private Panel panel1;
        private Button btnGenerar;
    }
}