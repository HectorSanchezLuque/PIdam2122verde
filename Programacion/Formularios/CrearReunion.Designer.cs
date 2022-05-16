
namespace ProyectoIntegradoVerde.Formularios
{
    partial class CrearReunion
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
            this.txtRNombre = new System.Windows.Forms.TextBox();
            this.lblCrearReunion = new System.Windows.Forms.Label();
            this.lblRNombre = new System.Windows.Forms.Label();
            this.lblRDesc = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRNombre
            // 
            this.txtRNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRNombre.Location = new System.Drawing.Point(325, 119);
            this.txtRNombre.Name = "txtRNombre";
            this.txtRNombre.Size = new System.Drawing.Size(331, 30);
            this.txtRNombre.TabIndex = 0;
            // 
            // lblCrearReunion
            // 
            this.lblCrearReunion.AutoSize = true;
            this.lblCrearReunion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblCrearReunion.Location = new System.Drawing.Point(318, 20);
            this.lblCrearReunion.Name = "lblCrearReunion";
            this.lblCrearReunion.Size = new System.Drawing.Size(338, 39);
            this.lblCrearReunion.TabIndex = 1;
            this.lblCrearReunion.Text = "Creación de Reunión";
            // 
            // lblRNombre
            // 
            this.lblRNombre.AutoSize = true;
            this.lblRNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblRNombre.Location = new System.Drawing.Point(206, 119);
            this.lblRNombre.Name = "lblRNombre";
            this.lblRNombre.Size = new System.Drawing.Size(113, 29);
            this.lblRNombre.TabIndex = 2;
            this.lblRNombre.Text = "Nombre: ";
            // 
            // lblRDesc
            // 
            this.lblRDesc.AutoSize = true;
            this.lblRDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblRDesc.Location = new System.Drawing.Point(166, 207);
            this.lblRDesc.Name = "lblRDesc";
            this.lblRDesc.Size = new System.Drawing.Size(153, 29);
            this.lblRDesc.TabIndex = 3;
            this.lblRDesc.Text = "Descripción: ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(325, 206);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(331, 30);
            this.textBox1.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(187, 353);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(112, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(166, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Descripción: ";
            // 
            // CrearReunion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 577);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblRDesc);
            this.Controls.Add(this.lblRNombre);
            this.Controls.Add(this.lblCrearReunion);
            this.Controls.Add(this.txtRNombre);
            this.Name = "CrearReunion";
            this.Text = "CrearReunion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRNombre;
        private System.Windows.Forms.Label lblCrearReunion;
        private System.Windows.Forms.Label lblRNombre;
        private System.Windows.Forms.Label lblRDesc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
    }
}