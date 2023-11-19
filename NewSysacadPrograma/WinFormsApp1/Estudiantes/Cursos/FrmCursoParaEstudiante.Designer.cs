namespace NewSysacadFront
{
    partial class FrmCursoParaEstudiante
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnlMain = new Panel();
            pnlDescripcion = new Panel();
            dgvCorrelatividades = new DataGridView();
            lbl7 = new Label();
            lblDescripcion = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            lbl5 = new Label();
            lblCupo = new Label();
            lblCodigo = new Label();
            lblNombre = new Label();
            lbl1 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            lbl4 = new Label();
            lblDia = new Label();
            lblTurno = new Label();
            lblPromedio = new Label();
            pnlCheck = new Panel();
            checkBox1 = new CheckBox();
            pnlMain.SuspendLayout();
            pnlDescripcion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCorrelatividades).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            pnlCheck.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BorderStyle = BorderStyle.FixedSingle;
            pnlMain.Controls.Add(pnlDescripcion);
            pnlMain.Controls.Add(tableLayoutPanel1);
            pnlMain.Controls.Add(pnlCheck);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(3, 3);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(578, 144);
            pnlMain.TabIndex = 0;
            // 
            // pnlDescripcion
            // 
            pnlDescripcion.Controls.Add(dgvCorrelatividades);
            pnlDescripcion.Controls.Add(lbl7);
            pnlDescripcion.Controls.Add(lblDescripcion);
            pnlDescripcion.Dock = DockStyle.Fill;
            pnlDescripcion.Location = new Point(279, 0);
            pnlDescripcion.Name = "pnlDescripcion";
            pnlDescripcion.Size = new Size(297, 142);
            pnlDescripcion.TabIndex = 2;
            // 
            // dgvCorrelatividades
            // 
            dgvCorrelatividades.AllowUserToAddRows = false;
            dgvCorrelatividades.AllowUserToDeleteRows = false;
            dgvCorrelatividades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCorrelatividades.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCorrelatividades.BackgroundColor = Color.FromArgb(102, 97, 130);
            dgvCorrelatividades.BorderStyle = BorderStyle.None;
            dgvCorrelatividades.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(124, 114, 140);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(158, 153, 186);
            dataGridViewCellStyle3.SelectionForeColor = Color.Gainsboro;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvCorrelatividades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCorrelatividades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCorrelatividades.EnableHeadersVisualStyles = false;
            dgvCorrelatividades.GridColor = Color.FromArgb(125, 121, 163);
            dgvCorrelatividades.Location = new Point(3, 24);
            dgvCorrelatividades.Name = "dgvCorrelatividades";
            dgvCorrelatividades.ReadOnly = true;
            dgvCorrelatividades.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(158, 153, 186);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.DarkRed;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(102, 97, 130);
            dataGridViewCellStyle4.SelectionForeColor = Color.LightCoral;
            dgvCorrelatividades.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvCorrelatividades.RowTemplate.Height = 25;
            dgvCorrelatividades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCorrelatividades.Size = new Size(175, 115);
            dgvCorrelatividades.TabIndex = 19;
            // 
            // lbl7
            // 
            lbl7.FlatStyle = FlatStyle.Flat;
            lbl7.ForeColor = Color.Gainsboro;
            lbl7.Location = new Point(0, -1);
            lbl7.Margin = new Padding(3);
            lbl7.Name = "lbl7";
            lbl7.Size = new Size(178, 24);
            lbl7.TabIndex = 5;
            lbl7.Text = "Correlatividades:";
            // 
            // lblDescripcion
            // 
            lblDescripcion.BorderStyle = BorderStyle.FixedSingle;
            lblDescripcion.FlatStyle = FlatStyle.Flat;
            lblDescripcion.ForeColor = Color.Gainsboro;
            lblDescripcion.Location = new Point(179, 0);
            lblDescripcion.Margin = new Padding(3);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(106, 140);
            lblDescripcion.TabIndex = 4;
            lblDescripcion.Text = "?";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.Controls.Add(label1, 0, 5);
            tableLayoutPanel1.Controls.Add(lbl5, 0, 4);
            tableLayoutPanel1.Controls.Add(lblCupo, 1, 2);
            tableLayoutPanel1.Controls.Add(lblCodigo, 1, 1);
            tableLayoutPanel1.Controls.Add(lblNombre, 1, 0);
            tableLayoutPanel1.Controls.Add(lbl1, 0, 0);
            tableLayoutPanel1.Controls.Add(lbl2, 0, 1);
            tableLayoutPanel1.Controls.Add(lbl3, 0, 2);
            tableLayoutPanel1.Controls.Add(lbl4, 0, 3);
            tableLayoutPanel1.Controls.Add(lblDia, 1, 3);
            tableLayoutPanel1.Controls.Add(lblTurno, 1, 4);
            tableLayoutPanel1.Controls.Add(lblPromedio, 1, 5);
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(33, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(246, 142);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(3, 120);
            label1.Name = "label1";
            label1.Size = new Size(92, 22);
            label1.TabIndex = 10;
            label1.Text = "Promedio min:";
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.Dock = DockStyle.Fill;
            lbl5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl5.ForeColor = Color.Gainsboro;
            lbl5.Location = new Point(3, 96);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(92, 24);
            lbl5.TabIndex = 7;
            lbl5.Text = "Turno:";
            // 
            // lblCupo
            // 
            lblCupo.AutoSize = true;
            lblCupo.Dock = DockStyle.Fill;
            lblCupo.ForeColor = Color.Gainsboro;
            lblCupo.Location = new Point(101, 48);
            lblCupo.Name = "lblCupo";
            lblCupo.Size = new Size(142, 24);
            lblCupo.TabIndex = 5;
            lblCupo.Text = "?";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Dock = DockStyle.Fill;
            lblCodigo.ForeColor = Color.Gainsboro;
            lblCodigo.Location = new Point(101, 24);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(142, 24);
            lblCodigo.TabIndex = 4;
            lblCodigo.Text = "?";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Dock = DockStyle.Fill;
            lblNombre.ForeColor = Color.Gainsboro;
            lblNombre.Location = new Point(101, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(142, 24);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "?";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Dock = DockStyle.Fill;
            lbl1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl1.ForeColor = Color.Gainsboro;
            lbl1.Location = new Point(3, 0);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(92, 24);
            lbl1.TabIndex = 0;
            lbl1.Text = "Nombre:";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Dock = DockStyle.Fill;
            lbl2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl2.ForeColor = Color.Gainsboro;
            lbl2.Location = new Point(3, 24);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(92, 24);
            lbl2.TabIndex = 1;
            lbl2.Text = "Código:";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Dock = DockStyle.Fill;
            lbl3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl3.ForeColor = Color.Gainsboro;
            lbl3.Location = new Point(3, 48);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(92, 24);
            lbl3.TabIndex = 2;
            lbl3.Text = "Cupo:";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Dock = DockStyle.Fill;
            lbl4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl4.ForeColor = Color.Gainsboro;
            lbl4.Location = new Point(3, 72);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(92, 24);
            lbl4.TabIndex = 6;
            lbl4.Text = "Día:";
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.Dock = DockStyle.Fill;
            lblDia.ForeColor = Color.Gainsboro;
            lblDia.Location = new Point(101, 72);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(142, 24);
            lblDia.TabIndex = 8;
            lblDia.Text = "?";
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Dock = DockStyle.Fill;
            lblTurno.ForeColor = Color.Gainsboro;
            lblTurno.Location = new Point(101, 96);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(142, 24);
            lblTurno.TabIndex = 9;
            lblTurno.Text = "?";
            // 
            // lblPromedio
            // 
            lblPromedio.AutoSize = true;
            lblPromedio.Dock = DockStyle.Fill;
            lblPromedio.ForeColor = Color.Gainsboro;
            lblPromedio.Location = new Point(101, 120);
            lblPromedio.Name = "lblPromedio";
            lblPromedio.Size = new Size(142, 22);
            lblPromedio.TabIndex = 11;
            lblPromedio.Text = "?";
            // 
            // pnlCheck
            // 
            pnlCheck.Controls.Add(checkBox1);
            pnlCheck.Dock = DockStyle.Left;
            pnlCheck.ImeMode = ImeMode.Off;
            pnlCheck.Location = new Point(0, 0);
            pnlCheck.Name = "pnlCheck";
            pnlCheck.Size = new Size(33, 142);
            pnlCheck.TabIndex = 0;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(10, 50);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 0;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // FrmCursoParaEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 29, 33);
            ClientSize = new Size(584, 150);
            Controls.Add(pnlMain);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(584, 150);
            MinimumSize = new Size(584, 125);
            Name = "FrmCursoParaEstudiante";
            Padding = new Padding(3);
            pnlMain.ResumeLayout(false);
            pnlDescripcion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCorrelatividades).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            pnlCheck.ResumeLayout(false);
            pnlCheck.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private Panel pnlCheck;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblCupo;
        private Label lblCodigo;
        private Label lblNombre;
        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private Panel pnlDescripcion;
        private Label lblDescripcion;
        private CheckBox checkBox1;
        private Label lbl4;
        private Label lbl5;
        private Label lblDia;
        private Label lblTurno;
        private Label lbl7;
        private Label label1;
        public Label lblPromedio;
        private DataGridView dgvCorrelatividades;
    }
}