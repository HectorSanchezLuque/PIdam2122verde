
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
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFechaReunion = new System.Windows.Forms.Label();
            this.lblHoraReunion = new System.Windows.Forms.Label();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.btnCrearReunion = new System.Windows.Forms.Button();
            this.cmbCargos = new System.Windows.Forms.ComboBox();
            this.lblCargos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRNombre
            // 
            this.txtRNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRNombre.Location = new System.Drawing.Point(357, 120);
            this.txtRNombre.Name = "txtRNombre";
            this.txtRNombre.Size = new System.Drawing.Size(319, 30);
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
            this.lblRNombre.Location = new System.Drawing.Point(226, 120);
            this.lblRNombre.Name = "lblRNombre";
            this.lblRNombre.Size = new System.Drawing.Size(113, 29);
            this.lblRNombre.TabIndex = 2;
            this.lblRNombre.Text = "Nombre: ";
            // 
            // lblRDesc
            // 
            this.lblRDesc.AutoSize = true;
            this.lblRDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblRDesc.Location = new System.Drawing.Point(186, 208);
            this.lblRDesc.Name = "lblRDesc";
            this.lblRDesc.Size = new System.Drawing.Size(153, 29);
            this.lblRDesc.TabIndex = 3;
            this.lblRDesc.Text = "Descripción: ";
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDesc.Location = new System.Drawing.Point(357, 207);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(319, 30);
            this.txtDesc.TabIndex = 4;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(224, 461);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(112, 22);
            this.dtpFecha.TabIndex = 5;
            // 
            // lblFechaReunion
            // 
            this.lblFechaReunion.AutoSize = true;
            this.lblFechaReunion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblFechaReunion.Location = new System.Drawing.Point(179, 392);
            this.lblFechaReunion.Name = "lblFechaReunion";
            this.lblFechaReunion.Size = new System.Drawing.Size(235, 29);
            this.lblFechaReunion.TabIndex = 6;
            this.lblFechaReunion.Text = "Fecha de la Reunión";
            // 
            // lblHoraReunion
            // 
            this.lblHoraReunion.AutoSize = true;
            this.lblHoraReunion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblHoraReunion.Location = new System.Drawing.Point(543, 392);
            this.lblHoraReunion.Name = "lblHoraReunion";
            this.lblHoraReunion.Size = new System.Drawing.Size(220, 29);
            this.lblHoraReunion.TabIndex = 7;
            this.lblHoraReunion.Text = "Hora de la Reunión";
            // 
            // dtpHora
            // 
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(605, 461);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.Size = new System.Drawing.Size(112, 22);
            this.dtpHora.TabIndex = 8;
            // 
            // btnCrearReunion
            // 
            this.btnCrearReunion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCrearReunion.Location = new System.Drawing.Point(402, 529);
            this.btnCrearReunion.Name = "btnCrearReunion";
            this.btnCrearReunion.Size = new System.Drawing.Size(156, 36);
            this.btnCrearReunion.TabIndex = 9;
            this.btnCrearReunion.Text = "Crear Reunión";
            this.btnCrearReunion.UseVisualStyleBackColor = true;
            this.btnCrearReunion.Click += new System.EventHandler(this.btnCrearReunion_Click);
            // 
            // cmbCargos
            // 
            this.cmbCargos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbCargos.FormattingEnabled = true;
            this.cmbCargos.Location = new System.Drawing.Point(357, 293);
            this.cmbCargos.Name = "cmbCargos";
            this.cmbCargos.Size = new System.Drawing.Size(221, 33);
            this.cmbCargos.TabIndex = 10;
            // 
            // lblCargos
            // 
            this.lblCargos.AutoSize = true;
            this.lblCargos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblCargos.Location = new System.Drawing.Point(120, 293);
            this.lblCargos.Name = "lblCargos";
            this.lblCargos.Size = new System.Drawing.Size(219, 29);
            this.lblCargos.TabIndex = 11;
            this.lblCargos.Text = "Cargos asociados: ";
            // 
            // CrearReunion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 577);
            this.Controls.Add(this.lblCargos);
            this.Controls.Add(this.cmbCargos);
            this.Controls.Add(this.btnCrearReunion);
            this.Controls.Add(this.dtpHora);
            this.Controls.Add(this.lblHoraReunion);
            this.Controls.Add(this.lblFechaReunion);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.lblRDesc);
            this.Controls.Add(this.lblRNombre);
            this.Controls.Add(this.lblCrearReunion);
            this.Controls.Add(this.txtRNombre);
            this.Name = "CrearReunion";
            this.Text = "CrearReunion";
            this.Load += new System.EventHandler(this.CrearReunion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRNombre;
        private System.Windows.Forms.Label lblCrearReunion;
        private System.Windows.Forms.Label lblRNombre;
        private System.Windows.Forms.Label lblRDesc;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFechaReunion;
        private System.Windows.Forms.Label lblHoraReunion;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.Button btnCrearReunion;
        private System.Windows.Forms.ComboBox cmbCargos;
        private System.Windows.Forms.Label lblCargos;
    }
}