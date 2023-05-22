namespace Proyecto_de_AADV
{
    partial class INICIO_SESION
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
            this.ingresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.correo = new System.Windows.Forms.TextBox();
            this.contrasena = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ingresar
            // 
            this.ingresar.Location = new System.Drawing.Point(238, 170);
            this.ingresar.Margin = new System.Windows.Forms.Padding(2);
            this.ingresar.Name = "ingresar";
            this.ingresar.Size = new System.Drawing.Size(73, 34);
            this.ingresar.TabIndex = 0;
            this.ingresar.Text = "Ingresar";
            this.ingresar.UseVisualStyleBackColor = true;
            this.ingresar.Click += new System.EventHandler(this.ingresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Correo :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña :";
            // 
            // correo
            // 
            this.correo.Location = new System.Drawing.Point(161, 59);
            this.correo.Margin = new System.Windows.Forms.Padding(2);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(310, 20);
            this.correo.TabIndex = 3;
            // 
            // contrasena
            // 
            this.contrasena.Location = new System.Drawing.Point(161, 99);
            this.contrasena.Margin = new System.Windows.Forms.Padding(2);
            this.contrasena.Name = "contrasena";
            this.contrasena.Size = new System.Drawing.Size(310, 20);
            this.contrasena.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(247, 136);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(55, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Admin";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // INICIO_SESION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 242);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.contrasena);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ingresar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "INICIO_SESION";
            this.Text = "Inicio de sesión";
            this.Load += new System.EventHandler(this.INICIO_SESION_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ingresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox correo;
        private System.Windows.Forms.TextBox contrasena;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}