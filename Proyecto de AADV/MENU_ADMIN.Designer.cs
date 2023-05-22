namespace Proyecto_de_AADV
{
    partial class MENU_ADMIN
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
            this.MA_USUARIOS = new System.Windows.Forms.ToolStripMenuItem();
            this.MA_UBICACIONES = new System.Windows.Forms.ToolStripMenuItem();
            this.MA_HOTELES = new System.Windows.Forms.ToolStripMenuItem();
            this.ME_CANCELACIONES = new System.Windows.Forms.ToolStripMenuItem();
            this.ocupaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MA_OCUPACION = new System.Windows.Forms.ToolStripMenuItem();
            this.MA_VENTAS = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MA_USUARIOS,
            this.MA_UBICACIONES,
            this.MA_HOTELES,
            this.ME_CANCELACIONES,
            this.ocupaciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MA_USUARIOS
            // 
            this.MA_USUARIOS.Name = "MA_USUARIOS";
            this.MA_USUARIOS.Size = new System.Drawing.Size(64, 20);
            this.MA_USUARIOS.Text = "Usuarios";
            this.MA_USUARIOS.Click += new System.EventHandler(this.MA_USUARIOS_Click);
            // 
            // MA_UBICACIONES
            // 
            this.MA_UBICACIONES.Name = "MA_UBICACIONES";
            this.MA_UBICACIONES.Size = new System.Drawing.Size(83, 20);
            this.MA_UBICACIONES.Text = "Ubicaciones";
            this.MA_UBICACIONES.Click += new System.EventHandler(this.MA_UBICACIONES_Click);
            // 
            // MA_HOTELES
            // 
            this.MA_HOTELES.Name = "MA_HOTELES";
            this.MA_HOTELES.Size = new System.Drawing.Size(59, 20);
            this.MA_HOTELES.Text = "Hoteles";
            this.MA_HOTELES.Click += new System.EventHandler(this.MA_HOTELES_Click);
            // 
            // ME_CANCELACIONES
            // 
            this.ME_CANCELACIONES.Name = "ME_CANCELACIONES";
            this.ME_CANCELACIONES.Size = new System.Drawing.Size(95, 20);
            this.ME_CANCELACIONES.Text = "Cancelaciones";
            this.ME_CANCELACIONES.Click += new System.EventHandler(this.ME_CANCELACIONES_Click);
            // 
            // ocupaciónToolStripMenuItem
            // 
            this.ocupaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MA_OCUPACION,
            this.MA_VENTAS});
            this.ocupaciónToolStripMenuItem.Name = "ocupaciónToolStripMenuItem";
            this.ocupaciónToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.ocupaciónToolStripMenuItem.Text = "Reportes";
            // 
            // MA_OCUPACION
            // 
            this.MA_OCUPACION.Name = "MA_OCUPACION";
            this.MA_OCUPACION.Size = new System.Drawing.Size(180, 22);
            this.MA_OCUPACION.Text = "Ocupación";
            this.MA_OCUPACION.Click += new System.EventHandler(this.MA_OCUPACION_Click);
            // 
            // MA_VENTAS
            // 
            this.MA_VENTAS.Name = "MA_VENTAS";
            this.MA_VENTAS.Size = new System.Drawing.Size(180, 22);
            this.MA_VENTAS.Text = "Ventas";
            this.MA_VENTAS.Click += new System.EventHandler(this.MA_VENTAS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(256, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenido, eliga una opción del menú.";
            // 
            // MENU_ADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MENU_ADMIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Admin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MA_USUARIOS;
        private System.Windows.Forms.ToolStripMenuItem MA_HOTELES;
        private System.Windows.Forms.ToolStripMenuItem MA_UBICACIONES;
        private System.Windows.Forms.ToolStripMenuItem ocupaciónToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem ME_CANCELACIONES;
        private System.Windows.Forms.ToolStripMenuItem MA_OCUPACION;
        private System.Windows.Forms.ToolStripMenuItem MA_VENTAS;
    }
}