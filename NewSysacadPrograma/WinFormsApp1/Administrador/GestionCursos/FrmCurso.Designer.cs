﻿namespace NewSysacadFront
{
    partial class FrmCurso
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
            pnl1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblCupo = new Label();
            lblCodigo = new Label();
            lblNombre = new Label();
            lbl1 = new Label();
            lbl2 = new Label();
            lbl4 = new Label();
            lbl6 = new Label();
            lblTurno = new Label();
            lblDia = new Label();
            pnlBotones = new Panel();
            panel2 = new Panel();
            btnEliminar = new Button();
            panel1 = new Panel();
            btnEditar = new Button();
            pnlDescripcion = new Panel();
            txbDescripcion = new TextBox();
            lbl5 = new Label();
            lbl3 = new Label();
            lblCarrera = new Label();
            pnl1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pnlBotones.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            pnlDescripcion.SuspendLayout();
            SuspendLayout();
            // 
            // pnl1
            // 
            pnl1.BackColor = Color.FromArgb(102, 97, 140);
            pnl1.Controls.Add(tableLayoutPanel1);
            pnl1.Controls.Add(pnlBotones);
            pnl1.Controls.Add(pnlDescripcion);
            pnl1.Dock = DockStyle.Fill;
            pnl1.Location = new Point(3, 3);
            pnl1.Name = "pnl1";
            pnl1.Size = new Size(578, 78);
            pnl1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.11808F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.21469F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.12803F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.5392075F));
            tableLayoutPanel1.Controls.Add(lblCarrera, 1, 2);
            tableLayoutPanel1.Controls.Add(lblCodigo, 1, 1);
            tableLayoutPanel1.Controls.Add(lblNombre, 1, 0);
            tableLayoutPanel1.Controls.Add(lbl1, 0, 0);
            tableLayoutPanel1.Controls.Add(lbl2, 0, 1);
            tableLayoutPanel1.Controls.Add(lbl6, 2, 2);
            tableLayoutPanel1.Controls.Add(lblTurno, 3, 2);
            tableLayoutPanel1.Controls.Add(lbl5, 2, 1);
            tableLayoutPanel1.Controls.Add(lblDia, 3, 1);
            tableLayoutPanel1.Controls.Add(lblCupo, 3, 0);
            tableLayoutPanel1.Controls.Add(lbl4, 2, 0);
            tableLayoutPanel1.Controls.Add(lbl3, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(270, 78);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblCupo
            // 
            lblCupo.AutoSize = true;
            lblCupo.ForeColor = Color.DarkRed;
            lblCupo.Location = new Point(218, 0);
            lblCupo.Name = "lblCupo";
            lblCupo.Size = new Size(12, 15);
            lblCupo.TabIndex = 5;
            lblCupo.Text = "?";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Dock = DockStyle.Fill;
            lblCodigo.ForeColor = Color.DarkRed;
            lblCodigo.Location = new Point(62, 26);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(102, 26);
            lblCodigo.TabIndex = 4;
            lblCodigo.Text = "?";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Dock = DockStyle.Fill;
            lblNombre.ForeColor = Color.DarkRed;
            lblNombre.Location = new Point(62, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(102, 26);
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
            lbl1.Size = new Size(53, 26);
            lbl1.TabIndex = 0;
            lbl1.Text = "Nombre:";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Dock = DockStyle.Fill;
            lbl2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl2.ForeColor = Color.Brown;
            lbl2.Location = new Point(3, 26);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(53, 26);
            lbl2.TabIndex = 1;
            lbl2.Text = "Código:";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Dock = DockStyle.Fill;
            lbl4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl4.ForeColor = Color.Brown;
            lbl4.Location = new Point(170, 0);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(42, 26);
            lbl4.TabIndex = 2;
            lbl4.Text = "Cupo:";
            // 
            // lbl6
            // 
            lbl6.AutoSize = true;
            lbl6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl6.ForeColor = Color.Brown;
            lbl6.Location = new Point(170, 52);
            lbl6.Name = "lbl6";
            lbl6.Size = new Size(42, 15);
            lbl6.TabIndex = 7;
            lbl6.Text = "Turno:";
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Dock = DockStyle.Fill;
            lblTurno.ForeColor = Color.DarkRed;
            lblTurno.Location = new Point(218, 52);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(49, 26);
            lblTurno.TabIndex = 9;
            lblTurno.Text = "?";
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.Dock = DockStyle.Fill;
            lblDia.ForeColor = Color.DarkRed;
            lblDia.Location = new Point(218, 26);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(49, 26);
            lblDia.TabIndex = 8;
            lblDia.Text = "?";
            // 
            // pnlBotones
            // 
            pnlBotones.Controls.Add(panel2);
            pnlBotones.Controls.Add(panel1);
            pnlBotones.Dock = DockStyle.Right;
            pnlBotones.Location = new Point(509, 0);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Size = new Size(69, 78);
            pnlBotones.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnEliminar);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 37);
            panel2.Name = "panel2";
            panel2.Size = new Size(69, 41);
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
            btnEliminar.Size = new Size(69, 41);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnEditar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(69, 37);
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
            btnEditar.Size = new Size(69, 37);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // pnlDescripcion
            // 
            pnlDescripcion.AutoScroll = true;
            pnlDescripcion.Controls.Add(txbDescripcion);
            pnlDescripcion.Location = new Point(273, 0);
            pnlDescripcion.Name = "pnlDescripcion";
            pnlDescripcion.Size = new Size(230, 78);
            pnlDescripcion.TabIndex = 1;
            // 
            // txbDescripcion
            // 
            txbDescripcion.BackColor = Color.FromArgb(102, 97, 140);
            txbDescripcion.Dock = DockStyle.Fill;
            txbDescripcion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txbDescripcion.ForeColor = Color.DarkRed;
            txbDescripcion.Location = new Point(0, 0);
            txbDescripcion.Multiline = true;
            txbDescripcion.Name = "txbDescripcion";
            txbDescripcion.ReadOnly = true;
            txbDescripcion.ScrollBars = ScrollBars.Vertical;
            txbDescripcion.Size = new Size(230, 78);
            txbDescripcion.TabIndex = 0;
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.Dock = DockStyle.Fill;
            lbl5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl5.ForeColor = Color.Brown;
            lbl5.Location = new Point(170, 26);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(42, 26);
            lbl5.TabIndex = 6;
            lbl5.Text = "Día:";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Dock = DockStyle.Fill;
            lbl3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl3.ForeColor = Color.Brown;
            lbl3.Location = new Point(3, 52);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(53, 26);
            lbl3.TabIndex = 8;
            lbl3.Text = "Carrera: ";
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.ForeColor = Color.DarkRed;
            lblCarrera.Location = new Point(62, 52);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(12, 15);
            lblCarrera.TabIndex = 10;
            lblCarrera.Text = "?";
            // 
            // FrmCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(125, 121, 163);
            ClientSize = new Size(584, 84);
            Controls.Add(pnl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCurso";
            Padding = new Padding(3);
            Text = "FrmCurso";
            pnl1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            pnlBotones.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            pnlDescripcion.ResumeLayout(false);
            pnlDescripcion.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl1;
        private TextBox txbDescripcion;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblCupo;
        private Label lblCodigo;
        private Label lblNombre;
        private Label lbl1;
        private Label lbl2;
        private Label lbl4;
        private Label lbl6;
        private Label lblTurno;
        private Label lblDia;
        private Panel pnlBotones;
        private Panel panel2;
        private Button btnEliminar;
        private Panel panel1;
        private Button btnEditar;
        private Panel pnlDescripcion;
        private Label lblCarrera;
        private Label lbl5;
        private Label lbl3;
    }
}