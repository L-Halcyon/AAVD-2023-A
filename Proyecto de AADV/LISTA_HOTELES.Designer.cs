namespace Proyecto_de_AADV
{
    partial class LISTA_HOTELES
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
            this.LH_REGISTRAR_HOTEL = new System.Windows.Forms.Button();
            this.LH_REGISTRAR_HABITACION = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LH_REGISTRAR_HOTEL
            // 
            this.LH_REGISTRAR_HOTEL.Location = new System.Drawing.Point(33, 26);
            this.LH_REGISTRAR_HOTEL.Margin = new System.Windows.Forms.Padding(2);
            this.LH_REGISTRAR_HOTEL.Name = "LH_REGISTRAR_HOTEL";
            this.LH_REGISTRAR_HOTEL.Size = new System.Drawing.Size(134, 19);
            this.LH_REGISTRAR_HOTEL.TabIndex = 9;
            this.LH_REGISTRAR_HOTEL.Text = "Registrar hotel";
            this.LH_REGISTRAR_HOTEL.UseVisualStyleBackColor = true;
            this.LH_REGISTRAR_HOTEL.Click += new System.EventHandler(this.LH_REGISTRAR_HOTEL_Click);
            // 
            // LH_REGISTRAR_HABITACION
            // 
            this.LH_REGISTRAR_HABITACION.Enabled = false;
            this.LH_REGISTRAR_HABITACION.Location = new System.Drawing.Point(228, 26);
            this.LH_REGISTRAR_HABITACION.Margin = new System.Windows.Forms.Padding(2);
            this.LH_REGISTRAR_HABITACION.Name = "LH_REGISTRAR_HABITACION";
            this.LH_REGISTRAR_HABITACION.Size = new System.Drawing.Size(134, 19);
            this.LH_REGISTRAR_HABITACION.TabIndex = 10;
            this.LH_REGISTRAR_HABITACION.Text = "Registrar habitación";
            this.LH_REGISTRAR_HABITACION.UseVisualStyleBackColor = true;
            this.LH_REGISTRAR_HABITACION.Click += new System.EventHandler(this.LH_REGISTRAR_HABITACION_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dataGridView1.Location = new System.Drawing.Point(12, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1043, 449);
            this.dataGridView1.TabIndex = 11;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ciudad";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Estado";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "País";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Domicilio";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "No. de pisos";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "No. de habotaciones";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Zona turística";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Servicios adicionales";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Características";
            this.Column10.Name = "Column10";
            // 
            // LISTA_HOTELES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 543);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LH_REGISTRAR_HABITACION);
            this.Controls.Add(this.LH_REGISTRAR_HOTEL);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LISTA_HOTELES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de hoteles";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LH_REGISTRAR_HOTEL;
        private System.Windows.Forms.Button LH_REGISTRAR_HABITACION;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}