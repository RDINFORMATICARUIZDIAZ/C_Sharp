namespace MICRUD.Presentacion
{
    partial class CtlUsuarios
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtbuscador = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtUsuario = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnMostrarTodos);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtbuscador);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1377, 111);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1235, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(142, 111);
            this.panel2.TabIndex = 18;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnAgregar.BackgroundImage = global::MICRUD.Properties.Resources.agregar_contacto1;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(2, 0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(140, 111);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.FlatAppearance.BorderSize = 0;
            this.btnMostrarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarTodos.ForeColor = System.Drawing.Color.White;
            this.btnMostrarTodos.Location = new System.Drawing.Point(732, 40);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(232, 47);
            this.btnMostrarTodos.TabIndex = 17;
            this.btnMostrarTodos.Text = "Mostrar todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MICRUD.Properties.Resources.lupa;
            this.pictureBox1.Location = new System.Drawing.Point(582, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtbuscador
            // 
            this.txtbuscador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.txtbuscador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbuscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscador.ForeColor = System.Drawing.Color.White;
            this.txtbuscador.Location = new System.Drawing.Point(25, 44);
            this.txtbuscador.Name = "txtbuscador";
            this.txtbuscador.Size = new System.Drawing.Size(539, 28);
            this.txtbuscador.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(198)))), ((int)(((byte)(91)))));
            this.panel3.Location = new System.Drawing.Point(25, 85);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(539, 2);
            this.panel3.TabIndex = 1;
            // 
            // txtUsuario
            // 
            this.txtUsuario.AllowUserToAddRows = false;
            this.txtUsuario.AllowUserToDeleteRows = false;
            this.txtUsuario.AllowUserToResizeRows = false;
            this.txtUsuario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.txtUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar,
            this.Editar});
            this.txtUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUsuario.Location = new System.Drawing.Point(0, 111);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.RowHeadersWidth = 62;
            this.txtUsuario.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.txtUsuario.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.txtUsuario.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Olive;
            this.txtUsuario.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.txtUsuario.RowTemplate.Height = 40;
            this.txtUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.txtUsuario.Size = new System.Drawing.Size(1377, 778);
            this.txtUsuario.TabIndex = 2;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.Image = global::MICRUD.Properties.Resources.eliminar;
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.MinimumWidth = 8;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 150;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "";
            this.Editar.Image = global::MICRUD.Properties.Resources.editar;
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.MinimumWidth = 8;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Width = 150;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBox2);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtNombre);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(25, 149);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1178, 603);
            this.panel4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(96, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(233, 50);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(514, 35);
            this.txtNombre.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(233, 125);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 35);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(96, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(233, 199);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(277, 35);
            this.textBox2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(49, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CtlUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.panel1);
            this.Name = "CtlUsuarios";
            this.Size = new System.Drawing.Size(1377, 889);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtbuscador;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView txtUsuario;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
    }
}
