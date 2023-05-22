namespace Proyecto_de_AADV
{
    partial class LISTA_RESERVACIONES
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
            this.codigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LR_CHECKIN = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MLR_CREAR = new System.Windows.Forms.ToolStripMenuItem();
            this.MLR_CHECKOUT = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Hotel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Habitación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // codigo
            // 
            this.codigo.Location = new System.Drawing.Point(151, 47);
            this.codigo.Margin = new System.Windows.Forms.Padding(2);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(183, 20);
            this.codigo.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Cóodigo de reservación :";
            // 
            // LR_CHECKIN
            // 
            this.LR_CHECKIN.Location = new System.Drawing.Point(380, 47);
            this.LR_CHECKIN.Margin = new System.Windows.Forms.Padding(2);
            this.LR_CHECKIN.Name = "LR_CHECKIN";
            this.LR_CHECKIN.Size = new System.Drawing.Size(64, 20);
            this.LR_CHECKIN.TabIndex = 16;
            this.LR_CHECKIN.Text = "Check In";
            this.LR_CHECKIN.UseVisualStyleBackColor = true;
            this.LR_CHECKIN.Click += new System.EventHandler(this.LR_CHECKIN_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MLR_CREAR,
            this.MLR_CHECKOUT});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(569, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MLR_CREAR
            // 
            this.MLR_CREAR.Name = "MLR_CREAR";
            this.MLR_CREAR.Size = new System.Drawing.Size(133, 20);
            this.MLR_CREAR.Text = "Crear una reservación";
            this.MLR_CREAR.Click += new System.EventHandler(this.MLR_CREAR_Click);
            // 
            // MLR_CHECKOUT
            // 
            this.MLR_CHECKOUT.Name = "MLR_CHECKOUT";
            this.MLR_CHECKOUT.Size = new System.Drawing.Size(75, 20);
            this.MLR_CHECKOUT.Text = "Check Out";
            this.MLR_CHECKOUT.Click += new System.EventHandler(this.MLR_CHECKOUT_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 485);
            this.dataGridView1.TabIndex = 20;
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
            // LISTA_RESERVACIONES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 587);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LR_CHECKIN);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LISTA_RESERVACIONES";
            this.Text = "LISTA_RESERVACIONES";
            this.Load += new System.EventHandler(this.LISTA_RESERVACIONES_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button LR_CHECKIN;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MLR_CREAR;
        private System.Windows.Forms.ToolStripMenuItem MLR_CHECKOUT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hotel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Habitación;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckOut;
    }
}