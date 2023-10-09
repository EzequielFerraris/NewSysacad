namespace NewSysacadFront
{
    partial class FrmListaCursosEstudiante
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
            panelTop = new Panel();
            lblTitulo = new Label();
            btnInscribir = new Button();
            pnlListaCursos = new Panel();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(lblTitulo);
            panelTop.Controls.Add(btnInscribir);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(5);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(584, 60);
            panelTop.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Left;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.Gainsboro;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(431, 60);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Cursos";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnInscribir
            // 
            btnInscribir.BackColor = Color.Gray;
            btnInscribir.Dock = DockStyle.Right;
            btnInscribir.FlatAppearance.MouseDownBackColor = Color.Coral;
            btnInscribir.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            btnInscribir.FlatStyle = FlatStyle.Flat;
            btnInscribir.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnInscribir.Location = new Point(430, 0);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(154, 60);
            btnInscribir.TabIndex = 0;
            btnInscribir.Text = "Inscribir";
            btnInscribir.UseVisualStyleBackColor = false;
            btnInscribir.Click += btnInscribir_Click;
            // 
            // pnlListaCursos
            // 
            pnlListaCursos.AutoScroll = true;
            pnlListaCursos.Dock = DockStyle.Fill;
            pnlListaCursos.Location = new Point(0, 60);
            pnlListaCursos.Margin = new Padding(4);
            pnlListaCursos.Name = "pnlListaCursos";
            pnlListaCursos.Size = new Size(584, 401);
            pnlListaCursos.TabIndex = 4;
            // 
            // FrmListaCursosEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 29, 33);
            ClientSize = new Size(584, 461);
            Controls.Add(pnlListaCursos);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmListaCursosEstudiante";
            panelTop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Label lblTitulo;
        private Panel pnlListaCursos;
        private Button btnInscribir;
    }
}