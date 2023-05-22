namespace Proyecto_de_AADV
{
    partial class LISTA_DE_USUARIOS
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
            this.LU_REGISTRAR = new System.Windows.Forms.Button();
            this.LU_HABILITAR = new System.Windows.Forms.Button();
            this.contrasena_temporal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LU_ELIMINAR = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LU_REGISTRAR
            // 
            this.LU_REGISTRAR.Location = new System.Drawing.Point(40, 31);
            this.LU_REGISTRAR.Margin = new System.Windows.Forms.Padding(2);
            this.LU_REGISTRAR.Name = "LU_REGISTRAR";
            this.LU_REGISTRAR.Size = new System.Drawing.Size(66, 19);
            this.LU_REGISTRAR.TabIndex = 2;
            this.LU_REGISTRAR.Text = "Registrar";
            this.LU_REGISTRAR.UseVisualStyleBackColor = true;
            this.LU_REGISTRAR.Click += new System.EventHandler(this.LU_REGISTRAR_Click);
            // 
            // LU_HABILITAR
            // 
            this.LU_HABILITAR.Location = new System.Drawing.Point(574, 30);
            this.LU_HABILITAR.Margin = new System.Windows.Forms.Padding(2);
            this.LU_HABILITAR.Name = "LU_HABILITAR";
            this.LU_HABILITAR.Size = new System.Drawing.Size(66, 19);
            this.LU_HABILITAR.TabIndex = 4;
            this.LU_HABILITAR.Text = "Habilitar";
            this.LU_HABILITAR.UseVisualStyleBackColor = true;
            // 
            // contrasena_temporal
            // 
            this.contrasena_temporal.Location = new System.Drawing.Point(395, 30);
            this.contrasena_temporal.Margin = new System.Windows.Forms.Padding(2);
            this.contrasena_temporal.Name = "contrasena_temporal";
            this.contrasena_temporal.Size = new System.Drawing.Size(164, 20);
            this.contrasena_temporal.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Contraseña temporal :";
            // 
            // LU_ELIMINAR
            // 
            this.LU_ELIMINAR.Location = new System.Drawing.Point(160, 31);
            this.LU_ELIMINAR.Margin = new System.Windows.Forms.Padding(2);
            this.LU_ELIMINAR.Name = "LU_ELIMINAR";
            this.LU_ELIMINAR.Size = new System.Drawing.Size(66, 19);
            this.LU_ELIMINAR.TabIndex = 3;
            this.LU_ELIMINAR.Text = "Eliminar";
            this.LU_ELIMINAR.UseVisualStyleBackColor = true;
            this.LU_ELIMINAR.Click += new System.EventHandler(this.LU_ELIMINAR_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column5,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView1.Location = new System.Drawing.Point(12, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(945, 437);
            this.dataGridView1.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre(s)";
            this.Column1.Name = "Column1";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Apellido paterno";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Apellido materno";
            this.Column5.Name = "Column5";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Correo electrónico";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "No. de nómina";
            this.Column3.Name = "Column3";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Fecha de nacimiento";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Domicilio";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Telefono de casa";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Celular";
            this.Column9.Name = "Column9";
            // 
            // LISTA_DE_USUARIOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 529);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contrasena_temporal);
            this.Controls.Add(this.LU_HABILITAR);
            this.Controls.Add(this.LU_ELIMINAR);
            this.Controls.Add(this.LU_REGISTRAR);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LISTA_DE_USUARIOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de usuarios";
            this.Load += new System.EventHandler(this.USUARIOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button LU_REGISTRAR;
        private System.Windows.Forms.Button LU_HABILITAR;
        private System.Windows.Forms.TextBox contrasena_temporal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LU_ELIMINAR;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}