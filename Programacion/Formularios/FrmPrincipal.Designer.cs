
namespace ProyectoIntegradoVerde.Formularios
{
    partial class FrmPrincipal
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
            this.lblAbreFormulario = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.ptbInfo = new System.Windows.Forms.PictureBox();
            this.btnTareas = new System.Windows.Forms.Button();
            this.btnCalendario = new System.Windows.Forms.Button();
            this.btnReuniones = new System.Windows.Forms.Button();
            this.btnCorreo = new System.Windows.Forms.Button();
            this.btnTienda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAbreFormulario
            // 
            this.lblAbreFormulario.AutoSize = true;
            this.lblAbreFormulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))));
            this.lblAbreFormulario.Location = new System.Drawing.Point(42, 15);
            this.lblAbreFormulario.Name = "lblAbreFormulario";
            this.lblAbreFormulario.Size = new System.Drawing.Size(212, 18);
            this.lblAbreFormulario.TabIndex = 0;
            this.lblAbreFormulario.Text = "Nombre apellido apellido cargo";
            this.lblAbreFormulario.Click += new System.EventHandler(this.lblAbreFormulario_Click);
            this.lblAbreFormulario.MouseEnter += new System.EventHandler(this.lblAbreFormulario_MouseEnter);
            this.lblAbreFormulario.MouseLeave += new System.EventHandler(this.lblAbreFormulario_MouseLeave);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(470, 648);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(132, 38);
            this.btnCerrarSesion.TabIndex = 9;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // ptbInfo
            // 
            this.ptbInfo.Image = global::ProyectoIntegradoVerde.Properties.Resources._299086_info_sign_icon;
            this.ptbInfo.Location = new System.Drawing.Point(12, 12);
            this.ptbInfo.Name = "ptbInfo";
            this.ptbInfo.Size = new System.Drawing.Size(24, 23);
            this.ptbInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbInfo.TabIndex = 1;
            this.ptbInfo.TabStop = false;
            // 
            // btnTareas
            // 
            this.btnTareas.Image = global::ProyectoIntegradoVerde.Properties.Resources._8396405_clipboard_note_document_report_paper_icon;
            this.btnTareas.Location = new System.Drawing.Point(45, 81);
            this.btnTareas.Name = "btnTareas";
            this.btnTareas.Size = new System.Drawing.Size(213, 172);
            this.btnTareas.TabIndex = 10;
            this.btnTareas.UseVisualStyleBackColor = true;
            this.btnTareas.Click += new System.EventHandler(this.btnTareas_Click);
            // 
            // btnCalendario
            // 
            this.btnCalendario.Image = global::ProyectoIntegradoVerde.Properties.Resources._8725528_calendar_alt_icon;
            this.btnCalendario.Location = new System.Drawing.Point(337, 81);
            this.btnCalendario.Name = "btnCalendario";
            this.btnCalendario.Size = new System.Drawing.Size(213, 172);
            this.btnCalendario.TabIndex = 11;
            this.btnCalendario.UseVisualStyleBackColor = true;
            this.btnCalendario.Click += new System.EventHandler(this.btnCalendario_Click);
            // 
            // btnReuniones
            // 
            this.btnReuniones.Image = global::ProyectoIntegradoVerde.Properties.Resources._2932353_group_people_team_hr_humans_icon;
            this.btnReuniones.Location = new System.Drawing.Point(45, 268);
            this.btnReuniones.Name = "btnReuniones";
            this.btnReuniones.Size = new System.Drawing.Size(213, 172);
            this.btnReuniones.TabIndex = 12;
            this.btnReuniones.UseVisualStyleBackColor = true;
            this.btnReuniones.Click += new System.EventHandler(this.btnReuniones_Click);
            // 
            // btnCorreo
            // 
            this.btnCorreo.Image = global::ProyectoIntegradoVerde.Properties.Resources._7208644_application_mail_email_message_icon;
            this.btnCorreo.Location = new System.Drawing.Point(337, 268);
            this.btnCorreo.Name = "btnCorreo";
            this.btnCorreo.Size = new System.Drawing.Size(213, 172);
            this.btnCorreo.TabIndex = 13;
            this.btnCorreo.UseVisualStyleBackColor = true;
            this.btnCorreo.Click += new System.EventHandler(this.btnCorreo_Click);
            // 
            // btnTienda
            // 
            this.btnTienda.Image = global::ProyectoIntegradoVerde.Properties.Resources._3837963_shop_business_store_market_icon;
            this.btnTienda.Location = new System.Drawing.Point(196, 454);
            this.btnTienda.Name = "btnTienda";
            this.btnTienda.Size = new System.Drawing.Size(213, 172);
            this.btnTienda.TabIndex = 14;
            this.btnTienda.UseVisualStyleBackColor = true;
            this.btnTienda.Click += new System.EventHandler(this.btnTienda_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 698);
            this.Controls.Add(this.btnTienda);
            this.Controls.Add(this.btnCorreo);
            this.Controls.Add(this.btnReuniones);
            this.Controls.Add(this.btnCalendario);
            this.Controls.Add(this.btnTareas);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.ptbInfo);
            this.Controls.Add(this.lblAbreFormulario);
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.ptbInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAbreFormulario;
        private System.Windows.Forms.PictureBox ptbInfo;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnTareas;
        private System.Windows.Forms.Button btnCalendario;
        private System.Windows.Forms.Button btnReuniones;
        private System.Windows.Forms.Button btnCorreo;
        private System.Windows.Forms.Button btnTienda;
    }
}