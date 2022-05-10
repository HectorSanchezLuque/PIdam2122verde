namespace ProyectoIntegradoVerde
{
    partial class Login
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label2 = new System.Windows.Forms.Label();
            this.txtNif = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picLight = new System.Windows.Forms.PictureBox();
            this.btnIniSesion = new System.Windows.Forms.Button();
            this.lblOlvidoCont = new System.Windows.Forms.LinkLabel();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.picFlag = new System.Windows.Forms.PictureBox();
            this.lblLang = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblNotif = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 215);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // txtNif
            // 
            this.txtNif.Location = new System.Drawing.Point(134, 197);
            this.txtNif.Margin = new System.Windows.Forms.Padding(2);
            this.txtNif.Name = "txtNif";
            this.txtNif.Size = new System.Drawing.Size(166, 20);
            this.txtNif.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(134, 221);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(166, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 192);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "NIF";
            // 
            // picLight
            // 
            this.picLight.Image = ((System.Drawing.Image)(resources.GetObject("picLight.Image")));
            this.picLight.Location = new System.Drawing.Point(120, 33);
            this.picLight.Margin = new System.Windows.Forms.Padding(2);
            this.picLight.Name = "picLight";
            this.picLight.Size = new System.Drawing.Size(132, 136);
            this.picLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLight.TabIndex = 5;
            this.picLight.TabStop = false;
            // 
            // btnIniSesion
            // 
            this.btnIniSesion.Location = new System.Drawing.Point(202, 271);
            this.btnIniSesion.Margin = new System.Windows.Forms.Padding(2);
            this.btnIniSesion.Name = "btnIniSesion";
            this.btnIniSesion.Size = new System.Drawing.Size(79, 36);
            this.btnIniSesion.TabIndex = 6;
            this.btnIniSesion.Text = "Iniciar sesión";
            this.btnIniSesion.UseVisualStyleBackColor = true;
            this.btnIniSesion.Click += new System.EventHandler(this.btnIniSesion_Click);
            // 
            // lblOlvidoCont
            // 
            this.lblOlvidoCont.AutoSize = true;
            this.lblOlvidoCont.Location = new System.Drawing.Point(151, 243);
            this.lblOlvidoCont.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOlvidoCont.Name = "lblOlvidoCont";
            this.lblOlvidoCont.Size = new System.Drawing.Size(149, 13);
            this.lblOlvidoCont.TabIndex = 7;
            this.lblOlvidoCont.TabStop = true;
            this.lblOlvidoCont.Text = "¿Has olvidado tu contraseña?";
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(95, 271);
            this.btnRegistro.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(79, 36);
            this.btnRegistro.TabIndex = 8;
            this.btnRegistro.Text = "Registrar usuario";
            this.btnRegistro.UseVisualStyleBackColor = true;
            // 
            // picFlag
            // 
            this.picFlag.Image = ((System.Drawing.Image)(resources.GetObject("picFlag.Image")));
            this.picFlag.Location = new System.Drawing.Point(9, 10);
            this.picFlag.Margin = new System.Windows.Forms.Padding(2);
            this.picFlag.Name = "picFlag";
            this.picFlag.Size = new System.Drawing.Size(34, 22);
            this.picFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFlag.TabIndex = 9;
            this.picFlag.TabStop = false;
            // 
            // lblLang
            // 
            this.lblLang.AutoSize = true;
            this.lblLang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLang.Location = new System.Drawing.Point(47, 19);
            this.lblLang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLang.Name = "lblLang";
            this.lblLang.Size = new System.Drawing.Size(31, 13);
            this.lblLang.TabIndex = 10;
            this.lblLang.Text = "ESP";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(315, 2);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // lblNotif
            // 
            this.lblNotif.AutoSize = true;
            this.lblNotif.Location = new System.Drawing.Point(212, 344);
            this.lblNotif.Name = "lblNotif";
            this.lblNotif.Size = new System.Drawing.Size(138, 13);
            this.lblNotif.TabIndex = 12;
            this.lblNotif.TabStop = true;
            this.lblNotif.Text = "Notificar a un administrador.";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 366);
            this.Controls.Add(this.lblNotif);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblLang);
            this.Controls.Add(this.picFlag);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.lblOlvidoCont);
            this.Controls.Add(this.btnIniSesion);
            this.Controls.Add(this.picLight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtNif);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.Text = "Inicio de sesión";
            ((System.ComponentModel.ISupportInitialize)(this.picLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNif;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picLight;
        private System.Windows.Forms.Button btnIniSesion;
        private System.Windows.Forms.LinkLabel lblOlvidoCont;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.PictureBox picFlag;
        private System.Windows.Forms.Label lblLang;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.LinkLabel lblNotif;
    }
}

