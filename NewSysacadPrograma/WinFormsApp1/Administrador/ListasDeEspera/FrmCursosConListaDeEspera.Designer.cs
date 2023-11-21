namespace NewSysacadFront
{
    partial class FrmCursosConListaDeEspera
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            pnlListasCursos = new Panel();
            btnConfirmarAgregar = new Button();
            txbLegajo = new TextBox();
            lblCodigoSeleccionado = new Label();
            lblCursoSeleccionado = new Label();
            lblAgregar3 = new Label();
            lblAgregar2 = new Label();
            lblAgregar1 = new Label();
            btnAgregarEstLE = new Button();
            btnEliminarEstudianteLE = new Button();
            lbl2 = new Label();
            lbl1 = new Label();
            dgvListaEsperaCursoSelecccionado = new DataGridView();
            dgvListasDeEspera = new DataGridView();
            pnlListasCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaEsperaCursoSelecccionado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvListasDeEspera).BeginInit();
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
            lblTitulo.Text = "Cursos con Listas de Espera";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlListasCursos
            // 
            pnlListasCursos.AutoScroll = true;
            pnlListasCursos.Controls.Add(btnConfirmarAgregar);
            pnlListasCursos.Controls.Add(txbLegajo);
            pnlListasCursos.Controls.Add(lblCodigoSeleccionado);
            pnlListasCursos.Controls.Add(lblCursoSeleccionado);
            pnlListasCursos.Controls.Add(lblAgregar3);
            pnlListasCursos.Controls.Add(lblAgregar2);
            pnlListasCursos.Controls.Add(lblAgregar1);
            pnlListasCursos.Controls.Add(btnAgregarEstLE);
            pnlListasCursos.Controls.Add(btnEliminarEstudianteLE);
            pnlListasCursos.Controls.Add(lbl2);
            pnlListasCursos.Controls.Add(lbl1);
            pnlListasCursos.Controls.Add(dgvListaEsperaCursoSelecccionado);
            pnlListasCursos.Controls.Add(dgvListasDeEspera);
            pnlListasCursos.Dock = DockStyle.Fill;
            pnlListasCursos.Location = new Point(0, 59);
            pnlListasCursos.Name = "pnlListasCursos";
            pnlListasCursos.Size = new Size(584, 302);
            pnlListasCursos.TabIndex = 2;
            // 
            // btnConfirmarAgregar
            // 
            btnConfirmarAgregar.FlatAppearance.BorderSize = 0;
            btnConfirmarAgregar.FlatAppearance.MouseDownBackColor = Color.DarkRed;
            btnConfirmarAgregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(102, 97, 140);
            btnConfirmarAgregar.FlatStyle = FlatStyle.Flat;
            btnConfirmarAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmarAgregar.ForeColor = Color.OrangeRed;
            btnConfirmarAgregar.Location = new Point(469, 262);
            btnConfirmarAgregar.Name = "btnConfirmarAgregar";
            btnConfirmarAgregar.Size = new Size(115, 28);
            btnConfirmarAgregar.TabIndex = 36;
            btnConfirmarAgregar.Text = "AGREGAR";
            btnConfirmarAgregar.UseVisualStyleBackColor = true;
            btnConfirmarAgregar.Click += btnConfirmarAgregar_Click;
            // 
            // txbLegajo
            // 
            txbLegajo.Location = new Point(469, 236);
            txbLegajo.Name = "txbLegajo";
            txbLegajo.Size = new Size(92, 23);
            txbLegajo.TabIndex = 35;
            // 
            // lblCodigoSeleccionado
            // 
            lblCodigoSeleccionado.AutoSize = true;
            lblCodigoSeleccionado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCodigoSeleccionado.ForeColor = Color.Coral;
            lblCodigoSeleccionado.Location = new Point(469, 191);
            lblCodigoSeleccionado.Name = "lblCodigoSeleccionado";
            lblCodigoSeleccionado.Size = new Size(0, 15);
            lblCodigoSeleccionado.TabIndex = 34;
            // 
            // lblCursoSeleccionado
            // 
            lblCursoSeleccionado.AutoSize = true;
            lblCursoSeleccionado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCursoSeleccionado.ForeColor = Color.Coral;
            lblCursoSeleccionado.Location = new Point(469, 152);
            lblCursoSeleccionado.Name = "lblCursoSeleccionado";
            lblCursoSeleccionado.Size = new Size(0, 15);
            lblCursoSeleccionado.TabIndex = 33;
            // 
            // lblAgregar3
            // 
            lblAgregar3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAgregar3.ForeColor = Color.Maroon;
            lblAgregar3.Location = new Point(469, 218);
            lblAgregar3.Name = "lblAgregar3";
            lblAgregar3.Size = new Size(58, 15);
            lblAgregar3.TabIndex = 32;
            lblAgregar3.Text = "Legajo :";
            // 
            // lblAgregar2
            // 
            lblAgregar2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAgregar2.ForeColor = Color.Maroon;
            lblAgregar2.Location = new Point(469, 176);
            lblAgregar2.Name = "lblAgregar2";
            lblAgregar2.Size = new Size(58, 15);
            lblAgregar2.TabIndex = 31;
            lblAgregar2.Text = "Código :";
            // 
            // lblAgregar1
            // 
            lblAgregar1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAgregar1.ForeColor = Color.Maroon;
            lblAgregar1.Location = new Point(469, 137);
            lblAgregar1.Name = "lblAgregar1";
            lblAgregar1.Size = new Size(58, 15);
            lblAgregar1.TabIndex = 30;
            lblAgregar1.Text = "Curso :";
            // 
            // btnAgregarEstLE
            // 
            btnAgregarEstLE.FlatAppearance.BorderSize = 0;
            btnAgregarEstLE.FlatAppearance.MouseDownBackColor = Color.Coral;
            btnAgregarEstLE.FlatAppearance.MouseOverBackColor = Color.FromArgb(102, 97, 140);
            btnAgregarEstLE.FlatStyle = FlatStyle.Flat;
            btnAgregarEstLE.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarEstLE.ForeColor = Color.DarkRed;
            btnAgregarEstLE.Location = new Point(469, 82);
            btnAgregarEstLE.Name = "btnAgregarEstLE";
            btnAgregarEstLE.Size = new Size(112, 43);
            btnAgregarEstLE.TabIndex = 29;
            btnAgregarEstLE.Text = "AGREGAR ESTUDIANTE";
            btnAgregarEstLE.UseVisualStyleBackColor = true;
            btnAgregarEstLE.Click += btnAgregarEstLE_Click;
            // 
            // btnEliminarEstudianteLE
            // 
            btnEliminarEstudianteLE.FlatAppearance.BorderSize = 0;
            btnEliminarEstudianteLE.FlatAppearance.MouseDownBackColor = Color.Coral;
            btnEliminarEstudianteLE.FlatAppearance.MouseOverBackColor = Color.FromArgb(102, 97, 140);
            btnEliminarEstudianteLE.FlatStyle = FlatStyle.Flat;
            btnEliminarEstudianteLE.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminarEstudianteLE.ForeColor = Color.DarkRed;
            btnEliminarEstudianteLE.Location = new Point(469, 33);
            btnEliminarEstudianteLE.Name = "btnEliminarEstudianteLE";
            btnEliminarEstudianteLE.Size = new Size(112, 43);
            btnEliminarEstudianteLE.TabIndex = 28;
            btnEliminarEstudianteLE.Text = "ELIMINAR ESTUDIANTE";
            btnEliminarEstudianteLE.UseVisualStyleBackColor = true;
            btnEliminarEstudianteLE.Click += btnEliminarEstudianteLE_Click;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl2.ForeColor = Color.Maroon;
            lbl2.Location = new Point(166, 15);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(92, 15);
            lbl2.TabIndex = 23;
            lbl2.Text = "Lista de espera:";
            // 
            // lbl1
            // 
            lbl1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl1.ForeColor = Color.Maroon;
            lbl1.Location = new Point(12, 15);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(58, 15);
            lbl1.TabIndex = 22;
            lbl1.Text = "Cursos :";
            // 
            // dgvListaEsperaCursoSelecccionado
            // 
            dgvListaEsperaCursoSelecccionado.AllowUserToAddRows = false;
            dgvListaEsperaCursoSelecccionado.AllowUserToDeleteRows = false;
            dgvListaEsperaCursoSelecccionado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListaEsperaCursoSelecccionado.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvListaEsperaCursoSelecccionado.BackgroundColor = Color.FromArgb(102, 97, 140);
            dgvListaEsperaCursoSelecccionado.BorderStyle = BorderStyle.None;
            dgvListaEsperaCursoSelecccionado.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(125, 121, 163);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.DarkRed;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(125, 121, 163);
            dataGridViewCellStyle1.SelectionForeColor = Color.DarkRed;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListaEsperaCursoSelecccionado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvListaEsperaCursoSelecccionado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaEsperaCursoSelecccionado.EnableHeadersVisualStyles = false;
            dgvListaEsperaCursoSelecccionado.GridColor = Color.FromArgb(125, 121, 163);
            dgvListaEsperaCursoSelecccionado.Location = new Point(166, 33);
            dgvListaEsperaCursoSelecccionado.MultiSelect = false;
            dgvListaEsperaCursoSelecccionado.Name = "dgvListaEsperaCursoSelecccionado";
            dgvListaEsperaCursoSelecccionado.ReadOnly = true;
            dgvListaEsperaCursoSelecccionado.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(158, 153, 186);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.DarkRed;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(102, 97, 130);
            dataGridViewCellStyle2.SelectionForeColor = Color.LightCoral;
            dgvListaEsperaCursoSelecccionado.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvListaEsperaCursoSelecccionado.RowTemplate.Height = 25;
            dgvListaEsperaCursoSelecccionado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaEsperaCursoSelecccionado.Size = new Size(297, 257);
            dgvListaEsperaCursoSelecccionado.TabIndex = 21;
            dgvListaEsperaCursoSelecccionado.CellContentClick += dgvListaEsperaCursoSelecccionado_CellContentClick;
            // 
            // dgvListasDeEspera
            // 
            dgvListasDeEspera.AllowUserToAddRows = false;
            dgvListasDeEspera.AllowUserToDeleteRows = false;
            dgvListasDeEspera.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListasDeEspera.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvListasDeEspera.BackgroundColor = Color.FromArgb(102, 97, 140);
            dgvListasDeEspera.BorderStyle = BorderStyle.None;
            dgvListasDeEspera.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(125, 121, 163);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.DarkRed;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(125, 121, 163);
            dataGridViewCellStyle3.SelectionForeColor = Color.DarkRed;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvListasDeEspera.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvListasDeEspera.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListasDeEspera.EnableHeadersVisualStyles = false;
            dgvListasDeEspera.GridColor = Color.FromArgb(125, 121, 163);
            dgvListasDeEspera.Location = new Point(12, 33);
            dgvListasDeEspera.MultiSelect = false;
            dgvListasDeEspera.Name = "dgvListasDeEspera";
            dgvListasDeEspera.ReadOnly = true;
            dgvListasDeEspera.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(158, 153, 186);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.DarkRed;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(102, 97, 130);
            dataGridViewCellStyle4.SelectionForeColor = Color.LightCoral;
            dgvListasDeEspera.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvListasDeEspera.RowTemplate.Height = 25;
            dgvListasDeEspera.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListasDeEspera.Size = new Size(138, 257);
            dgvListasDeEspera.TabIndex = 20;
            dgvListasDeEspera.CellContentClick += dgvListasDeEspera_CellContentClick;
            // 
            // FrmCursosConListaDeEspera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(125, 121, 163);
            ClientSize = new Size(584, 361);
            Controls.Add(pnlListasCursos);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(584, 361);
            MinimumSize = new Size(584, 361);
            Name = "FrmCursosConListaDeEspera";
            Text = "FrmListaDeCursos";
            pnlListasCursos.ResumeLayout(false);
            pnlListasCursos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaEsperaCursoSelecccionado).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvListasDeEspera).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Panel pnlListasCursos;
        private DataGridView dgvListasDeEspera;
        private DataGridView dgvListaEsperaCursoSelecccionado;
        private Label lbl2;
        private Label lbl1;
        private Button btnAgregarEstLE;
        private Button btnEliminarEstudianteLE;
        private Label lblAgregar1;
        private Label lblCodigoSeleccionado;
        private Label lblCursoSeleccionado;
        private Label lblAgregar3;
        private Label lblAgregar2;
        private TextBox txbLegajo;
        private Button btnConfirmarAgregar;
    }
}