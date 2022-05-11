namespace Programacion
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
            this.lblPsw = new System.Windows.Forms.Label();
            this.txtNif = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblNIF = new System.Windows.Forms.Label();
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
            // lblPsw
            // 
            this.lblPsw.AutoSize = true;
            this.lblPsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPsw.Location = new System.Drawing.Point(37, 265);
            this.lblPsw.Name = "lblPsw";
            this.lblPsw.Size = new System.Drawing.Size(136, 29);
            this.lblPsw.TabIndex = 1;
            this.lblPsw.Text = "Contraseña";
            // 
            // txtNif
            // 
            this.txtNif.Location = new System.Drawing.Point(179, 242);
            this.txtNif.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNif.Name = "txtNif";
            this.txtNif.Size = new System.Drawing.Size(220, 22);
            this.txtNif.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(179, 272);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(220, 22);
            this.txtPassword.TabIndex = 3;
            // 
            // lblNIF
            // 
            this.lblNIF.AutoSize = true;
            this.lblNIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNIF.Location = new System.Drawing.Point(121, 236);
            this.lblNIF.Name = "lblNIF";
            this.lblNIF.Size = new System.Drawing.Size(52, 29);
            this.lblNIF.TabIndex = 4;
            this.lblNIF.Text = "NIF";
            // 
            // picLight
            // 
            this.picLight.Image = ((System.Drawing.Image)(resources.GetObject("picLight.Image")));
            this.picLight.Location = new System.Drawing.Point(160, 41);
            this.picLight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picLight.Name = "picLight";
            this.picLight.Size = new System.Drawing.Size(176, 167);
            this.picLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLight.TabIndex = 5;
            this.picLight.TabStop = false;
            // 
            // btnIniSesion
            // 
            this.btnIniSesion.Location = new System.Drawing.Point(269, 334);
            this.btnIniSesion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIniSesion.Name = "btnIniSesion";
            this.btnIniSesion.Size = new System.Drawing.Size(105, 44);
            this.btnIniSesion.TabIndex = 6;
            this.btnIniSesion.Text = "Iniciar sesión";
            this.btnIniSesion.UseVisualStyleBackColor = true;
            this.btnIniSesion.Click += new System.EventHandler(this.btnIniSesion_Click);
            // 
            // lblOlvidoCont
            // 
            this.lblOlvidoCont.AutoSize = true;
            this.lblOlvidoCont.Location = new System.Drawing.Point(201, 299);
            this.lblOlvidoCont.Name = "lblOlvidoCont";
            this.lblOlvidoCont.Size = new System.Drawing.Size(197, 17);
            this.lblOlvidoCont.TabIndex = 7;
            this.lblOlvidoCont.TabStop = true;
            this.lblOlvidoCont.Text = "¿Has olvidado tu contraseña?";
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(127, 334);
            this.btnRegistro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(105, 44);
            this.btnRegistro.TabIndex = 8;
            this.btnRegistro.Text = "Registrar usuario";
            this.btnRegistro.UseVisualStyleBackColor = true;
            // 
            // picFlag
            // 
            this.picFlag.Image = ((System.Drawing.Image)(resources.GetObject("picFlag.Image")));
            this.picFlag.Location = new System.Drawing.Point(12, 12);
            this.picFlag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picFlag.Name = "picFlag";
            this.picFlag.Size = new System.Drawing.Size(45, 27);
            this.picFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFlag.TabIndex = 9;
            this.picFlag.TabStop = false;
            // 
            // lblLang
            // 
            this.lblLang.AutoSize = true;
            this.lblLang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLang.Location = new System.Drawing.Point(63, 23);
            this.lblLang.Name = "lblLang";
            this.lblLang.Size = new System.Drawing.Size(38, 17);
            this.lblLang.TabIndex = 10;
            this.lblLang.Text = "ESP";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(420, 2);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 49);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // lblNotif
            // 
            this.lblNotif.AutoSize = true;
            this.lblNotif.Location = new System.Drawing.Point(283, 423);
            this.lblNotif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotif.Name = "lblNotif";
            this.lblNotif.Size = new System.Drawing.Size(186, 17);
            this.lblNotif.TabIndex = 12;
            this.lblNotif.TabStop = true;
            this.lblNotif.Text = "Notificar a un administrador.";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 450);
            this.Controls.Add(this.lblNotif);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblLang);
            this.Controls.Add(this.picFlag);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.lblOlvidoCont);
            this.Controls.Add(this.btnIniSesion);
            this.Controls.Add(this.picLight);
            this.Controls.Add(this.lblNIF);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtNif);
            this.Controls.Add(this.lblPsw);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.Text = "Inicio de sesión";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPsw;
        private System.Windows.Forms.TextBox txtNif;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblNIF;
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

