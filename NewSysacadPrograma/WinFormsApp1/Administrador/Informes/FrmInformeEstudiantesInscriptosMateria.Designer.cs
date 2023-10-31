namespace NewSysacadFront
{
    partial class FrmInformeEstudiantesInscriptosMateria
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
            cbxCursos = new ComboBox();
            label1 = new Label();
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
            // cbxCursos
            // 
            cbxCursos.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCursos.FormattingEnabled = true;
            cbxCursos.Location = new Point(139, 54);
            cbxCursos.Name = "cbxCursos";
            cbxCursos.Size = new Size(224, 23);
            cbxCursos.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(48, 54);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 15;
            label1.Text = "Curso:";
            // 
            // FrmInformeEstudiantesInscriptosMateria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(125, 121, 163);
            ClientSize = new Size(584, 299);
            Controls.Add(cbxCursos);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmInformeEstudiantesInscriptosMateria";
            Text = "FrmInformeEstudiantesInscriptosMateria";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnGenerar;
        private ComboBox cbxCursos;
        private Label label1;
    }
}