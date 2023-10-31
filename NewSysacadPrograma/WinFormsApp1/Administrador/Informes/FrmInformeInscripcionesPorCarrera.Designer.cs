namespace NewSysacadFront
{
    partial class FrmInformeInscripcionesPorCarrera
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
            btnGenerar = new Button();
            dtimerFinal = new DateTimePicker();
            dtimerInicio = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            cbxCarrera = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnGenerar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 237);
            panel1.Name = "panel1";
            panel1.Size = new Size(584, 62);
            panel1.TabIndex = 8;
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
            // dtimerFinal
            // 
            dtimerFinal.Location = new Point(159, 96);
            dtimerFinal.Name = "dtimerFinal";
            dtimerFinal.Size = new Size(224, 23);
            dtimerFinal.TabIndex = 12;
            // 
            // dtimerInicio
            // 
            dtimerInicio.Location = new Point(159, 47);
            dtimerInicio.Name = "dtimerInicio";
            dtimerInicio.Size = new Size(224, 23);
            dtimerInicio.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(49, 102);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 10;
            label2.Text = "Hasta:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(49, 53);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 9;
            label1.Text = "Desde:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Brown;
            label3.Location = new Point(53, 159);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 13;
            label3.Text = "Carrera:";
            // 
            // cbxCarrera
            // 
            cbxCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCarrera.FormattingEnabled = true;
            cbxCarrera.Items.AddRange(new object[] { "Tec. Univ. en Programación", "Tec. Univ. en Sistemas", "Licenciatura en Sistemas", "Ingeniería en Sistemas" });
            cbxCarrera.Location = new Point(159, 151);
            cbxCarrera.Name = "cbxCarrera";
            cbxCarrera.Size = new Size(224, 23);
            cbxCarrera.TabIndex = 14;
            // 
            // FrmInformeInscripcionesPorCarrera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(125, 121, 163);
            ClientSize = new Size(584, 299);
            Controls.Add(cbxCarrera);
            Controls.Add(label3);
            Controls.Add(dtimerFinal);
            Controls.Add(dtimerInicio);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmInformeInscripcionesPorCarrera";
            Text = "FrmInformeIngresos";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnGenerar;
        private DateTimePicker dtimerFinal;
        private DateTimePicker dtimerInicio;
        private Label label2;
        private Label label1;
        private Label label3;
        private ComboBox cbxCarrera;
    }
}