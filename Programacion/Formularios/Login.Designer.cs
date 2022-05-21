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
            this.btnIniSesion = new System.Windows.Forms.Button();
            this.lblOlvidoCont = new System.Windows.Forms.LinkLabel();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.lblLang = new System.Windows.Forms.Label();
            this.lblNotif = new System.Windows.Forms.LinkLabel();
            this.pcbLuz = new System.Windows.Forms.PictureBox();
            this.picFlag = new System.Windows.Forms.PictureBox();
            this.picLight = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLuz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLight)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPsw
            // 
            this.lblPsw.AutoSize = true;
            this.lblPsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPsw.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblPsw.Location = new System.Drawing.Point(46, 312);
            this.lblPsw.Name = "lblPsw";
            this.lblPsw.Size = new System.Drawing.Size(106, 24);
            this.lblPsw.TabIndex = 1;
            this.lblPsw.Text = "Contraseña";
            // 
            // txtNif
            // 
            this.txtNif.Location = new System.Drawing.Point(154, 289);
            this.txtNif.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNif.MaxLength = 9;
            this.txtNif.Name = "txtNif";
            this.txtNif.Size = new System.Drawing.Size(220, 20);
            this.txtNif.TabIndex = 2;
            this.txtNif.TextChanged += new System.EventHandler(this.txtNif_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(154, 315);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(220, 19);
            this.txtPassword.TabIndex = 3;
            // 
            // lblNIF
            // 
            this.lblNIF.AutoSize = true;
            this.lblNIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNIF.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblNIF.Location = new System.Drawing.Point(109, 286);
            this.lblNIF.Name = "lblNIF";
            this.lblNIF.Size = new System.Drawing.Size(40, 24);
            this.lblNIF.TabIndex = 4;
            this.lblNIF.Text = "NIF";
            // 
            // btnIniSesion
            // 
            this.btnIniSesion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIniSesion.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnIniSesion.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnIniSesion.Location = new System.Drawing.Point(269, 381);
            this.btnIniSesion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIniSesion.Name = "btnIniSesion";
            this.btnIniSesion.Size = new System.Drawing.Size(105, 44);
            this.btnIniSesion.TabIndex = 6;
            this.btnIniSesion.Text = "Iniciar sesión";
            this.btnIniSesion.UseVisualStyleBackColor = false;
            this.btnIniSesion.Click += new System.EventHandler(this.btnIniSesion_Click);
            // 
            // lblOlvidoCont
            // 
            this.lblOlvidoCont.AutoSize = true;
            this.lblOlvidoCont.LinkColor = System.Drawing.Color.RoyalBlue;
            this.lblOlvidoCont.Location = new System.Drawing.Point(181, 346);
            this.lblOlvidoCont.Name = "lblOlvidoCont";
            this.lblOlvidoCont.Size = new System.Drawing.Size(149, 13);
            this.lblOlvidoCont.TabIndex = 7;
            this.lblOlvidoCont.TabStop = true;
            this.lblOlvidoCont.Text = "¿Has olvidado tu contraseña?";
            this.lblOlvidoCont.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblOlvidoCont_LinkClicked);
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistro.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnRegistro.Location = new System.Drawing.Point(127, 381);
            this.btnRegistro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(105, 44);
            this.btnRegistro.TabIndex = 8;
            this.btnRegistro.Text = "Registrar usuario";
            this.btnRegistro.UseVisualStyleBackColor = false;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // lblLang
            // 
            this.lblLang.AutoSize = true;
            this.lblLang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLang.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblLang.Location = new System.Drawing.Point(63, 64);
            this.lblLang.Name = "lblLang";
            this.lblLang.Size = new System.Drawing.Size(31, 13);
            this.lblLang.TabIndex = 10;
            this.lblLang.Text = "ESP";
            // 
            // lblNotif
            // 
            this.lblNotif.AutoSize = true;
            this.lblNotif.LinkColor = System.Drawing.Color.CornflowerBlue;
            this.lblNotif.Location = new System.Drawing.Point(333, 468);
            this.lblNotif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotif.Name = "lblNotif";
            this.lblNotif.Size = new System.Drawing.Size(138, 13);
            this.lblNotif.TabIndex = 12;
            this.lblNotif.TabStop = true;
            this.lblNotif.Text = "Notificar a un administrador.";
            this.lblNotif.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblNotif_LinkClicked);
            // 
            // pcbLuz
            // 
            this.pcbLuz.Image = ((System.Drawing.Image)(resources.GetObject("pcbLuz.Image")));
            this.pcbLuz.InitialImage = ((System.Drawing.Image)(resources.GetObject("pcbLuz.InitialImage")));
            this.pcbLuz.Location = new System.Drawing.Point(438, 51);
            this.pcbLuz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcbLuz.Name = "pcbLuz";
            this.pcbLuz.Size = new System.Drawing.Size(28, 40);
            this.pcbLuz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLuz.TabIndex = 11;
            this.pcbLuz.TabStop = false;
            this.pcbLuz.Click += new System.EventHandler(this.pcbLuz_Click);
            // 
            // picFlag
            // 
            this.picFlag.Image = global::ProyectoIntegradoVerde.Properties.Resources.spFlag;
            this.picFlag.Location = new System.Drawing.Point(12, 51);
            this.picFlag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picFlag.Name = "picFlag";
            this.picFlag.Size = new System.Drawing.Size(45, 27);
            this.picFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFlag.TabIndex = 9;
            this.picFlag.TabStop = false;
            this.picFlag.Click += new System.EventHandler(this.picFlag_Click);
            // 
            // picLight
            // 
            this.picLight.Image = ((System.Drawing.Image)(resources.GetObject("picLight.Image")));
            this.picLight.Location = new System.Drawing.Point(165, 89);
            this.picLight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picLight.Name = "picLight";
            this.picLight.Size = new System.Drawing.Size(176, 167);
            this.picLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLight.TabIndex = 5;
            this.picLight.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Location = new System.Drawing.Point(-10, 490);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 44);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Location = new System.Drawing.Point(-10, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(526, 44);
            this.panel2.TabIndex = 14;
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(478, 534);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNotif);
            this.Controls.Add(this.pcbLuz);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesión";
            this.Load += new System.EventHandler(this.Login_Load);
            this.SizeChanged += new System.EventHandler(this.Login_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLuz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLight)).EndInit();
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
        private System.Windows.Forms.PictureBox pcbLuz;
        private System.Windows.Forms.LinkLabel lblNotif;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

