namespace ServiciosTecnicos {
    partial class Menu {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.funcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.corporativosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.especializadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.callCenterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pielesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.callCenterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosCorporativosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosEspecializadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionesToolStripMenuItem,
            this.pielesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(533, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // funcionesToolStripMenuItem
            // 
            this.funcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.corporativosToolStripMenuItem,
            this.especializadosToolStripMenuItem,
            this.callCenterToolStripMenuItem1});
            this.funcionesToolStripMenuItem.Name = "funcionesToolStripMenuItem";
            this.funcionesToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.funcionesToolStripMenuItem.Text = "Servicios";
            // 
            // corporativosToolStripMenuItem
            // 
            this.corporativosToolStripMenuItem.Name = "corporativosToolStripMenuItem";
            this.corporativosToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.corporativosToolStripMenuItem.Text = "Corporativos";
            this.corporativosToolStripMenuItem.Click += new System.EventHandler(this.corporativosToolStripMenuItem_Click);
            // 
            // especializadosToolStripMenuItem
            // 
            this.especializadosToolStripMenuItem.Name = "especializadosToolStripMenuItem";
            this.especializadosToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.especializadosToolStripMenuItem.Text = "Especializados";
            this.especializadosToolStripMenuItem.Click += new System.EventHandler(this.especializadosToolStripMenuItem_Click);
            // 
            // callCenterToolStripMenuItem1
            // 
            this.callCenterToolStripMenuItem1.Name = "callCenterToolStripMenuItem1";
            this.callCenterToolStripMenuItem1.Size = new System.Drawing.Size(169, 22);
            this.callCenterToolStripMenuItem1.Text = "Call Center";
            this.callCenterToolStripMenuItem1.Click += new System.EventHandler(this.callCenterToolStripMenuItem1_Click);
            // 
            // pielesToolStripMenuItem
            // 
            this.pielesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.animeToolStripMenuItem,
            this.profesionalToolStripMenuItem});
            this.pielesToolStripMenuItem.Name = "pielesToolStripMenuItem";
            this.pielesToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pielesToolStripMenuItem.Text = "Pieles";
            // 
            // animeToolStripMenuItem
            // 
            this.animeToolStripMenuItem.Name = "animeToolStripMenuItem";
            this.animeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.animeToolStripMenuItem.Text = "Anime";
            this.animeToolStripMenuItem.Click += new System.EventHandler(this.animeToolStripMenuItem_Click);
            // 
            // profesionalToolStripMenuItem
            // 
            this.profesionalToolStripMenuItem.Name = "profesionalToolStripMenuItem";
            this.profesionalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.profesionalToolStripMenuItem.Text = "Profesional";
            this.profesionalToolStripMenuItem.Click += new System.EventHandler(this.profesionalToolStripMenuItem_Click);
            // 
            // callCenterToolStripMenuItem
            // 
            this.callCenterToolStripMenuItem.Name = "callCenterToolStripMenuItem";
            this.callCenterToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.callCenterToolStripMenuItem.Text = "Call Center";
            this.callCenterToolStripMenuItem.Click += new System.EventHandler(this.abrirOpcion);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackgroundImage = global::ServiciosTecnicos.Properties.Resources.A;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrincipalToolStripMenuItem,
            this.serviciosCorporativosToolStripMenuItem,
            this.serviciosEspecializadosToolStripMenuItem,
            this.callCenterToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(232, 120);
            // 
            // menuPrincipalToolStripMenuItem
            // 
            this.menuPrincipalToolStripMenuItem.Name = "menuPrincipalToolStripMenuItem";
            this.menuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.menuPrincipalToolStripMenuItem.Text = "Menu Principal";
            this.menuPrincipalToolStripMenuItem.Click += new System.EventHandler(this.abrirOpcion);
            // 
            // serviciosCorporativosToolStripMenuItem
            // 
            this.serviciosCorporativosToolStripMenuItem.Name = "serviciosCorporativosToolStripMenuItem";
            this.serviciosCorporativosToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.serviciosCorporativosToolStripMenuItem.Text = "Servicios Corporativos";
            this.serviciosCorporativosToolStripMenuItem.Click += new System.EventHandler(this.abrirOpcion);
            // 
            // serviciosEspecializadosToolStripMenuItem
            // 
            this.serviciosEspecializadosToolStripMenuItem.Name = "serviciosEspecializadosToolStripMenuItem";
            this.serviciosEspecializadosToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.serviciosEspecializadosToolStripMenuItem.Text = "Servicios Especializados";
            this.serviciosEspecializadosToolStripMenuItem.Click += new System.EventHandler(this.abrirOpcion);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(228, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.abrirOpcion);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::ServiciosTecnicos.Properties.Resources.V;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(533, 368);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem funcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem corporativosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem especializadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviciosCorporativosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviciosEspecializadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem callCenterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem callCenterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pielesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem animeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesionalToolStripMenuItem;
    }
}

