namespace Proyecto_de_AADV
{
    partial class LISTA_CLIENTES
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
            this.registrarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscar_cliente_apellido = new System.Windows.Forms.Button();
            this.buscar__cliente_rfc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buscar_cliente_correo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buscar_rfc = new System.Windows.Forms.TextBox();
            this.buscar_apellido = new System.Windows.Forms.TextBox();
            this.buscar_correo = new System.Windows.Forms.TextBox();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarClienteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1082, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrarClienteToolStripMenuItem
            // 
            this.registrarClienteToolStripMenuItem.Name = "registrarClienteToolStripMenuItem";
            this.registrarClienteToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.registrarClienteToolStripMenuItem.Text = "Registrar cliente";
            // 
            // buscar_cliente_apellido
            // 
            this.buscar_cliente_apellido.Location = new System.Drawing.Point(364, 34);
            this.buscar_cliente_apellido.Margin = new System.Windows.Forms.Padding(2);
            this.buscar_cliente_apellido.Name = "buscar_cliente_apellido";
            this.buscar_cliente_apellido.Size = new System.Drawing.Size(56, 19);
            this.buscar_cliente_apellido.TabIndex = 4;
            this.buscar_cliente_apellido.Text = "Buscar";
            this.buscar_cliente_apellido.UseVisualStyleBackColor = true;
            // 
            // buscar__cliente_rfc
            // 
            this.buscar__cliente_rfc.Location = new System.Drawing.Point(364, 77);
            this.buscar__cliente_rfc.Margin = new System.Windows.Forms.Padding(2);
            this.buscar__cliente_rfc.Name = "buscar__cliente_rfc";
            this.buscar__cliente_rfc.Size = new System.Drawing.Size(56, 19);
            this.buscar__cliente_rfc.TabIndex = 5;
            this.buscar__cliente_rfc.Text = "Buscar";
            this.buscar__cliente_rfc.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Buscar por apellido :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Buscar por RFC :";
            // 
            // buscar_cliente_correo
            // 
            this.buscar_cliente_correo.Location = new System.Drawing.Point(364, 120);
            this.buscar_cliente_correo.Margin = new System.Windows.Forms.Padding(2);
            this.buscar_cliente_correo.Name = "buscar_cliente_correo";
            this.buscar_cliente_correo.Size = new System.Drawing.Size(56, 19);
            this.buscar_cliente_correo.TabIndex = 8;
            this.buscar_cliente_correo.Text = "Buscar";
            this.buscar_cliente_correo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Buscar por correo electrónico :";
            // 
            // buscar_rfc
            // 
            this.buscar_rfc.Location = new System.Drawing.Point(173, 76);
            this.buscar_rfc.Margin = new System.Windows.Forms.Padding(2);
            this.buscar_rfc.Name = "buscar_rfc";
            this.buscar_rfc.Size = new System.Drawing.Size(170, 20);
            this.buscar_rfc.TabIndex = 10;
            // 
            // buscar_apellido
            // 
            this.buscar_apellido.Location = new System.Drawing.Point(173, 33);
            this.buscar_apellido.Margin = new System.Windows.Forms.Padding(2);
            this.buscar_apellido.Name = "buscar_apellido";
            this.buscar_apellido.Size = new System.Drawing.Size(170, 20);
            this.buscar_apellido.TabIndex = 11;
            // 
            // buscar_correo
            // 
            this.buscar_correo.Location = new System.Drawing.Point(173, 117);
            this.buscar_correo.Margin = new System.Windows.Forms.Padding(2);
            this.buscar_correo.Name = "buscar_correo";
            this.buscar_correo.Size = new System.Drawing.Size(170, 20);
            this.buscar_correo.TabIndex = 12;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column10,
            this.Column11,
            this.Column4,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView1.Location = new System.Drawing.Point(17, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1047, 495);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre(s)";
            this.Column1.Name = "Column1";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Apellido paterno";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Apellido materno";
            this.Column11.Name = "Column11";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "RFC";
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Correo electrónico";
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Teléfono de casa";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Celular";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Referencia";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Fecha de nacimiento";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Estado civil";
            this.Column9.Name = "Column9";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(948, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 39);
            this.button1.TabIndex = 14;
            this.button1.Text = "Ver Hisorial";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // LISTA_CLIENTES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 666);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buscar_correo);
            this.Controls.Add(this.buscar_apellido);
            this.Controls.Add(this.buscar_rfc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buscar_cliente_correo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buscar__cliente_rfc);
            this.Controls.Add(this.buscar_cliente_apellido);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LISTA_CLIENTES";
            this.Text = "Lista de Clientes";
            this.Load += new System.EventHandler(this.LISTA_CLIENTES_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button buscar_cliente_apellido;
        private System.Windows.Forms.Button buscar__cliente_rfc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buscar_cliente_correo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox buscar_rfc;
        private System.Windows.Forms.TextBox buscar_apellido;
        private System.Windows.Forms.TextBox buscar_correo;
        private System.Windows.Forms.ToolStripMenuItem registrarClienteToolStripMenuItem;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Button button1;
    }
}