namespace NewSysacadFront
{
    partial class FrmAsignarCurso
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
            lblTitulo = new Label();
            panel1 = new Panel();
            btnCancelar = new Button();
            btnModificar = new Button();
            dgvCursosDisponibles = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCursosDisponibles).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.FromArgb(158, 153, 186);
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.Brown;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(584, 80);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Asignar Curso";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnModificar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 281);
            panel1.Name = "panel1";
            panel1.Size = new Size(584, 80);
            panel1.TabIndex = 3;
            // 
            // btnCancelar
            // 
            btnCancelar.Dock = DockStyle.Right;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.Coral;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(102, 97, 130);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.Brown;
            btnCancelar.Location = new Point(0, 0);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(292, 80);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Dock = DockStyle.Right;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatAppearance.MouseDownBackColor = Color.Coral;
            btnModificar.FlatAppearance.MouseOverBackColor = Color.FromArgb(102, 97, 130);
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.Brown;
            btnModificar.Location = new Point(292, 0);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(292, 80);
            btnModificar.TabIndex = 0;
            btnModificar.Text = "Asignar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // dgvCursosDisponibles
            // 
            dgvCursosDisponibles.AllowUserToAddRows = false;
            dgvCursosDisponibles.AllowUserToDeleteRows = false;
            dgvCursosDisponibles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCursosDisponibles.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCursosDisponibles.BackgroundColor = Color.FromArgb(102, 97, 140);
            dgvCursosDisponibles.BorderStyle = BorderStyle.None;
            dgvCursosDisponibles.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(125, 121, 163);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.DarkRed;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(125, 121, 163);
            dataGridViewCellStyle1.SelectionForeColor = Color.DarkRed;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCursosDisponibles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCursosDisponibles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCursosDisponibles.EnableHeadersVisualStyles = false;
            dgvCursosDisponibles.GridColor = Color.FromArgb(125, 121, 163);
            dgvCursosDisponibles.Location = new Point(27, 92);
            dgvCursosDisponibles.MultiSelect = false;
            dgvCursosDisponibles.Name = "dgvCursosDisponibles";
            dgvCursosDisponibles.ReadOnly = true;
            dgvCursosDisponibles.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(158, 153, 186);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.DarkRed;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(102, 97, 130);
            dataGridViewCellStyle2.SelectionForeColor = Color.LightCoral;
            dgvCursosDisponibles.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvCursosDisponibles.RowTemplate.Height = 25;
            dgvCursosDisponibles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCursosDisponibles.Size = new Size(530, 171);
            dgvCursosDisponibles.TabIndex = 20;
            // 
            // FrmAsignarCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(158, 153, 186);
            ClientSize = new Size(584, 361);
            Controls.Add(dgvCursosDisponibles);
            Controls.Add(panel1);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximumSize = new Size(600, 400);
            MinimumSize = new Size(600, 400);
            Name = "FrmAsignarCurso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Asignar Curso";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCursosDisponibles).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Panel panel1;
        private Button btnCancelar;
        private Button btnModificar;
        private DataGridView dgvCursosDisponibles;
    }
}