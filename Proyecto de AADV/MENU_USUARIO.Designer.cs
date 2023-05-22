namespace Proyecto_de_AADV
{
    partial class MENU_USUARIO
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
            this.MU_CLIENTES = new System.Windows.Forms.ToolStripMenuItem();
            this.MU_RESERVACIONES = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MU_CLIENTES,
            this.MU_RESERVACIONES});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MU_CLIENTES
            // 
            this.MU_CLIENTES.Name = "MU_CLIENTES";
            this.MU_CLIENTES.Size = new System.Drawing.Size(61, 20);
            this.MU_CLIENTES.Text = "Clientes";
            this.MU_CLIENTES.Click += new System.EventHandler(this.MU_CLIENTES_Click);
            // 
            // MU_RESERVACIONES
            // 
            this.MU_RESERVACIONES.Name = "MU_RESERVACIONES";
            this.MU_RESERVACIONES.Size = new System.Drawing.Size(93, 20);
            this.MU_RESERVACIONES.Text = "Reservaciones";
            this.MU_RESERVACIONES.Click += new System.EventHandler(this.MU_RESERVACIONES_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(259, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bienvenido, eliga una opción del menú.";
            // 
            // MENU_USUARIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MENU_USUARIO";
            this.Text = "Menú Usuario";
            this.Load += new System.EventHandler(this.MENU_USUARIO_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MU_CLIENTES;
        private System.Windows.Forms.ToolStripMenuItem MU_RESERVACIONES;
        private System.Windows.Forms.Label label1;
    }
}