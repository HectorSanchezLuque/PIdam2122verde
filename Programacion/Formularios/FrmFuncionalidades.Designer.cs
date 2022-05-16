
namespace ProyectoIntegradoVerde.Formularios
{
    partial class FrmFuncionalidades
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblDobleClick = new System.Windows.Forms.Label();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.lblInfo1 = new System.Windows.Forms.Label();
            this.dgvTareasPendientes = new System.Windows.Forms.DataGridView();
            this.Tid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloasignado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Publicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_limite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puntosasignados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTareasSinAsignar = new System.Windows.Forms.DataGridView();
            this.Tareaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_l = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puntos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cldCalendario = new System.Windows.Forms.MonthCalendar();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvReuniones = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtCuerpo = new System.Windows.Forms.TextBox();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvBandeja = new System.Windows.Forms.DataGridView();
            this.ideee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuerp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnComprar = new System.Windows.Forms.Button();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareasPendientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareasSinAsignar)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReuniones)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBandeja)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(867, 530);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnActualizar);
            this.tabPage1.Controls.Add(this.lblDobleClick);
            this.tabPage1.Controls.Add(this.lblInfo2);
            this.tabPage1.Controls.Add(this.lblInfo1);
            this.tabPage1.Controls.Add(this.dgvTareasPendientes);
            this.tabPage1.Controls.Add(this.dgvTareasSinAsignar);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(859, 501);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tareas";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnActualizar.Location = new System.Drawing.Point(739, 321);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(109, 29);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblDobleClick
            // 
            this.lblDobleClick.AutoSize = true;
            this.lblDobleClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDobleClick.Location = new System.Drawing.Point(486, 216);
            this.lblDobleClick.Name = "lblDobleClick";
            this.lblDobleClick.Size = new System.Drawing.Size(237, 17);
            this.lblDobleClick.TabIndex = 4;
            this.lblDobleClick.Text = "Doble click para asignarte una tarea";
            // 
            // lblInfo2
            // 
            this.lblInfo2.AutoSize = true;
            this.lblInfo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblInfo2.Location = new System.Drawing.Point(333, 280);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(147, 20);
            this.lblInfo2.TabIndex = 3;
            this.lblInfo2.Text = "Tareas pendientes";
            // 
            // lblInfo1
            // 
            this.lblInfo1.AutoSize = true;
            this.lblInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblInfo1.Location = new System.Drawing.Point(333, 16);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(150, 20);
            this.lblInfo1.TabIndex = 2;
            this.lblInfo1.Text = "Tareas disponibles";
            // 
            // dgvTareasPendientes
            // 
            this.dgvTareasPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTareasPendientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tid,
            this.tituloasignado,
            this.F_Publicacion,
            this.F_limite,
            this.puntosasignados});
            this.dgvTareasPendientes.Location = new System.Drawing.Point(129, 321);
            this.dgvTareasPendientes.Name = "dgvTareasPendientes";
            this.dgvTareasPendientes.ReadOnly = true;
            this.dgvTareasPendientes.RowHeadersWidth = 51;
            this.dgvTareasPendientes.RowTemplate.Height = 24;
            this.dgvTareasPendientes.Size = new System.Drawing.Size(580, 150);
            this.dgvTareasPendientes.TabIndex = 1;
            // 
            // Tid
            // 
            this.Tid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tid.HeaderText = "ID";
            this.Tid.MinimumWidth = 6;
            this.Tid.Name = "Tid";
            this.Tid.ReadOnly = true;
            // 
            // tituloasignado
            // 
            this.tituloasignado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tituloasignado.HeaderText = "Título";
            this.tituloasignado.MinimumWidth = 6;
            this.tituloasignado.Name = "tituloasignado";
            this.tituloasignado.ReadOnly = true;
            // 
            // F_Publicacion
            // 
            this.F_Publicacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.F_Publicacion.HeaderText = "F. Publicación";
            this.F_Publicacion.MinimumWidth = 6;
            this.F_Publicacion.Name = "F_Publicacion";
            this.F_Publicacion.ReadOnly = true;
            // 
            // F_limite
            // 
            this.F_limite.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.F_limite.HeaderText = "F. Límite";
            this.F_limite.MinimumWidth = 6;
            this.F_limite.Name = "F_limite";
            this.F_limite.ReadOnly = true;
            // 
            // puntosasignados
            // 
            this.puntosasignados.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.puntosasignados.HeaderText = "Puntos";
            this.puntosasignados.MinimumWidth = 6;
            this.puntosasignados.Name = "puntosasignados";
            this.puntosasignados.ReadOnly = true;
            // 
            // dgvTareasSinAsignar
            // 
            this.dgvTareasSinAsignar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTareasSinAsignar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tareaid,
            this.Titulo,
            this.Fecha_p,
            this.fecha_l,
            this.Puntos});
            this.dgvTareasSinAsignar.Location = new System.Drawing.Point(129, 54);
            this.dgvTareasSinAsignar.Name = "dgvTareasSinAsignar";
            this.dgvTareasSinAsignar.ReadOnly = true;
            this.dgvTareasSinAsignar.RowHeadersWidth = 51;
            this.dgvTareasSinAsignar.RowTemplate.Height = 24;
            this.dgvTareasSinAsignar.Size = new System.Drawing.Size(580, 150);
            this.dgvTareasSinAsignar.TabIndex = 0;
            this.dgvTareasSinAsignar.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTareasSinAsignar_CellMouseDoubleClick);
            // 
            // Tareaid
            // 
            this.Tareaid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tareaid.HeaderText = "ID";
            this.Tareaid.MinimumWidth = 6;
            this.Tareaid.Name = "Tareaid";
            this.Tareaid.ReadOnly = true;
            // 
            // Titulo
            // 
            this.Titulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.MinimumWidth = 6;
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            // 
            // Fecha_p
            // 
            this.Fecha_p.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fecha_p.HeaderText = "F. Publicación";
            this.Fecha_p.MinimumWidth = 6;
            this.Fecha_p.Name = "Fecha_p";
            this.Fecha_p.ReadOnly = true;
            // 
            // fecha_l
            // 
            this.fecha_l.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fecha_l.HeaderText = "F. Límite";
            this.fecha_l.MinimumWidth = 6;
            this.fecha_l.Name = "fecha_l";
            this.fecha_l.ReadOnly = true;
            // 
            // Puntos
            // 
            this.Puntos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Puntos.HeaderText = "Puntos";
            this.Puntos.MinimumWidth = 6;
            this.Puntos.Name = "Puntos";
            this.Puntos.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cldCalendario);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(859, 501);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Calendario";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cldCalendario
            // 
            this.cldCalendario.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.cldCalendario.Location = new System.Drawing.Point(209, 12);
            this.cldCalendario.Name = "cldCalendario";
            this.cldCalendario.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvReuniones);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(859, 501);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Reuniones";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvReuniones
            // 
            this.dgvReuniones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReuniones.Location = new System.Drawing.Point(12, 11);
            this.dgvReuniones.Margin = new System.Windows.Forms.Padding(4);
            this.dgvReuniones.Name = "dgvReuniones";
            this.dgvReuniones.RowHeadersWidth = 51;
            this.dgvReuniones.Size = new System.Drawing.Size(837, 478);
            this.dgvReuniones.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnLimpiar);
            this.tabPage4.Controls.Add(this.btnEnviar);
            this.tabPage4.Controls.Add(this.txtCuerpo);
            this.tabPage4.Controls.Add(this.txtDest);
            this.tabPage4.Controls.Add(this.txtAsunto);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.dgvBandeja);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Size = new System.Drawing.Size(859, 501);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Correo";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(577, 449);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(135, 42);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar campos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(718, 449);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(135, 42);
            this.btnEnviar.TabIndex = 9;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click_1);
            // 
            // txtCuerpo
            // 
            this.txtCuerpo.Location = new System.Drawing.Point(7, 267);
            this.txtCuerpo.Multiline = true;
            this.txtCuerpo.Name = "txtCuerpo";
            this.txtCuerpo.Size = new System.Drawing.Size(846, 176);
            this.txtCuerpo.TabIndex = 8;
            // 
            // txtDest
            // 
            this.txtDest.Location = new System.Drawing.Point(128, 213);
            this.txtDest.Name = "txtDest";
            this.txtDest.Size = new System.Drawing.Size(305, 22);
            this.txtDest.TabIndex = 6;
            // 
            // txtAsunto
            // 
            this.txtAsunto.Location = new System.Drawing.Point(94, 242);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(339, 22);
            this.txtAsunto.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Asunto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Destinatario:";
            // 
            // dgvBandeja
            // 
            this.dgvBandeja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBandeja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ideee,
            this.title,
            this.cuerp,
            this.recip,
            this.remit,
            this.date});
            this.dgvBandeja.Location = new System.Drawing.Point(7, 5);
            this.dgvBandeja.Name = "dgvBandeja";
            this.dgvBandeja.RowHeadersWidth = 51;
            this.dgvBandeja.RowTemplate.Height = 24;
            this.dgvBandeja.Size = new System.Drawing.Size(846, 195);
            this.dgvBandeja.TabIndex = 0;
            this.dgvBandeja.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBandeja_CellClick);
            // 
            // ideee
            // 
            this.ideee.HeaderText = "ID";
            this.ideee.MinimumWidth = 6;
            this.ideee.Name = "ideee";
            this.ideee.ReadOnly = true;
            this.ideee.Width = 125;
            // 
            // title
            // 
            this.title.HeaderText = "Asunto";
            this.title.MinimumWidth = 6;
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.Width = 125;
            // 
            // cuerp
            // 
            this.cuerp.HeaderText = "Cuerpo";
            this.cuerp.MinimumWidth = 6;
            this.cuerp.Name = "cuerp";
            this.cuerp.Width = 125;
            // 
            // recip
            // 
            this.recip.HeaderText = "Recipiente";
            this.recip.MinimumWidth = 6;
            this.recip.Name = "recip";
            this.recip.ReadOnly = true;
            this.recip.Width = 125;
            // 
            // remit
            // 
            this.remit.HeaderText = "Remitente";
            this.remit.MinimumWidth = 6;
            this.remit.Name = "remit";
            this.remit.ReadOnly = true;
            this.remit.Width = 125;
            // 
            // date
            // 
            this.date.HeaderText = "Fecha";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 125;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btnComprar);
            this.tabPage5.Controls.Add(this.lblPuntos);
            this.tabPage5.Controls.Add(this.label2);
            this.tabPage5.Controls.Add(this.dgvProductos);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage5.Size = new System.Drawing.Size(859, 501);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Tienda";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnComprar
            // 
            this.btnComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar.Location = new System.Drawing.Point(699, 448);
            this.btnComprar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(149, 41);
            this.btnComprar.TabIndex = 3;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntos.Location = new System.Drawing.Point(205, 453);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(79, 25);
            this.lblPuntos.TabIndex = 2;
            this.lblPuntos.Text = "Puntos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Puntos disponibles:";
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(7, 6);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.Size = new System.Drawing.Size(841, 420);
            this.dgvProductos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(501, 303);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(309, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 303);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(299, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // FrmFuncionalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 532);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmFuncionalidades";
            this.Text = "FrmFuncionalidades";
            this.Load += new System.EventHandler(this.FrmFuncionalidades_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareasPendientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareasSinAsignar)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReuniones)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBandeja)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dgvTareasPendientes;
        private System.Windows.Forms.DataGridView dgvTareasSinAsignar;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar cldCalendario;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridView dgvReuniones;
        private System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvBandeja;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtCuerpo;
        private System.Windows.Forms.Label lblInfo1;
        private System.Windows.Forms.Label lblInfo2;
        private System.Windows.Forms.Label lblDobleClick;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tid;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloasignado;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Publicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_limite;
        private System.Windows.Forms.DataGridViewTextBoxColumn puntosasignados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tareaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_p;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_l;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puntos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ideee;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuerp;
        private System.Windows.Forms.DataGridViewTextBoxColumn recip;
        private System.Windows.Forms.DataGridViewTextBoxColumn remit;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.Button btnActualizar;
    }
}