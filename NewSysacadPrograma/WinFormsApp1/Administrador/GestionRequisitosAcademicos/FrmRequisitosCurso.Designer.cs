namespace NewSysacadFront
{
    partial class FrmRequisitosCurso
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnl1 = new Panel();
            lbl5 = new Label();
            dgvCorrelatividades = new DataGridView();
            btnEditar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            lbl4 = new Label();
            lblCarrera = new Label();
            lblCodigo = new Label();
            lblNombre = new Label();
            lbl1 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            lblPromedioMinimo = new Label();
            pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCorrelatividades).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnl1
            // 
            pnl1.BackColor = Color.FromArgb(102, 97, 140);
            pnl1.Controls.Add(lbl5);
            pnl1.Controls.Add(dgvCorrelatividades);
            pnl1.Controls.Add(btnEditar);
            pnl1.Controls.Add(tableLayoutPanel1);
            pnl1.Dock = DockStyle.Fill;
            pnl1.Location = new Point(3, 3);
            pnl1.Name = "pnl1";
            pnl1.Size = new Size(578, 113);
            pnl1.TabIndex = 0;
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.Dock = DockStyle.Fill;
            lbl5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl5.ForeColor = Color.Maroon;
            lbl5.Location = new Point(207, 0);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(237, 15);
            lbl5.TabIndex = 19;
            lbl5.Text = "Correlativas requeridas para esta materia:";
            // 
            // dgvCorrelatividades
            // 
            dgvCorrelatividades.AllowUserToAddRows = false;
            dgvCorrelatividades.AllowUserToDeleteRows = false;
            dgvCorrelatividades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCorrelatividades.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCorrelatividades.BackgroundColor = Color.FromArgb(158, 153, 186);
            dgvCorrelatividades.BorderStyle = BorderStyle.None;
            dgvCorrelatividades.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(125, 121, 163);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.DarkRed;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(125, 121, 163);
            dataGridViewCellStyle1.SelectionForeColor = Color.DarkRed;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCorrelatividades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCorrelatividades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCorrelatividades.EnableHeadersVisualStyles = false;
            dgvCorrelatividades.GridColor = Color.FromArgb(125, 121, 163);
            dgvCorrelatividades.Location = new Point(210, 21);
            dgvCorrelatividades.Name = "dgvCorrelatividades";
            dgvCorrelatividades.ReadOnly = true;
            dgvCorrelatividades.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(158, 153, 186);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.DarkRed;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(102, 97, 130);
            dataGridViewCellStyle2.SelectionForeColor = Color.LightCoral;
            dgvCorrelatividades.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvCorrelatividades.RowTemplate.Height = 25;
            dgvCorrelatividades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCorrelatividades.Size = new Size(269, 87);
            dgvCorrelatividades.TabIndex = 18;
            // 
            // btnEditar
            // 
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatAppearance.MouseDownBackColor = Color.Coral;
            btnEditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(158, 153, 186);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditar.ForeColor = Color.Brown;
            btnEditar.Location = new Point(482, 27);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(93, 56);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar Requisitos";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.7245445F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.2754555F));
            tableLayoutPanel1.Controls.Add(lbl4, 0, 3);
            tableLayoutPanel1.Controls.Add(lblCarrera, 1, 2);
            tableLayoutPanel1.Controls.Add(lblCodigo, 1, 1);
            tableLayoutPanel1.Controls.Add(lblNombre, 1, 0);
            tableLayoutPanel1.Controls.Add(lbl1, 0, 0);
            tableLayoutPanel1.Controls.Add(lbl2, 0, 1);
            tableLayoutPanel1.Controls.Add(lbl3, 0, 2);
            tableLayoutPanel1.Controls.Add(lblPromedioMinimo, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 28F));
            tableLayoutPanel1.Size = new Size(207, 113);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Dock = DockStyle.Fill;
            lbl4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl4.ForeColor = Color.Maroon;
            lbl4.Location = new Point(3, 81);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(72, 32);
            lbl4.TabIndex = 11;
            lbl4.Text = "Promedio mínimo: ";
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.ForeColor = Color.Brown;
            lblCarrera.Location = new Point(81, 54);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(12, 15);
            lblCarrera.TabIndex = 10;
            lblCarrera.Text = "?";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Dock = DockStyle.Fill;
            lblCodigo.ForeColor = Color.Brown;
            lblCodigo.Location = new Point(81, 27);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(123, 27);
            lblCodigo.TabIndex = 4;
            lblCodigo.Text = "?";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Dock = DockStyle.Fill;
            lblNombre.ForeColor = Color.DarkRed;
            lblNombre.Location = new Point(81, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(123, 27);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "?";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Dock = DockStyle.Fill;
            lbl1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl1.ForeColor = Color.DarkRed;
            lbl1.Location = new Point(3, 0);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(72, 27);
            lbl1.TabIndex = 0;
            lbl1.Text = "Nombre:";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Dock = DockStyle.Fill;
            lbl2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl2.ForeColor = Color.Brown;
            lbl2.Location = new Point(3, 27);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(72, 27);
            lbl2.TabIndex = 1;
            lbl2.Text = "Código:";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Dock = DockStyle.Fill;
            lbl3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl3.ForeColor = Color.Brown;
            lbl3.Location = new Point(3, 54);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(72, 27);
            lbl3.TabIndex = 8;
            lbl3.Text = "Carrera: ";
            // 
            // lblPromedioMinimo
            // 
            lblPromedioMinimo.AutoSize = true;
            lblPromedioMinimo.ForeColor = Color.DarkRed;
            lblPromedioMinimo.Location = new Point(81, 81);
            lblPromedioMinimo.Name = "lblPromedioMinimo";
            lblPromedioMinimo.Size = new Size(12, 15);
            lblPromedioMinimo.TabIndex = 12;
            lblPromedioMinimo.Text = "?";
            // 
            // FrmRequisitosCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(125, 121, 163);
            ClientSize = new Size(584, 119);
            Controls.Add(pnl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmRequisitosCurso";
            Padding = new Padding(3);
            Text = "FrmCurso";
            pnl1.ResumeLayout(false);
            pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCorrelatividades).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblCodigo;
        private Label lblNombre;
        private Label lbl1;
        private Label lbl2;
        private Button btnEditar;
        private Label lblCarrera;
        private Label lbl3;
        private Label lblPromedioMinimo;
        private Label lbl4;
        private DataGridView dgvCorrelatividades;
        private Label lbl5;
    }
}