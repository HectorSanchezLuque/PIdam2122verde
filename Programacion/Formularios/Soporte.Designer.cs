namespace ProyectoIntegradoVerde.Formularios
{
    partial class Soporte
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
            this.tabSoporte = new System.Windows.Forms.TabControl();
            this.tabPague1 = new System.Windows.Forms.TabPage();
            this.btnInforme = new System.Windows.Forms.Button();
            this.txtInforme = new System.Windows.Forms.TextBox();
            this.lbltitle = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblMess = new System.Windows.Forms.Label();
            this.btnSolMail = new System.Windows.Forms.Button();
            this.txtSolMail = new System.Windows.Forms.TextBox();
            this.lblrecup = new System.Windows.Forms.Label();
            this.tabSoporte.SuspendLayout();
            this.tabPague1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSoporte
            // 
            this.tabSoporte.Controls.Add(this.tabPague1);
            this.tabSoporte.Controls.Add(this.tabPage2);
            this.tabSoporte.Location = new System.Drawing.Point(0, 0);
            this.tabSoporte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabSoporte.Name = "tabSoporte";
            this.tabSoporte.SelectedIndex = 0;
            this.tabSoporte.Size = new System.Drawing.Size(432, 211);
            this.tabSoporte.TabIndex = 0;
            // 
            // tabPague1
            // 
            this.tabPague1.Controls.Add(this.btnInforme);
            this.tabPague1.Controls.Add(this.txtInforme);
            this.tabPague1.Controls.Add(this.lbltitle);
            this.tabPague1.Location = new System.Drawing.Point(4, 22);
            this.tabPague1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPague1.Name = "tabPague1";
            this.tabPague1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPague1.Size = new System.Drawing.Size(424, 185);
            this.tabPague1.TabIndex = 0;
            this.tabPague1.Text = "Notificar error";
            this.tabPague1.UseVisualStyleBackColor = true;
            this.tabPague1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnInforme
            // 
            this.btnInforme.Location = new System.Drawing.Point(164, 153);
            this.btnInforme.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(91, 30);
            this.btnInforme.TabIndex = 2;
            this.btnInforme.Text = "Enviar informe";
            this.btnInforme.UseVisualStyleBackColor = true;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // txtInforme
            // 
            this.txtInforme.Location = new System.Drawing.Point(2, 22);
            this.txtInforme.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInforme.Multiline = true;
            this.txtInforme.Name = "txtInforme";
            this.txtInforme.Size = new System.Drawing.Size(422, 127);
            this.txtInforme.TabIndex = 1;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(50, 6);
            this.lbltitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(355, 13);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Por favor, describa el error de la manera más precisa posible:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblMess);
            this.tabPage2.Controls.Add(this.btnSolMail);
            this.tabPage2.Controls.Add(this.txtSolMail);
            this.tabPage2.Controls.Add(this.lblrecup);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(424, 185);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Recuperar contraseña";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblMess
            // 
            this.lblMess.AutoSize = true;
            this.lblMess.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMess.Location = new System.Drawing.Point(34, 162);
            this.lblMess.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMess.Name = "lblMess";
            this.lblMess.Size = new System.Drawing.Size(379, 13);
            this.lblMess.TabIndex = 3;
            this.lblMess.Text = "Un administrador contactara con usted con su nueva contraseña.";
            // 
            // btnSolMail
            // 
            this.btnSolMail.Location = new System.Drawing.Point(162, 106);
            this.btnSolMail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSolMail.Name = "btnSolMail";
            this.btnSolMail.Size = new System.Drawing.Size(87, 26);
            this.btnSolMail.TabIndex = 2;
            this.btnSolMail.Text = "Enviar";
            this.btnSolMail.UseVisualStyleBackColor = true;
            this.btnSolMail.Click += new System.EventHandler(this.btnSolMail_Click);
            // 
            // txtSolMail
            // 
            this.txtSolMail.Location = new System.Drawing.Point(76, 83);
            this.txtSolMail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSolMail.Name = "txtSolMail";
            this.txtSolMail.Size = new System.Drawing.Size(266, 20);
            this.txtSolMail.TabIndex = 1;
            // 
            // lblrecup
            // 
            this.lblrecup.AutoSize = true;
            this.lblrecup.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrecup.Location = new System.Drawing.Point(74, 60);
            this.lblrecup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblrecup.Name = "lblrecup";
            this.lblrecup.Size = new System.Drawing.Size(297, 13);
            this.lblrecup.TabIndex = 0;
            this.lblrecup.Text = "Inserte el correo electrónico asociado a su cuenta:";
            // 
            // Soporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 213);
            this.Controls.Add(this.tabSoporte);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Soporte";
            this.Text = "Soporte";
            this.Load += new System.EventHandler(this.Soporte_Load);
            this.tabSoporte.ResumeLayout(false);
            this.tabPague1.ResumeLayout(false);
            this.tabPague1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabSoporte;
        private System.Windows.Forms.TabPage tabPague1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnInforme;
        private System.Windows.Forms.TextBox txtInforme;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lblMess;
        private System.Windows.Forms.Button btnSolMail;
        private System.Windows.Forms.TextBox txtSolMail;
        private System.Windows.Forms.Label lblrecup;
    }
}