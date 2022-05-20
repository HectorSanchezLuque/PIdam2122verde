namespace ProyectoIntegradoVerde.Formularios
{
    partial class PanelAdmin
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
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNIF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPuntos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBorrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureFoto = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.checkDeshab = new System.Windows.Forms.CheckBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNIF = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtPuntos = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.dateNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOldID = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colNIF,
            this.colNombre,
            this.colNacimiento,
            this.colCargo,
            this.colPuntos,
            this.colCorreo,
            this.colPassword,
            this.colBorrado});
            this.dgvUsuarios.Location = new System.Drawing.Point(9, 47);
            this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.Size = new System.Drawing.Size(681, 202);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentDoubleClick);
            // 
            // colID
            // 
            this.colID.HeaderText = "id";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 125;
            // 
            // colNIF
            // 
            this.colNIF.HeaderText = "NIF";
            this.colNIF.MinimumWidth = 6;
            this.colNIF.Name = "colNIF";
            this.colNIF.ReadOnly = true;
            this.colNIF.Width = 125;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.MinimumWidth = 6;
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            this.colNombre.Width = 125;
            // 
            // colNacimiento
            // 
            this.colNacimiento.HeaderText = "F. Nacimiento";
            this.colNacimiento.MinimumWidth = 6;
            this.colNacimiento.Name = "colNacimiento";
            this.colNacimiento.ReadOnly = true;
            this.colNacimiento.Width = 125;
            // 
            // colCargo
            // 
            this.colCargo.HeaderText = "Cargo";
            this.colCargo.MinimumWidth = 6;
            this.colCargo.Name = "colCargo";
            this.colCargo.ReadOnly = true;
            this.colCargo.Width = 125;
            // 
            // colPuntos
            // 
            this.colPuntos.HeaderText = "Puntos";
            this.colPuntos.MinimumWidth = 6;
            this.colPuntos.Name = "colPuntos";
            this.colPuntos.ReadOnly = true;
            this.colPuntos.Width = 125;
            // 
            // colCorreo
            // 
            this.colCorreo.HeaderText = "Correo";
            this.colCorreo.MinimumWidth = 6;
            this.colCorreo.Name = "colCorreo";
            this.colCorreo.ReadOnly = true;
            this.colCorreo.Width = 125;
            // 
            // colPassword
            // 
            this.colPassword.HeaderText = "Contraseña";
            this.colPassword.MinimumWidth = 6;
            this.colPassword.Name = "colPassword";
            this.colPassword.ReadOnly = true;
            this.colPassword.Width = 125;
            // 
            // colBorrado
            // 
            this.colBorrado.HeaderText = "Borrado";
            this.colBorrado.MinimumWidth = 6;
            this.colBorrado.Name = "colBorrado";
            this.colBorrado.ReadOnly = true;
            this.colBorrado.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(81, 278);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(51, 356);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(74, 314);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "NIF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(286, 278);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cargo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(283, 314);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Puntos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(283, 356);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Correo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(19, 403);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "F. Nacimiento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label8.Location = new System.Drawing.Point(259, 399);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Contraseña:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label10.Location = new System.Drawing.Point(512, 258);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Foto:";
            // 
            // pictureFoto
            // 
            this.pictureFoto.Location = new System.Drawing.Point(548, 258);
            this.pictureFoto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureFoto.Name = "pictureFoto";
            this.pictureFoto.Size = new System.Drawing.Size(142, 154);
            this.pictureFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureFoto.TabIndex = 11;
            this.pictureFoto.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregar.Location = new System.Drawing.Point(604, 470);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(86, 31);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnModificar.Location = new System.Drawing.Point(514, 470);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(86, 31);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // checkDeshab
            // 
            this.checkDeshab.AutoSize = true;
            this.checkDeshab.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkDeshab.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDeshab.ForeColor = System.Drawing.Color.RoyalBlue;
            this.checkDeshab.Location = new System.Drawing.Point(21, 440);
            this.checkDeshab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkDeshab.Name = "checkDeshab";
            this.checkDeshab.Size = new System.Drawing.Size(107, 17);
            this.checkDeshab.TabIndex = 14;
            this.checkDeshab.Text = "Deshabilitado:";
            this.checkDeshab.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(105, 275);
            this.txtID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(117, 20);
            this.txtID.TabIndex = 15;
            // 
            // txtNIF
            // 
            this.txtNIF.Location = new System.Drawing.Point(105, 312);
            this.txtNIF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.Size = new System.Drawing.Size(117, 20);
            this.txtNIF.TabIndex = 16;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(105, 353);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(117, 20);
            this.txtNombre.TabIndex = 17;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(331, 275);
            this.txtCargo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(126, 20);
            this.txtCargo.TabIndex = 18;
            // 
            // txtPuntos
            // 
            this.txtPuntos.Location = new System.Drawing.Point(331, 312);
            this.txtPuntos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPuntos.Name = "txtPuntos";
            this.txtPuntos.Size = new System.Drawing.Size(126, 20);
            this.txtPuntos.TabIndex = 19;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(331, 353);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(126, 20);
            this.txtCorreo.TabIndex = 20;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(331, 396);
            this.txtContrasena.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(126, 20);
            this.txtContrasena.TabIndex = 21;
            // 
            // btnCargar
            // 
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnCargar.Location = new System.Drawing.Point(571, 417);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(98, 27);
            this.btnCargar.TabIndex = 22;
            this.btnCargar.Text = "Cargar imagen";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // dateNacimiento
            // 
            this.dateNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNacimiento.Location = new System.Drawing.Point(105, 399);
            this.dateNacimiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateNacimiento.Name = "dateNacimiento";
            this.dateNacimiento.Size = new System.Drawing.Size(117, 20);
            this.dateNacimiento.TabIndex = 23;
            this.dateNacimiento.Value = new System.DateTime(2022, 5, 19, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label9.Location = new System.Drawing.Point(292, 482);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "ID (Antes del cambio):";
            this.label9.Visible = false;
            // 
            // txtOldID
            // 
            this.txtOldID.Location = new System.Drawing.Point(424, 479);
            this.txtOldID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOldID.Name = "txtOldID";
            this.txtOldID.Size = new System.Drawing.Size(76, 20);
            this.txtOldID.TabIndex = 25;
            this.txtOldID.Visible = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnCerrar.Location = new System.Drawing.Point(9, 473);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(72, 31);
            this.btnCerrar.TabIndex = 27;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Location = new System.Drawing.Point(-4, -7);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(752, 50);
            this.panel2.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Location = new System.Drawing.Point(-15, 511);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 41);
            this.panel1.TabIndex = 16;
            // 
            // PanelAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 552);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txtOldID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateNacimiento);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtPuntos);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtNIF);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.checkDeshab);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pictureFoto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvUsuarios);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PanelAdmin";
            this.Text = "Panel de administración";
            this.Load += new System.EventHandler(this.PanelAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureFoto;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.CheckBox checkDeshab;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNIF;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtPuntos;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.DateTimePicker dateNacimiento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtOldID;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNIF;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPuntos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBorrado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}