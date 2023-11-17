namespace NewSysacadFront
{
    partial class FrmEditarRequisitos
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
            lblTitulo = new Label();
            panel2 = new Panel();
            btnAgregarPromedio = new Button();
            pnlAgregarCorrelativa = new Panel();
            btnAgregarCorrelativa = new Button();
            cbxCarrera = new ComboBox();
            lbl3 = new Label();
            cbxCursos = new ComboBox();
            lbl4 = new Label();
            btnEliminarCorrelativa = new Button();
            lbl2 = new Label();
            btnMostrarMenu = new Button();
            txbPromedio = new TextBox();
            dgvCorrelatividades = new DataGridView();
            lbl1 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            TEST = new Label();
            panel2.SuspendLayout();
            pnlAgregarCorrelativa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCorrelatividades).BeginInit();
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
            lblTitulo.Text = "?";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(TEST);
            panel2.Controls.Add(btnAgregarPromedio);
            panel2.Controls.Add(pnlAgregarCorrelativa);
            panel2.Controls.Add(btnEliminarCorrelativa);
            panel2.Controls.Add(lbl2);
            panel2.Controls.Add(btnMostrarMenu);
            panel2.Controls.Add(txbPromedio);
            panel2.Controls.Add(dgvCorrelatividades);
            panel2.Controls.Add(lbl1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(584, 281);
            panel2.TabIndex = 4;
            // 
            // btnAgregarPromedio
            // 
            btnAgregarPromedio.FlatAppearance.BorderSize = 0;
            btnAgregarPromedio.FlatAppearance.MouseDownBackColor = Color.Coral;
            btnAgregarPromedio.FlatAppearance.MouseOverBackColor = Color.FromArgb(125, 121, 163);
            btnAgregarPromedio.FlatStyle = FlatStyle.Flat;
            btnAgregarPromedio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarPromedio.ForeColor = Color.DarkRed;
            btnAgregarPromedio.Location = new Point(157, 32);
            btnAgregarPromedio.Name = "btnAgregarPromedio";
            btnAgregarPromedio.Size = new Size(141, 43);
            btnAgregarPromedio.TabIndex = 27;
            btnAgregarPromedio.Text = "CAMBIAR PROMEDIO";
            btnAgregarPromedio.UseVisualStyleBackColor = true;
            btnAgregarPromedio.Click += btnAgregarPromedio_Click;
            // 
            // pnlAgregarCorrelativa
            // 
            pnlAgregarCorrelativa.Controls.Add(btnAgregarCorrelativa);
            pnlAgregarCorrelativa.Controls.Add(cbxCarrera);
            pnlAgregarCorrelativa.Controls.Add(lbl3);
            pnlAgregarCorrelativa.Controls.Add(cbxCursos);
            pnlAgregarCorrelativa.Controls.Add(lbl4);
            pnlAgregarCorrelativa.Location = new Point(308, 72);
            pnlAgregarCorrelativa.Name = "pnlAgregarCorrelativa";
            pnlAgregarCorrelativa.Size = new Size(264, 182);
            pnlAgregarCorrelativa.TabIndex = 27;
            pnlAgregarCorrelativa.Visible = false;
            // 
            // btnAgregarCorrelativa
            // 
            btnAgregarCorrelativa.FlatAppearance.BorderSize = 0;
            btnAgregarCorrelativa.FlatAppearance.MouseDownBackColor = Color.Coral;
            btnAgregarCorrelativa.FlatAppearance.MouseOverBackColor = Color.FromArgb(125, 121, 163);
            btnAgregarCorrelativa.FlatStyle = FlatStyle.Flat;
            btnAgregarCorrelativa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarCorrelativa.ForeColor = Color.DarkRed;
            btnAgregarCorrelativa.Location = new Point(16, 126);
            btnAgregarCorrelativa.Name = "btnAgregarCorrelativa";
            btnAgregarCorrelativa.Size = new Size(232, 43);
            btnAgregarCorrelativa.TabIndex = 26;
            btnAgregarCorrelativa.Text = "AGREGAR";
            btnAgregarCorrelativa.UseVisualStyleBackColor = true;
            btnAgregarCorrelativa.Click += btnAgregarCorrelativa_Click;
            // 
            // cbxCarrera
            // 
            cbxCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCarrera.FormattingEnabled = true;
            cbxCarrera.Items.AddRange(new object[] { "Tec. Univ. en Programación", "Tec. Univ. en Sistemas", "Licenciatura en Sistemas", "Ingeniería en Sistemas" });
            cbxCarrera.Location = new Point(16, 38);
            cbxCarrera.Name = "cbxCarrera";
            cbxCarrera.Size = new Size(232, 23);
            cbxCarrera.TabIndex = 22;
            cbxCarrera.SelectedIndexChanged += cbxCarrera_SelectedIndexChanged;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl3.ForeColor = Color.Brown;
            lbl3.Location = new Point(16, 16);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(51, 15);
            lbl3.TabIndex = 24;
            lbl3.Text = "Carrera:";
            // 
            // cbxCursos
            // 
            cbxCursos.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCursos.FormattingEnabled = true;
            cbxCursos.Location = new Point(16, 87);
            cbxCursos.Name = "cbxCursos";
            cbxCursos.Size = new Size(232, 23);
            cbxCursos.TabIndex = 23;
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl4.ForeColor = Color.Brown;
            lbl4.Location = new Point(16, 69);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(41, 15);
            lbl4.TabIndex = 25;
            lbl4.Text = "Curso:";
            // 
            // btnEliminarCorrelativa
            // 
            btnEliminarCorrelativa.FlatAppearance.BorderSize = 0;
            btnEliminarCorrelativa.FlatAppearance.MouseDownBackColor = Color.Coral;
            btnEliminarCorrelativa.FlatAppearance.MouseOverBackColor = Color.FromArgb(125, 121, 163);
            btnEliminarCorrelativa.FlatStyle = FlatStyle.Flat;
            btnEliminarCorrelativa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminarCorrelativa.ForeColor = Color.DarkRed;
            btnEliminarCorrelativa.Location = new Point(12, 226);
            btnEliminarCorrelativa.Name = "btnEliminarCorrelativa";
            btnEliminarCorrelativa.Size = new Size(286, 43);
            btnEliminarCorrelativa.TabIndex = 7;
            btnEliminarCorrelativa.Text = "ELIMINAR CORRELATIVIDAD";
            btnEliminarCorrelativa.UseVisualStyleBackColor = true;
            btnEliminarCorrelativa.Click += btnEliminarCorrelativa_Click;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl2.ForeColor = Color.Maroon;
            lbl2.Location = new Point(12, 88);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(79, 15);
            lbl2.TabIndex = 20;
            lbl2.Text = "Correlativas: ";
            // 
            // btnMostrarMenu
            // 
            btnMostrarMenu.FlatAppearance.BorderSize = 0;
            btnMostrarMenu.FlatAppearance.MouseDownBackColor = Color.Coral;
            btnMostrarMenu.FlatAppearance.MouseOverBackColor = Color.FromArgb(125, 121, 163);
            btnMostrarMenu.FlatStyle = FlatStyle.Flat;
            btnMostrarMenu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMostrarMenu.ForeColor = Color.DarkRed;
            btnMostrarMenu.Location = new Point(324, 23);
            btnMostrarMenu.Name = "btnMostrarMenu";
            btnMostrarMenu.Size = new Size(232, 43);
            btnMostrarMenu.TabIndex = 6;
            btnMostrarMenu.Text = "Agregar requisito: correlativa";
            btnMostrarMenu.UseVisualStyleBackColor = true;
            btnMostrarMenu.Click += btnMostrarMenu_Click;
            // 
            // txbPromedio
            // 
            txbPromedio.Location = new Point(12, 43);
            txbPromedio.Name = "txbPromedio";
            txbPromedio.Size = new Size(139, 23);
            txbPromedio.TabIndex = 21;
            // 
            // dgvCorrelatividades
            // 
            dgvCorrelatividades.AllowUserToAddRows = false;
            dgvCorrelatividades.AllowUserToDeleteRows = false;
            dgvCorrelatividades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCorrelatividades.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCorrelatividades.BackgroundColor = Color.FromArgb(102, 97, 140);
            dgvCorrelatividades.BorderStyle = BorderStyle.None;
            dgvCorrelatividades.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(125, 121, 163);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.DarkRed;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(125, 121, 163);
            dataGridViewCellStyle3.SelectionForeColor = Color.DarkRed;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvCorrelatividades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCorrelatividades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCorrelatividades.EnableHeadersVisualStyles = false;
            dgvCorrelatividades.GridColor = Color.FromArgb(125, 121, 163);
            dgvCorrelatividades.Location = new Point(12, 110);
            dgvCorrelatividades.MultiSelect = false;
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
            dgvCorrelatividades.Size = new Size(286, 110);
            dgvCorrelatividades.TabIndex = 19;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl1.ForeColor = Color.Maroon;
            lbl1.Location = new Point(12, 25);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(112, 15);
            lbl1.TabIndex = 12;
            lbl1.Text = "Promedio mínimo: ";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // TEST
            // 
            TEST.AutoSize = true;
            TEST.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TEST.ForeColor = Color.Maroon;
            TEST.Location = new Point(135, 88);
            TEST.Name = "TEST";
            TEST.Size = new Size(12, 15);
            TEST.TabIndex = 28;
            TEST.Text = "?";
            // 
            // FrmEditarRequisitos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(158, 153, 186);
            ClientSize = new Size(584, 361);
            Controls.Add(panel2);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximumSize = new Size(600, 400);
            MinimumSize = new Size(600, 400);
            Name = "FrmEditarRequisitos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Curso";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlAgregarCorrelativa.ResumeLayout(false);
            pnlAgregarCorrelativa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCorrelatividades).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Panel panel2;
        private Label lbl1;
        private DataGridView dgvCorrelatividades;
        private Label lbl2;
        private TextBox txbPromedio;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button btnEliminarCorrelativa;
        private Button btnMostrarMenu;
        private ComboBox cbxCarrera;
        private ComboBox cbxCursos;
        private Label lbl3;
        private Label lbl4;
        private Button btnAgregarCorrelativa;
        private Panel pnlAgregarCorrelativa;
        private Button btnAgregarPromedio;
        private Label TEST;
    }
}