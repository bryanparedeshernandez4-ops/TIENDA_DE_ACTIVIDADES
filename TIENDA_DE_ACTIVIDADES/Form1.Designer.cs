namespace TIENDA_DE_ACTIVIDADES
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.elegirColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restablecerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.chkNotificaciones = new System.Windows.Forms.CheckBox();
            this.chkRecordatorios = new System.Windows.Forms.CheckBox();
            this.clbActividades = new System.Windows.Forms.CheckedListBox();
            this.cmbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.btnRestablecer = new System.Windows.Forms.Button();
            this.lblResumen = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panelPrincipal.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.AliceBlue;
            this.panelPrincipal.ContextMenuStrip = this.contextMenuStrip1;
            this.panelPrincipal.Controls.Add(this.lblTitulo);
            this.panelPrincipal.Controls.Add(this.chkNotificaciones);
            this.panelPrincipal.Controls.Add(this.chkRecordatorios);
            this.panelPrincipal.Controls.Add(this.clbActividades);
            this.panelPrincipal.Controls.Add(this.cmbTipoUsuario);
            this.panelPrincipal.Controls.Add(this.lblTipo);
            this.panelPrincipal.Controls.Add(this.btnColor);
            this.panelPrincipal.Controls.Add(this.btnAplicar);
            this.panelPrincipal.Controls.Add(this.btnRestablecer);
            this.panelPrincipal.Controls.Add(this.lblResumen);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(643, 451);
            this.panelPrincipal.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.elegirColorToolStripMenuItem,
            this.restablecerToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(135, 70);
            // 
            // elegirColorToolStripMenuItem
            // 
            this.elegirColorToolStripMenuItem.Name = "elegirColorToolStripMenuItem";
            this.elegirColorToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.elegirColorToolStripMenuItem.Text = "Elegir color";
            this.elegirColorToolStripMenuItem.Click += new System.EventHandler(this.elegirColorToolStripMenuItem_Click);
            // 
            // restablecerToolStripMenuItem
            // 
            this.restablecerToolStripMenuItem.Name = "restablecerToolStripMenuItem";
            this.restablecerToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.restablecerToolStripMenuItem.Text = "Restablecer";
            this.restablecerToolStripMenuItem.Click += new System.EventHandler(this.restablecerToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(214, 17);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(213, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "MIS PREFERENCIAS";
            // 
            // chkNotificaciones
            // 
            this.chkNotificaciones.AutoSize = true;
            this.chkNotificaciones.Checked = true;
            this.chkNotificaciones.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNotificaciones.Location = new System.Drawing.Point(43, 69);
            this.chkNotificaciones.Name = "chkNotificaciones";
            this.chkNotificaciones.Size = new System.Drawing.Size(156, 17);
            this.chkNotificaciones.TabIndex = 1;
            this.chkNotificaciones.Text = "Deseo recibir notificaciones";
            // 
            // chkRecordatorios
            // 
            this.chkRecordatorios.AutoSize = true;
            this.chkRecordatorios.Checked = true;
            this.chkRecordatorios.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRecordatorios.Location = new System.Drawing.Point(43, 95);
            this.chkRecordatorios.Name = "chkRecordatorios";
            this.chkRecordatorios.Size = new System.Drawing.Size(152, 17);
            this.chkRecordatorios.TabIndex = 2;
            this.chkRecordatorios.Text = "Deseo recibir recordatorios";
            // 
            // clbActividades
            // 
            this.clbActividades.CheckOnClick = true;
            this.clbActividades.FormattingEnabled = true;
            this.clbActividades.Items.AddRange(new object[] {
            "Leer",
            "Practicar deporte",
            "Escuchar música",
            "Programar",
            "Ver películas"});
            this.clbActividades.Location = new System.Drawing.Point(43, 130);
            this.clbActividades.Name = "clbActividades";
            this.clbActividades.Size = new System.Drawing.Size(189, 79);
            this.clbActividades.TabIndex = 3;
            // 
            // cmbTipoUsuario
            // 
            this.cmbTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoUsuario.FormattingEnabled = true;
            this.cmbTipoUsuario.Items.AddRange(new object[] {
            "Estudiante",
            "Docente",
            "Invitado"});
            this.cmbTipoUsuario.Location = new System.Drawing.Point(386, 152);
            this.cmbTipoUsuario.Name = "cmbTipoUsuario";
            this.cmbTipoUsuario.Size = new System.Drawing.Size(172, 21);
            this.cmbTipoUsuario.TabIndex = 4;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(386, 130);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(83, 13);
            this.lblTipo.TabIndex = 5;
            this.lblTipo.Text = "Tipo de usuario:";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(43, 260);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(103, 26);
            this.btnColor.TabIndex = 6;
            this.btnColor.Text = "Elegir color";
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(171, 260);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(137, 26);
            this.btnAplicar.TabIndex = 7;
            this.btnAplicar.Text = "Aplicar preferencias";
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // btnRestablecer
            // 
            this.btnRestablecer.Location = new System.Drawing.Point(334, 260);
            this.btnRestablecer.Name = "btnRestablecer";
            this.btnRestablecer.Size = new System.Drawing.Size(103, 26);
            this.btnRestablecer.TabIndex = 8;
            this.btnRestablecer.Text = "Restablecer";
            this.btnRestablecer.Click += new System.EventHandler(this.btnRestablecer_Click);
            // 
            // lblResumen
            // 
            this.lblResumen.AutoSize = true;
            this.lblResumen.Location = new System.Drawing.Point(43, 312);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Size = new System.Drawing.Size(157, 13);
            this.lblResumen.TabIndex = 9;
            this.lblResumen.Text = "Tus preferencias aparecen aqui";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 451);
            this.Controls.Add(this.panelPrincipal);
            this.Name = "Form1";
            this.Text = "Configurador de preferencias";
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.CheckBox chkNotificaciones;
        private System.Windows.Forms.CheckBox chkRecordatorios;
        private System.Windows.Forms.CheckedListBox clbActividades;
        private System.Windows.Forms.ComboBox cmbTipoUsuario;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Button btnRestablecer;
        private System.Windows.Forms.Label lblResumen;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem elegirColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restablecerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}