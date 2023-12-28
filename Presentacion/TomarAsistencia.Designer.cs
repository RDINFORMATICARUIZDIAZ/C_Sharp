namespace MICRUD.Presentacion
{
    partial class TomarAsistencia
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtAviso = new System.Windows.Forms.TextBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelObservacion = new System.Windows.Forms.Panel();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.riObservacion = new System.Windows.Forms.RichTextBox();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelObservacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1453, 67);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnIniciarSesion);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1016, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(437, 67);
            this.panel2.TabIndex = 2;
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.Image = global::MICRUD.Properties.Resources.esquema_del_boton_de_flecha_cuadrada_de_inicio_de_sesion;
            this.btnIniciarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIniciarSesion.Location = new System.Drawing.Point(24, 0);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(413, 67);
            this.btnIniciarSesion.TabIndex = 1;
            this.btnIniciarSesion.Text = "Iniciar Sesion";
            this.btnIniciarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtNombre);
            this.panel3.Controls.Add(this.txtAviso);
            this.panel3.Controls.Add(this.lblHora);
            this.panel3.Controls.Add(this.lblFecha);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.txtIdentificacion);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(412, 108);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(961, 850);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(100, 756);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(770, 28);
            this.txtNombre.TabIndex = 16;
            this.txtNombre.Text = "Nombre";
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAviso
            // 
            this.txtAviso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.txtAviso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAviso.ForeColor = System.Drawing.Color.White;
            this.txtAviso.Location = new System.Drawing.Point(62, 708);
            this.txtAviso.Name = "txtAviso";
            this.txtAviso.Size = new System.Drawing.Size(839, 28);
            this.txtAviso.TabIndex = 15;
            this.txtAviso.Text = "Aviso";
            this.txtAviso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblHora
            // 
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.DarkGray;
            this.lblHora.Location = new System.Drawing.Point(238, 633);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(434, 37);
            this.lblHora.TabIndex = 14;
            this.lblHora.Text = "Hora";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFecha
            // 
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.DarkGray;
            this.lblFecha.Location = new System.Drawing.Point(238, 538);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(434, 37);
            this.lblFecha.TabIndex = 13;
            this.lblFecha.Text = "Fecha";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(20, 633);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 37);
            this.label5.TabIndex = 12;
            this.label5.Text = "Hora:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 538);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 37);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fecha:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(198)))), ((int)(((byte)(91)))));
            this.panel4.Location = new System.Drawing.Point(238, 471);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(539, 2);
            this.panel4.TabIndex = 10;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.txtIdentificacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificacion.ForeColor = System.Drawing.Color.White;
            this.txtIdentificacion.Location = new System.Drawing.Point(238, 437);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(539, 28);
            this.txtIdentificacion.TabIndex = 9;
            this.txtIdentificacion.TextChanged += new System.EventHandler(this.txtIdentificacion_TextChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 436);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "Identificacion:";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(961, 88);
            this.label2.TabIndex = 1;
            this.label2.Text = "REGISTRO DE ASISTENCIA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::MICRUD.Properties.Resources.acceso__1_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(961, 317);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelObservacion
            // 
            this.panelObservacion.Controls.Add(this.btnConfirmar);
            this.panelObservacion.Controls.Add(this.riObservacion);
            this.panelObservacion.Controls.Add(this.lblObservacion);
            this.panelObservacion.Location = new System.Drawing.Point(12, 108);
            this.panelObservacion.Name = "panelObservacion";
            this.panelObservacion.Size = new System.Drawing.Size(382, 747);
            this.panelObservacion.TabIndex = 2;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(5, 373);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(271, 80);
            this.btnConfirmar.TabIndex = 19;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // riObservacion
            // 
            this.riObservacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.riObservacion.Location = new System.Drawing.Point(7, 56);
            this.riObservacion.Name = "riObservacion";
            this.riObservacion.Size = new System.Drawing.Size(360, 295);
            this.riObservacion.TabIndex = 18;
            this.riObservacion.Text = "";
            // 
            // lblObservacion
            // 
            this.lblObservacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblObservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacion.ForeColor = System.Drawing.Color.White;
            this.lblObservacion.Location = new System.Drawing.Point(0, 0);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Size = new System.Drawing.Size(382, 53);
            this.lblObservacion.TabIndex = 17;
            this.lblObservacion.Text = "Observacion";
            this.lblObservacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblObservacion.UseWaitCursor = true;
            // 
            // timerHora
            // 
            this.timerHora.Enabled = true;
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // TomarAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(1453, 970);
            this.Controls.Add(this.panelObservacion);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "TomarAsistencia";
            this.Text = "TomsrAsistencia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TomarAsistencia_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelObservacion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtAviso;
        private System.Windows.Forms.Panel panelObservacion;
        private System.Windows.Forms.Label lblObservacion;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.RichTextBox riObservacion;
        private System.Windows.Forms.Timer timerHora;
    }
}