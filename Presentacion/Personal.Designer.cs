namespace MICRUD.Presentacion
{
    partial class Personal
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtbuscador = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DataListadoPersonal = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.PanelPaginado = new System.Windows.Forms.Panel();
            this.btn_Sig = new System.Windows.Forms.Button();
            this.btn_Ant = new System.Windows.Forms.Button();
            this.btn_PrimeraPagina = new System.Windows.Forms.Button();
            this.btn_UltimaPagina = new System.Windows.Forms.Button();
            this.lbl_total = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_Pagina = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PanelRegistros = new System.Windows.Forms.Panel();
            this.dataListadoCargos = new System.Windows.Forms.DataGridView();
            this.EditarC = new System.Windows.Forms.DataGridViewImageColumn();
            this.PanelCargos = new System.Windows.Forms.Panel();
            this.txtSueldoG = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txtCargoG = new System.Windows.Forms.TextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnBolverCargo = new System.Windows.Forms.Button();
            this.btnGuardarCambiosC = new System.Windows.Forms.Button();
            this.btnGuardarC = new System.Windows.Forms.Button();
            this.btnvolverPersonal = new System.Windows.Forms.Button();
            this.PanelBtnGuardarPersonal = new System.Windows.Forms.Panel();
            this.btnGuardadCambiosdePersonal = new System.Windows.Forms.Button();
            this.btnGuardarPersonal = new System.Windows.Forms.Button();
            this.btnAgregarCargo = new System.Windows.Forms.Button();
            this.cbxPais = new System.Windows.Forms.ComboBox();
            this.txtSueldoPorHora = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblsueldo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataListadoPersonal)).BeginInit();
            this.PanelPaginado.SuspendLayout();
            this.PanelRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoCargos)).BeginInit();
            this.PanelCargos.SuspendLayout();
            this.panel13.SuspendLayout();
            this.PanelBtnGuardarPersonal.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1627, 111);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
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
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
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
            this.txtbuscador.TextChanged += new System.EventHandler(this.texbuscador_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(198)))), ((int)(((byte)(91)))));
            this.panel3.Location = new System.Drawing.Point(25, 85);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(539, 2);
            this.panel3.TabIndex = 1;
            // 
            // DataListadoPersonal
            // 
            this.DataListadoPersonal.AllowUserToAddRows = false;
            this.DataListadoPersonal.AllowUserToDeleteRows = false;
            this.DataListadoPersonal.AllowUserToResizeRows = false;
            this.DataListadoPersonal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.DataListadoPersonal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataListadoPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataListadoPersonal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar,
            this.Editar});
            this.DataListadoPersonal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataListadoPersonal.Location = new System.Drawing.Point(0, 111);
            this.DataListadoPersonal.Name = "DataListadoPersonal";
            this.DataListadoPersonal.ReadOnly = true;
            this.DataListadoPersonal.RowHeadersWidth = 62;
            this.DataListadoPersonal.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.DataListadoPersonal.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataListadoPersonal.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.DataListadoPersonal.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Olive;
            this.DataListadoPersonal.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DataListadoPersonal.RowTemplate.Height = 40;
            this.DataListadoPersonal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataListadoPersonal.Size = new System.Drawing.Size(1627, 679);
            this.DataListadoPersonal.TabIndex = 1;
            this.DataListadoPersonal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataListadoPersonal_CellClick);
            this.DataListadoPersonal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataListadoPersonal_CellContentClick);
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
            // PanelPaginado
            // 
            this.PanelPaginado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.PanelPaginado.Controls.Add(this.btn_Sig);
            this.PanelPaginado.Controls.Add(this.btn_Ant);
            this.PanelPaginado.Controls.Add(this.btn_PrimeraPagina);
            this.PanelPaginado.Controls.Add(this.btn_UltimaPagina);
            this.PanelPaginado.Controls.Add(this.lbl_total);
            this.PanelPaginado.Controls.Add(this.label8);
            this.PanelPaginado.Controls.Add(this.lbl_Pagina);
            this.PanelPaginado.Controls.Add(this.label6);
            this.PanelPaginado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelPaginado.Location = new System.Drawing.Point(0, 790);
            this.PanelPaginado.Name = "PanelPaginado";
            this.PanelPaginado.Size = new System.Drawing.Size(1627, 120);
            this.PanelPaginado.TabIndex = 2;
            this.PanelPaginado.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelPaginado_Paint);
            // 
            // btn_Sig
            // 
            this.btn_Sig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(224)))), ((int)(((byte)(87)))));
            this.btn_Sig.FlatAppearance.BorderSize = 0;
            this.btn_Sig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sig.Location = new System.Drawing.Point(25, 23);
            this.btn_Sig.Name = "btn_Sig";
            this.btn_Sig.Size = new System.Drawing.Size(280, 74);
            this.btn_Sig.TabIndex = 0;
            this.btn_Sig.Text = "Pagina Siguiente";
            this.btn_Sig.UseVisualStyleBackColor = false;
            this.btn_Sig.Click += new System.EventHandler(this.btn_Sig_Click);
            // 
            // btn_Ant
            // 
            this.btn_Ant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(224)))), ((int)(((byte)(87)))));
            this.btn_Ant.FlatAppearance.BorderSize = 0;
            this.btn_Ant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ant.Location = new System.Drawing.Point(321, 23);
            this.btn_Ant.Name = "btn_Ant";
            this.btn_Ant.Size = new System.Drawing.Size(280, 74);
            this.btn_Ant.TabIndex = 1;
            this.btn_Ant.Text = "Pagina Anterior";
            this.btn_Ant.UseVisualStyleBackColor = false;
            this.btn_Ant.Click += new System.EventHandler(this.btn_Ant_Click);
            // 
            // btn_PrimeraPagina
            // 
            this.btn_PrimeraPagina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(224)))), ((int)(((byte)(87)))));
            this.btn_PrimeraPagina.FlatAppearance.BorderSize = 0;
            this.btn_PrimeraPagina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PrimeraPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PrimeraPagina.Location = new System.Drawing.Point(1310, 23);
            this.btn_PrimeraPagina.Name = "btn_PrimeraPagina";
            this.btn_PrimeraPagina.Size = new System.Drawing.Size(280, 74);
            this.btn_PrimeraPagina.TabIndex = 5;
            this.btn_PrimeraPagina.Text = "Primera Pagina";
            this.btn_PrimeraPagina.UseVisualStyleBackColor = false;
            this.btn_PrimeraPagina.Click += new System.EventHandler(this.btn_PrimeraPagina_Click);
            // 
            // btn_UltimaPagina
            // 
            this.btn_UltimaPagina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(224)))), ((int)(((byte)(87)))));
            this.btn_UltimaPagina.FlatAppearance.BorderSize = 0;
            this.btn_UltimaPagina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UltimaPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UltimaPagina.Location = new System.Drawing.Point(1015, 23);
            this.btn_UltimaPagina.Name = "btn_UltimaPagina";
            this.btn_UltimaPagina.Size = new System.Drawing.Size(280, 74);
            this.btn_UltimaPagina.TabIndex = 2;
            this.btn_UltimaPagina.Text = "Ultima Pagina";
            this.btn_UltimaPagina.UseVisualStyleBackColor = false;
            this.btn_UltimaPagina.Click += new System.EventHandler(this.btn_UltimaPagina_Click);
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.White;
            this.lbl_total.Location = new System.Drawing.Point(886, 46);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(27, 29);
            this.lbl_total.TabIndex = 4;
            this.lbl_total.Text = "0";
            this.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(824, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 29);
            this.label8.TabIndex = 3;
            this.label8.Text = "de";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Pagina
            // 
            this.lbl_Pagina.AutoSize = true;
            this.lbl_Pagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pagina.ForeColor = System.Drawing.Color.White;
            this.lbl_Pagina.Location = new System.Drawing.Point(781, 46);
            this.lbl_Pagina.Name = "lbl_Pagina";
            this.lbl_Pagina.Size = new System.Drawing.Size(27, 29);
            this.lbl_Pagina.TabIndex = 2;
            this.lbl_Pagina.Text = "0";
            this.lbl_Pagina.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(668, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "Pagina";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PanelRegistros
            // 
            this.PanelRegistros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.PanelRegistros.Controls.Add(this.dataListadoCargos);
            this.PanelRegistros.Controls.Add(this.PanelCargos);
            this.PanelRegistros.Controls.Add(this.btnvolverPersonal);
            this.PanelRegistros.Controls.Add(this.PanelBtnGuardarPersonal);
            this.PanelRegistros.Controls.Add(this.btnAgregarCargo);
            this.PanelRegistros.Controls.Add(this.cbxPais);
            this.PanelRegistros.Controls.Add(this.txtSueldoPorHora);
            this.PanelRegistros.Controls.Add(this.panel9);
            this.PanelRegistros.Controls.Add(this.txtCargo);
            this.PanelRegistros.Controls.Add(this.panel8);
            this.PanelRegistros.Controls.Add(this.txtcedula);
            this.PanelRegistros.Controls.Add(this.panel6);
            this.PanelRegistros.Controls.Add(this.txtNombres);
            this.PanelRegistros.Controls.Add(this.panel5);
            this.PanelRegistros.Controls.Add(this.lblsueldo);
            this.PanelRegistros.Controls.Add(this.label4);
            this.PanelRegistros.Controls.Add(this.label3);
            this.PanelRegistros.Controls.Add(this.label2);
            this.PanelRegistros.Controls.Add(this.label1);
            this.PanelRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelRegistros.Location = new System.Drawing.Point(83, 134);
            this.PanelRegistros.Name = "PanelRegistros";
            this.PanelRegistros.Size = new System.Drawing.Size(1541, 580);
            this.PanelRegistros.TabIndex = 3;
            this.PanelRegistros.Visible = false;
            this.PanelRegistros.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelRegistros_Paint);
            // 
            // dataListadoCargos
            // 
            this.dataListadoCargos.AllowUserToAddRows = false;
            this.dataListadoCargos.AllowUserToDeleteRows = false;
            this.dataListadoCargos.AllowUserToResizeRows = false;
            this.dataListadoCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListadoCargos.ColumnHeadersVisible = false;
            this.dataListadoCargos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EditarC});
            this.dataListadoCargos.Location = new System.Drawing.Point(533, 411);
            this.dataListadoCargos.Name = "dataListadoCargos";
            this.dataListadoCargos.ReadOnly = true;
            this.dataListadoCargos.RowHeadersWidth = 62;
            this.dataListadoCargos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.dataListadoCargos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataListadoCargos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataListadoCargos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataListadoCargos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataListadoCargos.RowTemplate.Height = 40;
            this.dataListadoCargos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListadoCargos.Size = new System.Drawing.Size(468, 154);
            this.dataListadoCargos.TabIndex = 20;
            this.dataListadoCargos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListadoCargos_CellClick);
            this.dataListadoCargos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListadoCargos_CellContentClick);
            // 
            // EditarC
            // 
            this.EditarC.HeaderText = "";
            this.EditarC.Image = global::MICRUD.Properties.Resources.editar_codigo;
            this.EditarC.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.EditarC.MinimumWidth = 8;
            this.EditarC.Name = "EditarC";
            this.EditarC.ReadOnly = true;
            this.EditarC.Width = 150;
            // 
            // PanelCargos
            // 
            this.PanelCargos.Controls.Add(this.txtSueldoG);
            this.PanelCargos.Controls.Add(this.panel11);
            this.PanelCargos.Controls.Add(this.txtCargoG);
            this.PanelCargos.Controls.Add(this.panel12);
            this.PanelCargos.Controls.Add(this.label10);
            this.PanelCargos.Controls.Add(this.label11);
            this.PanelCargos.Controls.Add(this.panel13);
            this.PanelCargos.Location = new System.Drawing.Point(1007, 261);
            this.PanelCargos.Name = "PanelCargos";
            this.PanelCargos.Size = new System.Drawing.Size(557, 284);
            this.PanelCargos.TabIndex = 19;
            // 
            // txtSueldoG
            // 
            this.txtSueldoG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.txtSueldoG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSueldoG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSueldoG.ForeColor = System.Drawing.Color.White;
            this.txtSueldoG.Location = new System.Drawing.Point(279, 90);
            this.txtSueldoG.Name = "txtSueldoG";
            this.txtSueldoG.Size = new System.Drawing.Size(235, 28);
            this.txtSueldoG.TabIndex = 23;
            this.txtSueldoG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSueldoG_KeyPress);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.White;
            this.panel11.Location = new System.Drawing.Point(279, 131);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(235, 2);
            this.panel11.TabIndex = 22;
            // 
            // txtCargoG
            // 
            this.txtCargoG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.txtCargoG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCargoG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargoG.ForeColor = System.Drawing.Color.White;
            this.txtCargoG.Location = new System.Drawing.Point(279, 24);
            this.txtCargoG.Name = "txtCargoG";
            this.txtCargoG.Size = new System.Drawing.Size(235, 28);
            this.txtCargoG.TabIndex = 21;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.White;
            this.panel12.Location = new System.Drawing.Point(279, 65);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(235, 2);
            this.panel12.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(43, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(206, 30);
            this.label10.TabIndex = 19;
            this.label10.Text = "Sueldo por Hora:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(159, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 30);
            this.label11.TabIndex = 18;
            this.label11.Text = "Cargo:";
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.btnBolverCargo);
            this.panel13.Controls.Add(this.btnGuardarCambiosC);
            this.panel13.Controls.Add(this.btnGuardarC);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel13.Location = new System.Drawing.Point(0, 149);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(557, 135);
            this.panel13.TabIndex = 24;
            this.panel13.Paint += new System.Windows.Forms.PaintEventHandler(this.panel13_Paint);
            // 
            // btnBolverCargo
            // 
            this.btnBolverCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnBolverCargo.BackgroundImage = global::MICRUD.Properties.Resources.atras;
            this.btnBolverCargo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBolverCargo.FlatAppearance.BorderSize = 0;
            this.btnBolverCargo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBolverCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBolverCargo.Location = new System.Drawing.Point(362, 14);
            this.btnBolverCargo.Name = "btnBolverCargo";
            this.btnBolverCargo.Size = new System.Drawing.Size(117, 93);
            this.btnBolverCargo.TabIndex = 19;
            this.btnBolverCargo.UseVisualStyleBackColor = false;
            this.btnBolverCargo.Click += new System.EventHandler(this.btnBolverCargo_Click);
            // 
            // btnGuardarCambiosC
            // 
            this.btnGuardarCambiosC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnGuardarCambiosC.BackgroundImage = global::MICRUD.Properties.Resources.actualizar_datos;
            this.btnGuardarCambiosC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardarCambiosC.FlatAppearance.BorderSize = 0;
            this.btnGuardarCambiosC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGuardarCambiosC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCambiosC.Location = new System.Drawing.Point(182, 3);
            this.btnGuardarCambiosC.Name = "btnGuardarCambiosC";
            this.btnGuardarCambiosC.Size = new System.Drawing.Size(140, 111);
            this.btnGuardarCambiosC.TabIndex = 6;
            this.btnGuardarCambiosC.UseVisualStyleBackColor = false;
            this.btnGuardarCambiosC.Click += new System.EventHandler(this.btnGuardarCambiosC_Click);
            // 
            // btnGuardarC
            // 
            this.btnGuardarC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnGuardarC.BackgroundImage = global::MICRUD.Properties.Resources.lista_de_verificacion;
            this.btnGuardarC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardarC.FlatAppearance.BorderSize = 0;
            this.btnGuardarC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGuardarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarC.Location = new System.Drawing.Point(16, 3);
            this.btnGuardarC.Name = "btnGuardarC";
            this.btnGuardarC.Size = new System.Drawing.Size(140, 111);
            this.btnGuardarC.TabIndex = 5;
            this.btnGuardarC.UseVisualStyleBackColor = false;
            this.btnGuardarC.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // btnvolverPersonal
            // 
            this.btnvolverPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnvolverPersonal.BackgroundImage = global::MICRUD.Properties.Resources.atras;
            this.btnvolverPersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnvolverPersonal.FlatAppearance.BorderSize = 0;
            this.btnvolverPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnvolverPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvolverPersonal.Location = new System.Drawing.Point(1025, 46);
            this.btnvolverPersonal.Name = "btnvolverPersonal";
            this.btnvolverPersonal.Size = new System.Drawing.Size(138, 82);
            this.btnvolverPersonal.TabIndex = 18;
            this.btnvolverPersonal.UseVisualStyleBackColor = false;
            this.btnvolverPersonal.Click += new System.EventHandler(this.btnvolverPersonal_Click);
            // 
            // PanelBtnGuardarPersonal
            // 
            this.PanelBtnGuardarPersonal.Controls.Add(this.btnGuardadCambiosdePersonal);
            this.PanelBtnGuardarPersonal.Controls.Add(this.btnGuardarPersonal);
            this.PanelBtnGuardarPersonal.Location = new System.Drawing.Point(43, 424);
            this.PanelBtnGuardarPersonal.Name = "PanelBtnGuardarPersonal";
            this.PanelBtnGuardarPersonal.Size = new System.Drawing.Size(509, 141);
            this.PanelBtnGuardarPersonal.TabIndex = 17;
            this.PanelBtnGuardarPersonal.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // btnGuardadCambiosdePersonal
            // 
            this.btnGuardadCambiosdePersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnGuardadCambiosdePersonal.BackgroundImage = global::MICRUD.Properties.Resources.actualizar_datos;
            this.btnGuardadCambiosdePersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardadCambiosdePersonal.FlatAppearance.BorderSize = 0;
            this.btnGuardadCambiosdePersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGuardadCambiosdePersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardadCambiosdePersonal.Location = new System.Drawing.Point(373, 10);
            this.btnGuardadCambiosdePersonal.Name = "btnGuardadCambiosdePersonal";
            this.btnGuardadCambiosdePersonal.Size = new System.Drawing.Size(84, 71);
            this.btnGuardadCambiosdePersonal.TabIndex = 6;
            this.btnGuardadCambiosdePersonal.UseVisualStyleBackColor = false;
            this.btnGuardadCambiosdePersonal.Click += new System.EventHandler(this.btnGuardadCambiosdePersonal_Click);
            // 
            // btnGuardarPersonal
            // 
            this.btnGuardarPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnGuardarPersonal.BackgroundImage = global::MICRUD.Properties.Resources.lista_de_verificacion;
            this.btnGuardarPersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardarPersonal.FlatAppearance.BorderSize = 0;
            this.btnGuardarPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGuardarPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarPersonal.Location = new System.Drawing.Point(262, 7);
            this.btnGuardarPersonal.Name = "btnGuardarPersonal";
            this.btnGuardarPersonal.Size = new System.Drawing.Size(105, 74);
            this.btnGuardarPersonal.TabIndex = 5;
            this.btnGuardarPersonal.UseVisualStyleBackColor = false;
            this.btnGuardarPersonal.Click += new System.EventHandler(this.btnGuardarPersonal_Click);
            // 
            // btnAgregarCargo
            // 
            this.btnAgregarCargo.FlatAppearance.BorderSize = 0;
            this.btnAgregarCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCargo.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCargo.Location = new System.Drawing.Point(769, 287);
            this.btnAgregarCargo.Name = "btnAgregarCargo";
            this.btnAgregarCargo.Size = new System.Drawing.Size(232, 47);
            this.btnAgregarCargo.TabIndex = 16;
            this.btnAgregarCargo.Text = "+ Agregar Cargo";
            this.btnAgregarCargo.UseVisualStyleBackColor = true;
            this.btnAgregarCargo.Click += new System.EventHandler(this.btnAgregarCargo_Click);
            // 
            // cbxPais
            // 
            this.cbxPais.FormattingEnabled = true;
            this.cbxPais.Items.AddRange(new object[] {
            "Australia",
            "Austria",
            "Azerbaiyán",
            "Anguilla",
            "Argentina",
            "Armenia",
            "Bielorrusia",
            "Belice",
            "Bélgica",
            "Bermudas",
            "Bulgaria",
            "Brasil",
            "Reino Unido",
            "Hungría",
            "Vietnam",
            "Haiti",
            "Guadalupe",
            "Alemania",
            "Países Bajos",
            "Grecia",
            "Georgia",
            "Dinamarca",
            "Egipto",
            "Israel",
            "India",
            "Irán",
            "Irlanda",
            "España",
            "Italia",
            "Kazajstán",
            "Camerún",
            "Canadá",
            "Chipre",
            "Kirguistán",
            "China",
            "Costa Rica",
            "Kuwait",
            "Letonia",
            "Libia",
            "Lituania",
            "Luxemburgo",
            "México",
            "Moldavia",
            "Mónaco",
            "Nueva Zelanda",
            "Noruega",
            "Polonia",
            "Portugal",
            "Reunión",
            "Rusia",
            "El Salvador",
            "Eslovaquia",
            "Eslovenia",
            "Surinam",
            "Estados Unidos",
            "Tadjikistan",
            "Turkmenistan",
            "Islas Turcas y Caicos",
            "Turquía",
            "Uganda",
            "Uzbekistán",
            "Ucrania",
            "Finlandia",
            "Francia",
            "República Checa",
            "Suiza",
            "Suecia",
            "Estonia",
            "Corea del Sur",
            "Japón",
            "Croacia",
            "Rumanía",
            "Hong Kong",
            "Indonesia",
            "Jordania",
            "Malasia",
            "Singapur",
            "Taiwan",
            "Bosnia y Herzegovina",
            "Bahamas",
            "Chile",
            "Colombia",
            "Islandia",
            "Corea del Norte",
            "Macedonia",
            "Malta",
            "Pakistán",
            "Papúa-Nueva Guinea",
            "Perú",
            "Filipinas",
            "Arabia Saudita",
            "Tailandia",
            "Emiratos árabes Unidos",
            "Groenlandia",
            "Venezuela",
            "Zimbabwe",
            "Kenia",
            "Algeria",
            "Líbano",
            "Botsuana",
            "Tanzania",
            "Namibia",
            "Ecuador",
            "Marruecos",
            "Ghana",
            "Siria",
            "Nepal",
            "Mauritania",
            "Seychelles",
            "Paraguay",
            "Uruguay",
            "Congo (Brazzaville)",
            "Cuba",
            "Albania",
            "Nigeria",
            "Zambia",
            "Mozambique",
            "Angola",
            "Sri Lanka",
            "Etiopía",
            "Túnez",
            "Bolivia",
            "Panamá",
            "Malawi",
            "Liechtenstein",
            "Bahrein",
            "Barbados",
            "Chad",
            "Man",
            "Jamaica",
            "Malí",
            "Madagascar",
            "Senegal",
            "Togo",
            "Honduras",
            "República Dominicana",
            "Mongolia",
            "Irak",
            "Sudáfrica",
            "Aruba",
            "Gibraltar",
            "Afganistán",
            "Andorra",
            "Antigua y Barbuda",
            "Bangladesh",
            "Benín",
            "Bután",
            "Islas Virgenes Británicas",
            "Brunéi",
            "Burkina Faso",
            "Burundi",
            "Camboya",
            "Cabo Verde",
            "Comores",
            "Congo (Kinshasa)",
            "Cook",
            "Costa de Marfil",
            "Djibouti",
            "Timor Oriental",
            "Guinea Ecuatorial",
            "Eritrea",
            "Feroe",
            "Fiyi",
            "Polinesia Francesa",
            "Gabón",
            "Gambia",
            "Granada",
            "Guatemala",
            "Guernsey",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Jersey",
            "Kiribati",
            "Laos",
            "Lesotho",
            "Liberia",
            "Maldivas",
            "Martinica",
            "Mauricio",
            "Myanmar",
            "Nauru",
            "Antillas Holandesas",
            "Nueva Caledonia",
            "Nicaragua",
            "Níger",
            "Norfolk Island",
            "Omán",
            "Isla Pitcairn",
            "Qatar",
            "Ruanda",
            "Santa Elena",
            "San Cristobal y Nevis",
            "Santa Lucía",
            "San Pedro y Miquelón",
            "San Vincente y Granadinas",
            "Samoa",
            "San Marino",
            "San Tomé y Príncipe",
            "Serbia y Montenegro",
            "Sierra Leona",
            "Islas Salomón",
            "Somalia",
            "Sudán",
            "Swazilandia",
            "Tokelau",
            "Tonga",
            "Trinidad y Tobago",
            "Tuvalu",
            "Vanuatu",
            "Wallis y Futuna",
            "Sáhara Occidental",
            "Yemen",
            "Puerto Rico"});
            this.cbxPais.Location = new System.Drawing.Point(333, 235);
            this.cbxPais.Name = "cbxPais";
            this.cbxPais.Size = new System.Drawing.Size(330, 38);
            this.cbxPais.TabIndex = 15;
            // 
            // txtSueldoPorHora
            // 
            this.txtSueldoPorHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.txtSueldoPorHora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSueldoPorHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSueldoPorHora.ForeColor = System.Drawing.Color.White;
            this.txtSueldoPorHora.Location = new System.Drawing.Point(333, 358);
            this.txtSueldoPorHora.Name = "txtSueldoPorHora";
            this.txtSueldoPorHora.Size = new System.Drawing.Size(408, 28);
            this.txtSueldoPorHora.TabIndex = 14;
            this.txtSueldoPorHora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSueldoPorHora_KeyPress);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(333, 399);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(408, 2);
            this.panel9.TabIndex = 13;
            // 
            // txtCargo
            // 
            this.txtCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.txtCargo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargo.ForeColor = System.Drawing.Color.White;
            this.txtCargo.Location = new System.Drawing.Point(333, 291);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(408, 28);
            this.txtCargo.TabIndex = 12;
            this.txtCargo.TextChanged += new System.EventHandler(this.txtCargo_TextChanged);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(333, 332);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(408, 2);
            this.panel8.TabIndex = 11;
            // 
            // txtcedula
            // 
            this.txtcedula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.txtcedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcedula.ForeColor = System.Drawing.Color.White;
            this.txtcedula.Location = new System.Drawing.Point(333, 171);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(408, 28);
            this.txtcedula.TabIndex = 8;
            this.txtcedula.TextChanged += new System.EventHandler(this.txtcedula_TextChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(333, 212);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(408, 2);
            this.panel6.TabIndex = 7;
            // 
            // txtNombres
            // 
            this.txtNombres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.ForeColor = System.Drawing.Color.White;
            this.txtNombres.Location = new System.Drawing.Point(333, 98);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(668, 28);
            this.txtNombres.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(333, 139);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(668, 2);
            this.panel5.TabIndex = 5;
            // 
            // lblsueldo
            // 
            this.lblsueldo.AutoSize = true;
            this.lblsueldo.ForeColor = System.Drawing.Color.White;
            this.lblsueldo.Location = new System.Drawing.Point(97, 356);
            this.lblsueldo.Name = "lblsueldo";
            this.lblsueldo.Size = new System.Drawing.Size(206, 30);
            this.lblsueldo.TabIndex = 4;
            this.lblsueldo.Text = "Sueldo por Hora:";
            this.lblsueldo.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(213, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cargo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(233, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "País:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(68, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número de Cedula:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres y Apellidos:";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "EditarC";
            this.dataGridViewImageColumn1.Image = global::MICRUD.Properties.Resources.editar_codigo;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 8;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 150;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::MICRUD.Properties.Resources.editar_codigo;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 8;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 150;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::MICRUD.Properties.Resources.editar_codigo;
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn3.MinimumWidth = 8;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Width = 150;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1485, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(142, 111);
            this.panel2.TabIndex = 18;
            // 
            // Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelRegistros);
            this.Controls.Add(this.DataListadoPersonal);
            this.Controls.Add(this.PanelPaginado);
            this.Controls.Add(this.panel1);
            this.Name = "Personal";
            this.Size = new System.Drawing.Size(1627, 910);
            this.Load += new System.EventHandler(this.Personal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataListadoPersonal)).EndInit();
            this.PanelPaginado.ResumeLayout(false);
            this.PanelPaginado.PerformLayout();
            this.PanelRegistros.ResumeLayout(false);
            this.PanelRegistros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoCargos)).EndInit();
            this.PanelCargos.ResumeLayout(false);
            this.PanelCargos.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.PanelBtnGuardarPersonal.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DataListadoPersonal;
        private System.Windows.Forms.Panel PanelPaginado;
        private System.Windows.Forms.TextBox txtbuscador;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PanelRegistros;
        private System.Windows.Forms.Label lblsueldo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSueldoPorHora;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cbxPais;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnAgregarCargo;
        private System.Windows.Forms.Panel PanelBtnGuardarPersonal;
        private System.Windows.Forms.Button btnGuardadCambiosdePersonal;
        private System.Windows.Forms.Button btnGuardarPersonal;
        private System.Windows.Forms.Button btnvolverPersonal;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_Pagina;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Button btn_PrimeraPagina;
        private System.Windows.Forms.Button btn_UltimaPagina;
        private System.Windows.Forms.Button btn_Sig;
        private System.Windows.Forms.Button btn_Ant;
        private System.Windows.Forms.Panel PanelCargos;
        private System.Windows.Forms.TextBox txtSueldoG;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox txtCargoG;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button btnGuardarCambiosC;
        private System.Windows.Forms.Button btnGuardarC;
        private System.Windows.Forms.DataGridView dataListadoCargos;
        private System.Windows.Forms.DataGridViewImageColumn EditarC;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button btnBolverCargo;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
    }
}
