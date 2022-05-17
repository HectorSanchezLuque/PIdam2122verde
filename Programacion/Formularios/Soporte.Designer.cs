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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnInforme = new System.Windows.Forms.Button();
            this.txtInforme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSolMail = new System.Windows.Forms.Button();
            this.txtSolMail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabSoporte.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSoporte
            // 
            this.tabSoporte.Controls.Add(this.tabPage1);
            this.tabSoporte.Controls.Add(this.tabPage2);
            this.tabSoporte.Location = new System.Drawing.Point(0, 0);
            this.tabSoporte.Name = "tabSoporte";
            this.tabSoporte.SelectedIndex = 0;
            this.tabSoporte.Size = new System.Drawing.Size(576, 260);
            this.tabSoporte.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnInforme);
            this.tabPage1.Controls.Add(this.txtInforme);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(568, 231);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Notificar error";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnInforme
            // 
            this.btnInforme.Location = new System.Drawing.Point(219, 188);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(121, 37);
            this.btnInforme.TabIndex = 2;
            this.btnInforme.Text = "Enviar informe";
            this.btnInforme.UseVisualStyleBackColor = true;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // txtInforme
            // 
            this.txtInforme.Location = new System.Drawing.Point(3, 27);
            this.txtInforme.Multiline = true;
            this.txtInforme.Name = "txtInforme";
            this.txtInforme.Size = new System.Drawing.Size(562, 155);
            this.txtInforme.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Por favor, describa el error de la manera más precisa posible:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btnSolMail);
            this.tabPage2.Controls.Add(this.txtSolMail);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(568, 231);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Recuperar contraseña";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(514, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Un administrador contactara con usted via SMS con su nueva contraseña.";
            // 
            // btnSolMail
            // 
            this.btnSolMail.Location = new System.Drawing.Point(216, 130);
            this.btnSolMail.Name = "btnSolMail";
            this.btnSolMail.Size = new System.Drawing.Size(116, 32);
            this.btnSolMail.TabIndex = 2;
            this.btnSolMail.Text = "Enviar";
            this.btnSolMail.UseVisualStyleBackColor = true;
            this.btnSolMail.Click += new System.EventHandler(this.btnSolMail_Click);
            // 
            // txtSolMail
            // 
            this.txtSolMail.Location = new System.Drawing.Point(102, 102);
            this.txtSolMail.Name = "txtSolMail";
            this.txtSolMail.Size = new System.Drawing.Size(354, 22);
            this.txtSolMail.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Inserte el correo electrónico asociado a su cuenta:";
            // 
            // Soporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 262);
            this.Controls.Add(this.tabSoporte);
            this.Name = "Soporte";
            this.Text = "Soporte";
            this.Load += new System.EventHandler(this.Soporte_Load);
            this.tabSoporte.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabSoporte;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnInforme;
        private System.Windows.Forms.TextBox txtInforme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSolMail;
        private System.Windows.Forms.TextBox txtSolMail;
        private System.Windows.Forms.Label label2;
    }
}