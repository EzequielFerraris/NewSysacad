namespace NewSysacadFront
{
    partial class FrmListaDeRequisitos
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
            lblTitulo = new Label();
            pnlListaRequisitos = new Panel();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.Brown;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(584, 59);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Requisitos cursos activos";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlListaRequisitos
            // 
            pnlListaRequisitos.AutoScroll = true;
            pnlListaRequisitos.Dock = DockStyle.Fill;
            pnlListaRequisitos.Location = new Point(0, 59);
            pnlListaRequisitos.Name = "pnlListaRequisitos";
            pnlListaRequisitos.Size = new Size(584, 302);
            pnlListaRequisitos.TabIndex = 2;
            // 
            // FrmListaDeRequisitos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(125, 121, 163);
            ClientSize = new Size(584, 361);
            Controls.Add(pnlListaRequisitos);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(584, 361);
            MinimumSize = new Size(584, 361);
            Name = "FrmListaDeRequisitos";
            Text = "FrmListaDeCursos";
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Panel pnlListaRequisitos;
    }
}