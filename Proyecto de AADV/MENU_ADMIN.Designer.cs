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
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ubicacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotelesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ocupaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.ocupaciónToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.ubicacionesToolStripMenuItem,
            this.hotelesToolStripMenuItem,
            this.cancelacionesToolStripMenuItem,
            this.ocupaciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.clientesToolStripMenuItem.Text = "Usuarios";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // ubicacionesToolStripMenuItem
            // 
            this.ubicacionesToolStripMenuItem.Name = "ubicacionesToolStripMenuItem";
            this.ubicacionesToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.ubicacionesToolStripMenuItem.Text = "Ubicaciones";
            // 
            // hotelesToolStripMenuItem
            // 
            this.hotelesToolStripMenuItem.Name = "hotelesToolStripMenuItem";
            this.hotelesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.hotelesToolStripMenuItem.Text = "Hoteles";
            // 
            // cancelacionesToolStripMenuItem
            // 
            this.cancelacionesToolStripMenuItem.Name = "cancelacionesToolStripMenuItem";
            this.cancelacionesToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.cancelacionesToolStripMenuItem.Text = "Cancelaciones";
            // 
            // ocupaciónToolStripMenuItem
            // 
            this.ocupaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ocupaciónToolStripMenuItem1,
            this.ventasToolStripMenuItem});
            this.ocupaciónToolStripMenuItem.Name = "ocupaciónToolStripMenuItem";
            this.ocupaciónToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.ocupaciónToolStripMenuItem.Text = "Reportes";
            this.ocupaciónToolStripMenuItem.Click += new System.EventHandler(this.ocupaciónToolStripMenuItem_Click);
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ocupaciónToolStripMenuItem1
            // 
            this.ocupaciónToolStripMenuItem1.Name = "ocupaciónToolStripMenuItem1";
            this.ocupaciónToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.ocupaciónToolStripMenuItem1.Text = "Ocupación";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ventasToolStripMenuItem.Text = "Ventas";
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
            this.Text = "Menú Admin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hotelesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ubicacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ocupaciónToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem cancelacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ocupaciónToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
    }
}