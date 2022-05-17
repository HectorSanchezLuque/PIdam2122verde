
namespace ProyectoIntegradoVerde.Formularios
{
    partial class FrmDatos
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNomUser = new System.Windows.Forms.Label();
            this.lblDetalles = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.ptbFoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Location = new System.Drawing.Point(12, 271);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(117, 29);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre ";
            // 
            // lblNomUser
            // 
            this.lblNomUser.AutoSize = true;
            this.lblNomUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblNomUser.Location = new System.Drawing.Point(35, 312);
            this.lblNomUser.Name = "lblNomUser";
            this.lblNomUser.Size = new System.Drawing.Size(41, 18);
            this.lblNomUser.TabIndex = 1;
            this.lblNomUser.Text = "Nom";
            // 
            // lblDetalles
            // 
            this.lblDetalles.AutoSize = true;
            this.lblDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lblDetalles.Location = new System.Drawing.Point(12, 217);
            this.lblDetalles.Name = "lblDetalles";
            this.lblDetalles.Size = new System.Drawing.Size(260, 29);
            this.lblDetalles.TabIndex = 2;
            this.lblDetalles.Text = "Detalles del Usuario";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lblCode.Location = new System.Drawing.Point(12, 365);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(265, 29);
            this.lblCode.TabIndex = 3;
            this.lblCode.Text = "Código de empleado";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblCodigo.Location = new System.Drawing.Point(35, 415);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(41, 18);
            this.lblCodigo.TabIndex = 4;
            this.lblCodigo.Text = "Nom";
            // 
            // ptbFoto
            // 
            this.ptbFoto.Location = new System.Drawing.Point(273, 64);
            this.ptbFoto.Name = "ptbFoto";
            this.ptbFoto.Size = new System.Drawing.Size(100, 50);
            this.ptbFoto.TabIndex = 5;
            this.ptbFoto.TabStop = false;
            // 
            // FrmDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 531);
            this.Controls.Add(this.ptbFoto);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblDetalles);
            this.Controls.Add(this.lblNomUser);
            this.Controls.Add(this.lblNombre);
            this.Name = "FrmDatos";
            this.Text = "FrmDatos";
            this.Load += new System.EventHandler(this.FrmDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNomUser;
        private System.Windows.Forms.Label lblDetalles;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.PictureBox ptbFoto;
    }
}