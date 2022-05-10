
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAbreFormulario
            // 
            this.lblAbreFormulario.AutoSize = true;
            this.lblAbreFormulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))));
            this.lblAbreFormulario.Location = new System.Drawing.Point(42, 17);
            this.lblAbreFormulario.Name = "lblAbreFormulario";
            this.lblAbreFormulario.Size = new System.Drawing.Size(212, 18);
            this.lblAbreFormulario.TabIndex = 0;
            this.lblAbreFormulario.Text = "Nombre apellido apellido cargo";
            this.lblAbreFormulario.Click += new System.EventHandler(this.lblAbreFormulario_Click);
            this.lblAbreFormulario.MouseEnter += new System.EventHandler(this.lblAbreFormulario_MouseEnter);
            this.lblAbreFormulario.MouseLeave += new System.EventHandler(this.lblAbreFormulario_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoIntegradoVerde.Properties.Resources._299086_info_sign_icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 543);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAbreFormulario);
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAbreFormulario;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}