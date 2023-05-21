namespace Proyecto_de_AADV
{
    partial class CANCELACIONES
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
            this.label1 = new System.Windows.Forms.Label();
            this.cancelar_reservación = new System.Windows.Forms.Button();
            this.codigo = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Hotel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Habitación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo de reservación :";
            // 
            // cancelar_reservación
            // 
            this.cancelar_reservación.Location = new System.Drawing.Point(375, 27);
            this.cancelar_reservación.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelar_reservación.Name = "cancelar_reservación";
            this.cancelar_reservación.Size = new System.Drawing.Size(56, 19);
            this.cancelar_reservación.TabIndex = 3;
            this.cancelar_reservación.Text = "Cancelar";
            this.cancelar_reservación.UseVisualStyleBackColor = true;
            // 
            // codigo
            // 
            this.codigo.Location = new System.Drawing.Point(150, 26);
            this.codigo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(182, 20);
            this.codigo.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hotel,
            this.Ciudad,
            this.Habitación,
            this.CheckIn,
            this.CheckOut});
            this.dataGridView1.Location = new System.Drawing.Point(10, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 505);
            this.dataGridView1.TabIndex = 21;
            // 
            // Hotel
            // 
            this.Hotel.HeaderText = "Hotel";
            this.Hotel.Name = "Hotel";
            // 
            // Ciudad
            // 
            this.Ciudad.HeaderText = "Ciudad";
            this.Ciudad.Name = "Ciudad";
            // 
            // Habitación
            // 
            this.Habitación.HeaderText = "Habitación";
            this.Habitación.Name = "Habitación";
            // 
            // CheckIn
            // 
            this.CheckIn.HeaderText = "Check In";
            this.CheckIn.Name = "CheckIn";
            // 
            // CheckOut
            // 
            this.CheckOut.HeaderText = "Check Out";
            this.CheckOut.Name = "CheckOut";
            // 
            // CANCELACIONES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 589);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.cancelar_reservación);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CANCELACIONES";
            this.Text = "Cancelar reservación";
            this.Load += new System.EventHandler(this.CANCELACIONES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelar_reservación;
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hotel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Habitación;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckOut;
    }
}