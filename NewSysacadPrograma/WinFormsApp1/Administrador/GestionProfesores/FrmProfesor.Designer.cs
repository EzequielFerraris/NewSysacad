namespace NewSysacadFront
{
    partial class FrmProfesor
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
            dgvAsignaciones = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            lbl7 = new Label();
            lblMail = new Label();
            lblLegajo = new Label();
            lblNombre = new Label();
            lbl1 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            lbl4 = new Label();
            lbl5 = new Label();
            lbl6 = new Label();
            lblDni = new Label();
            lblDireccion = new Label();
            lblTelefono = new Label();
            lblArea = new Label();
            pnlBotones = new Panel();
            panel3 = new Panel();
            btnAsignarCurso = new Button();
            panel2 = new Panel();
            btnEliminar = new Button();
            panel1 = new Panel();
            btnEditar = new Button();
            pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAsignaciones).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            pnlBotones.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnl1
            // 
            pnl1.BackColor = Color.FromArgb(102, 97, 140);
            pnl1.Controls.Add(dgvAsignaciones);
            pnl1.Controls.Add(tableLayoutPanel1);
            pnl1.Controls.Add(pnlBotones);
            pnl1.Dock = DockStyle.Fill;
            pnl1.Location = new Point(3, 3);
            pnl1.Name = "pnl1";
            pnl1.Size = new Size(578, 148);
            pnl1.TabIndex = 0;
            // 
            // dgvAsignaciones
            // 
            dgvAsignaciones.AllowUserToAddRows = false;
            dgvAsignaciones.AllowUserToDeleteRows = false;
            dgvAsignaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAsignaciones.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvAsignaciones.BackgroundColor = Color.FromArgb(158, 153, 186);
            dgvAsignaciones.BorderStyle = BorderStyle.None;
            dgvAsignaciones.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(125, 121, 163);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.DarkRed;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(125, 121, 163);
            dataGridViewCellStyle1.SelectionForeColor = Color.DarkRed;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAsignaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAsignaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAsignaciones.Dock = DockStyle.Fill;
            dgvAsignaciones.EnableHeadersVisualStyles = false;
            dgvAsignaciones.GridColor = Color.FromArgb(125, 121, 163);
            dgvAsignaciones.Location = new Point(280, 0);
            dgvAsignaciones.Name = "dgvAsignaciones";
            dgvAsignaciones.ReadOnly = true;
            dgvAsignaciones.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(158, 153, 186);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.DarkRed;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(102, 97, 130);
            dataGridViewCellStyle2.SelectionForeColor = Color.LightCoral;
            dgvAsignaciones.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvAsignaciones.RowTemplate.Height = 25;
            dgvAsignaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAsignaciones.Size = new Size(229, 148);
            dgvAsignaciones.TabIndex = 18;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.Controls.Add(lbl7, 0, 6);
            tableLayoutPanel1.Controls.Add(lblMail, 1, 2);
            tableLayoutPanel1.Controls.Add(lblLegajo, 1, 1);
            tableLayoutPanel1.Controls.Add(lblNombre, 1, 0);
            tableLayoutPanel1.Controls.Add(lbl1, 0, 0);
            tableLayoutPanel1.Controls.Add(lbl2, 0, 1);
            tableLayoutPanel1.Controls.Add(lbl3, 0, 2);
            tableLayoutPanel1.Controls.Add(lbl4, 0, 3);
            tableLayoutPanel1.Controls.Add(lbl5, 0, 4);
            tableLayoutPanel1.Controls.Add(lbl6, 0, 5);
            tableLayoutPanel1.Controls.Add(lblDni, 1, 3);
            tableLayoutPanel1.Controls.Add(lblDireccion, 1, 4);
            tableLayoutPanel1.Controls.Add(lblTelefono, 1, 5);
            tableLayoutPanel1.Controls.Add(lblArea, 1, 6);
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857113F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.Size = new Size(280, 148);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl7
            // 
            lbl7.AutoSize = true;
            lbl7.Dock = DockStyle.Fill;
            lbl7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl7.ForeColor = Color.Brown;
            lbl7.Location = new Point(3, 126);
            lbl7.Name = "lbl7";
            lbl7.Size = new Size(64, 22);
            lbl7.TabIndex = 11;
            lbl7.Text = "Área";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Dock = DockStyle.Fill;
            lblMail.ForeColor = Color.DarkRed;
            lblMail.Location = new Point(73, 42);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(204, 21);
            lblMail.TabIndex = 10;
            lblMail.Text = "?";
            // 
            // lblLegajo
            // 
            lblLegajo.AutoSize = true;
            lblLegajo.Dock = DockStyle.Fill;
            lblLegajo.ForeColor = Color.DarkRed;
            lblLegajo.Location = new Point(73, 21);
            lblLegajo.Name = "lblLegajo";
            lblLegajo.Size = new Size(204, 21);
            lblLegajo.TabIndex = 4;
            lblLegajo.Text = "?";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Dock = DockStyle.Fill;
            lblNombre.ForeColor = Color.DarkRed;
            lblNombre.Location = new Point(73, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(204, 21);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "?";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Dock = DockStyle.Fill;
            lbl1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl1.ForeColor = Color.Brown;
            lbl1.Location = new Point(3, 0);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(64, 21);
            lbl1.TabIndex = 0;
            lbl1.Text = "Nombre:";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Dock = DockStyle.Fill;
            lbl2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl2.ForeColor = Color.Brown;
            lbl2.Location = new Point(3, 21);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(64, 21);
            lbl2.TabIndex = 1;
            lbl2.Text = "Legajo:";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Dock = DockStyle.Fill;
            lbl3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl3.ForeColor = Color.Brown;
            lbl3.Location = new Point(3, 42);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(64, 21);
            lbl3.TabIndex = 8;
            lbl3.Text = "Mail:";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Dock = DockStyle.Fill;
            lbl4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl4.ForeColor = Color.Brown;
            lbl4.Location = new Point(3, 63);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(64, 21);
            lbl4.TabIndex = 2;
            lbl4.Text = "DNI:";
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.Dock = DockStyle.Fill;
            lbl5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl5.ForeColor = Color.Brown;
            lbl5.Location = new Point(3, 84);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(64, 21);
            lbl5.TabIndex = 6;
            lbl5.Text = "Dirección:";
            // 
            // lbl6
            // 
            lbl6.AutoSize = true;
            lbl6.Dock = DockStyle.Fill;
            lbl6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl6.ForeColor = Color.Brown;
            lbl6.Location = new Point(3, 105);
            lbl6.Name = "lbl6";
            lbl6.Size = new Size(64, 21);
            lbl6.TabIndex = 7;
            lbl6.Text = "Teléfono:";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Dock = DockStyle.Fill;
            lblDni.ForeColor = Color.DarkRed;
            lblDni.Location = new Point(73, 63);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(204, 21);
            lblDni.TabIndex = 5;
            lblDni.Text = "?";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Dock = DockStyle.Fill;
            lblDireccion.ForeColor = Color.DarkRed;
            lblDireccion.Location = new Point(73, 84);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(204, 21);
            lblDireccion.TabIndex = 8;
            lblDireccion.Text = "?";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Dock = DockStyle.Fill;
            lblTelefono.ForeColor = Color.DarkRed;
            lblTelefono.Location = new Point(73, 105);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(204, 21);
            lblTelefono.TabIndex = 9;
            lblTelefono.Text = "?";
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Dock = DockStyle.Fill;
            lblArea.ForeColor = Color.DarkRed;
            lblArea.Location = new Point(73, 126);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(204, 22);
            lblArea.TabIndex = 13;
            lblArea.Text = "?";
            // 
            // pnlBotones
            // 
            pnlBotones.Controls.Add(panel3);
            pnlBotones.Controls.Add(panel2);
            pnlBotones.Controls.Add(panel1);
            pnlBotones.Dock = DockStyle.Right;
            pnlBotones.Location = new Point(509, 0);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Size = new Size(69, 148);
            pnlBotones.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnAsignarCurso);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 98);
            panel3.Name = "panel3";
            panel3.Size = new Size(69, 50);
            panel3.TabIndex = 2;
            // 
            // btnAsignarCurso
            // 
            btnAsignarCurso.Dock = DockStyle.Fill;
            btnAsignarCurso.FlatAppearance.BorderSize = 0;
            btnAsignarCurso.FlatAppearance.MouseDownBackColor = Color.Coral;
            btnAsignarCurso.FlatAppearance.MouseOverBackColor = Color.FromArgb(158, 153, 186);
            btnAsignarCurso.FlatStyle = FlatStyle.Flat;
            btnAsignarCurso.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAsignarCurso.ForeColor = Color.Brown;
            btnAsignarCurso.Location = new Point(0, 0);
            btnAsignarCurso.Name = "btnAsignarCurso";
            btnAsignarCurso.Size = new Size(69, 50);
            btnAsignarCurso.TabIndex = 6;
            btnAsignarCurso.Text = "Asignar Curso";
            btnAsignarCurso.UseVisualStyleBackColor = true;
            btnAsignarCurso.Click += btnAsignarCurso_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnEliminar);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(69, 49);
            panel2.TabIndex = 1;
            // 
            // btnEliminar
            // 
            btnEliminar.Dock = DockStyle.Fill;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatAppearance.MouseDownBackColor = Color.Coral;
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(158, 153, 186);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.Brown;
            btnEliminar.Location = new Point(0, 0);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(69, 49);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar Profesor";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnEditar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(69, 49);
            panel1.TabIndex = 0;
            // 
            // btnEditar
            // 
            btnEditar.Dock = DockStyle.Fill;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatAppearance.MouseDownBackColor = Color.Coral;
            btnEditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(158, 153, 186);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditar.ForeColor = Color.Brown;
            btnEditar.Location = new Point(0, 0);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(69, 49);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar Profesor";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // FrmProfesor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(125, 121, 163);
            ClientSize = new Size(584, 154);
            Controls.Add(pnl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmProfesor";
            Padding = new Padding(3);
            Text = "FrmCurso";
            pnl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAsignaciones).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            pnlBotones.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblDni;
        private Label lblLegajo;
        private Label lblNombre;
        private Label lbl1;
        private Label lbl2;
        private Label lbl4;
        private Label lbl6;
        private Label lblTelefono;
        private Label lblDireccion;
        private Panel pnlBotones;
        private Panel panel2;
        private Button btnEliminar;
        private Label lblMail;
        private Label lbl5;
        private Label lbl3;
        private DataGridView dgvAsignaciones;
        private Panel panel3;
        private Button btnAsignarCurso;
        private Label lbl7;
        private Label lblArea;
        private Panel panel1;
        private Button btnEditar;
    }
}