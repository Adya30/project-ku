namespace TaniGrow2.View
{
    partial class v_riwayatcustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(v_riwayatcustomer));
            dataGridView1 = new DataGridView();
            btnlogout = new Button();
            btnprofilcustomer = new Button();
            btnriwayatcustomer = new Button();
            btnpesanancustomer = new Button();
            btnkatalogcustomer = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(532, 242);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1286, 722);
            dataGridView1.TabIndex = 24;
            // 
            // btnlogout
            // 
            btnlogout.Font = new Font("Segoe UI", 16F);
            btnlogout.Location = new Point(84, 898);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(180, 58);
            btnlogout.TabIndex = 29;
            btnlogout.Text = "Log Out";
            btnlogout.UseVisualStyleBackColor = true;
            btnlogout.Click += btnlogout_Click;
            // 
            // btnprofilcustomer
            // 
            btnprofilcustomer.Font = new Font("Segoe UI", 16F);
            btnprofilcustomer.Location = new Point(84, 579);
            btnprofilcustomer.Name = "btnprofilcustomer";
            btnprofilcustomer.Size = new Size(180, 58);
            btnprofilcustomer.TabIndex = 28;
            btnprofilcustomer.Text = "Profil";
            btnprofilcustomer.UseVisualStyleBackColor = true;
            btnprofilcustomer.Click += btnprofilcustomer_Click;
            // 
            // btnriwayatcustomer
            // 
            btnriwayatcustomer.Font = new Font("Segoe UI", 16F);
            btnriwayatcustomer.Location = new Point(84, 457);
            btnriwayatcustomer.Name = "btnriwayatcustomer";
            btnriwayatcustomer.Size = new Size(180, 58);
            btnriwayatcustomer.TabIndex = 27;
            btnriwayatcustomer.Text = "Riwayat";
            btnriwayatcustomer.UseVisualStyleBackColor = true;
            btnriwayatcustomer.Click += btnriwayatcustomer_Click;
            // 
            // btnpesanancustomer
            // 
            btnpesanancustomer.Font = new Font("Segoe UI", 16F);
            btnpesanancustomer.Location = new Point(84, 340);
            btnpesanancustomer.Name = "btnpesanancustomer";
            btnpesanancustomer.Size = new Size(180, 58);
            btnpesanancustomer.TabIndex = 26;
            btnpesanancustomer.Text = "Pesanan";
            btnpesanancustomer.UseVisualStyleBackColor = true;
            btnpesanancustomer.Click += btnpesanancustomer_Click;
            // 
            // btnkatalogcustomer
            // 
            btnkatalogcustomer.Font = new Font("Segoe UI", 16F);
            btnkatalogcustomer.Location = new Point(84, 222);
            btnkatalogcustomer.Name = "btnkatalogcustomer";
            btnkatalogcustomer.Size = new Size(180, 58);
            btnkatalogcustomer.TabIndex = 25;
            btnkatalogcustomer.Text = "Katalog";
            btnkatalogcustomer.UseVisualStyleBackColor = true;
            btnkatalogcustomer.Click += btnkatalogcustomer_Click;
            // 
            // v_riwayatcustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1924, 1055);
            Controls.Add(btnlogout);
            Controls.Add(btnprofilcustomer);
            Controls.Add(btnriwayatcustomer);
            Controls.Add(btnpesanancustomer);
            Controls.Add(btnkatalogcustomer);
            Controls.Add(dataGridView1);
            DoubleBuffered = true;
            Name = "v_riwayatcustomer";
            Text = "v_riwayatcustomer";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnlogout;
        private Button btnprofilcustomer;
        private Button btnriwayatcustomer;
        private Button btnpesanancustomer;
        private Button btnkatalogcustomer;
    }
}