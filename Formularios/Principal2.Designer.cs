namespace ClasesINA.Formularios
{
    partial class Principal2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.facturacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearCuentaDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.listasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formularioDeListasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturacionToolStripMenuItem,
            this.cuentasToolStripMenuItem,
            this.listasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1232, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // facturacionToolStripMenuItem
            // 
            this.facturacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturarProductosToolStripMenuItem});
            this.facturacionToolStripMenuItem.Name = "facturacionToolStripMenuItem";
            this.facturacionToolStripMenuItem.Size = new System.Drawing.Size(117, 29);
            this.facturacionToolStripMenuItem.Text = "Facturacion";
            // 
            // facturarProductosToolStripMenuItem
            // 
            this.facturarProductosToolStripMenuItem.Image = global::ClasesINA.Properties.Resources.search_engine_optimization;
            this.facturarProductosToolStripMenuItem.Name = "facturarProductosToolStripMenuItem";
            this.facturarProductosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.facturarProductosToolStripMenuItem.Size = new System.Drawing.Size(323, 34);
            this.facturarProductosToolStripMenuItem.Text = "Facturar productos";
            this.facturarProductosToolStripMenuItem.Click += new System.EventHandler(this.facturarProductosToolStripMenuItem_Click);
            // 
            // cuentasToolStripMenuItem
            // 
            this.cuentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearCuentaDeUsuarioToolStripMenuItem});
            this.cuentasToolStripMenuItem.Name = "cuentasToolStripMenuItem";
            this.cuentasToolStripMenuItem.Size = new System.Drawing.Size(91, 29);
            this.cuentasToolStripMenuItem.Text = "Cuentas";
            // 
            // crearCuentaDeUsuarioToolStripMenuItem
            // 
            this.crearCuentaDeUsuarioToolStripMenuItem.Image = global::ClasesINA.Properties.Resources.coche1;
            this.crearCuentaDeUsuarioToolStripMenuItem.Name = "crearCuentaDeUsuarioToolStripMenuItem";
            this.crearCuentaDeUsuarioToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.crearCuentaDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(362, 34);
            this.crearCuentaDeUsuarioToolStripMenuItem.Text = "Crear cuenta de usuario";
            this.crearCuentaDeUsuarioToolStripMenuItem.ToolTipText = "Esta es una vista previa para que cuando pase el mouse por encima, me de una ayud" +
    "a para saber a cual forms voy a ingresar";
            this.crearCuentaDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.crearCuentaDeUsuarioToolStripMenuItem_Click);
            // 
            // Contenedor
            // 
            this.Contenedor.AutoSize = true;
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.Location = new System.Drawing.Point(0, 33);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(1232, 681);
            this.Contenedor.TabIndex = 1;
            // 
            // listasToolStripMenuItem
            // 
            this.listasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formularioDeListasToolStripMenuItem});
            this.listasToolStripMenuItem.Name = "listasToolStripMenuItem";
            this.listasToolStripMenuItem.Size = new System.Drawing.Size(71, 29);
            this.listasToolStripMenuItem.Text = "Listas";
            // 
            // formularioDeListasToolStripMenuItem
            // 
            this.formularioDeListasToolStripMenuItem.Name = "formularioDeListasToolStripMenuItem";
            this.formularioDeListasToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.formularioDeListasToolStripMenuItem.Text = "Formulario de listas";
            this.formularioDeListasToolStripMenuItem.Click += new System.EventHandler(this.formularioDeListasToolStripMenuItem_Click);
            // 
            // Principal2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 714);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal2";
            this.Text = "Principal2";
            this.Load += new System.EventHandler(this.Principal2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem facturacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearCuentaDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.Panel Contenedor;
        private System.Windows.Forms.ToolStripMenuItem listasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formularioDeListasToolStripMenuItem;
    }
}