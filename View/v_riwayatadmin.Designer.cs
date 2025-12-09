namespace TaniGrow2.View
{
    partial class v_riwayatadmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(v_riwayatadmin));
            btncustomer = new Button();
            btnbarang = new Button();
            dataGridView1 = new DataGridView();
            btnlogout = new Button();
            btnprofiladmin = new Button();
            btnriwayatadmin = new Button();
            btnpesananadmin = new Button();
            btnkatalogadmin = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btncustomer
            // 
            btncustomer.Font = new Font("Segoe UI", 16F);
            btncustomer.Location = new Point(1465, 69);
            btncustomer.Name = "btncustomer";
            btncustomer.Size = new Size(180, 58);
            btncustomer.TabIndex = 27;
            btncustomer.Text = "Customer";
            btncustomer.UseVisualStyleBackColor = true;
            btncustomer.Click += btncustomer_Click;
            // 
            // btnbarang
            // 
            btnbarang.Font = new Font("Segoe UI", 16F);
            btnbarang.Location = new Point(1661, 69);
            btnbarang.Name = "btnbarang";
            btnbarang.Size = new Size(180, 58);
            btnbarang.TabIndex = 28;
            btnbarang.Text = "Barang";
            btnbarang.UseVisualStyleBackColor = true;
            btnbarang.Click += btnbarang_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(537, 243);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1281, 724);
            dataGridView1.TabIndex = 29;
            // 
            // btnlogout
            // 
            btnlogout.Font = new Font("Segoe UI", 16F);
            btnlogout.Location = new Point(86, 910);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(180, 58);
            btnlogout.TabIndex = 37;
            btnlogout.Text = "Log Out";
            btnlogout.UseVisualStyleBackColor = true;
            btnlogout.Click += btnlogout_Click;
            // 
            // btnprofiladmin
            // 
            btnprofiladmin.Font = new Font("Segoe UI", 16F);
            btnprofiladmin.Location = new Point(86, 591);
            btnprofiladmin.Name = "btnprofiladmin";
            btnprofiladmin.Size = new Size(180, 58);
            btnprofiladmin.TabIndex = 36;
            btnprofiladmin.Text = "Profil";
            btnprofiladmin.UseVisualStyleBackColor = true;
            btnprofiladmin.Click += btnprofiladmin_Click;
            // 
            // btnriwayatadmin
            // 
            btnriwayatadmin.Font = new Font("Segoe UI", 16F);
            btnriwayatadmin.Location = new Point(86, 469);
            btnriwayatadmin.Name = "btnriwayatadmin";
            btnriwayatadmin.Size = new Size(180, 58);
            btnriwayatadmin.TabIndex = 35;
            btnriwayatadmin.Text = "Riwayat";
            btnriwayatadmin.UseVisualStyleBackColor = true;
            // 
            // btnpesananadmin
            // 
            btnpesananadmin.Font = new Font("Segoe UI", 16F);
            btnpesananadmin.Location = new Point(86, 352);
            btnpesananadmin.Name = "btnpesananadmin";
            btnpesananadmin.Size = new Size(180, 58);
            btnpesananadmin.TabIndex = 34;
            btnpesananadmin.Text = "Pesanan";
            btnpesananadmin.UseVisualStyleBackColor = true;
            btnpesananadmin.Click += btnpesananadmin_Click;
            // 
            // btnkatalogadmin
            // 
            btnkatalogadmin.Font = new Font("Segoe UI", 16F);
            btnkatalogadmin.Location = new Point(86, 234);
            btnkatalogadmin.Name = "btnkatalogadmin";
            btnkatalogadmin.Size = new Size(180, 58);
            btnkatalogadmin.TabIndex = 33;
            btnkatalogadmin.Text = "Katalog";
            btnkatalogadmin.UseVisualStyleBackColor = true;
            btnkatalogadmin.Click += btnkatalogadmin_Click;
            // 
            // v_riwayatadmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1924, 1055);
            Controls.Add(btnlogout);
            Controls.Add(btnprofiladmin);
            Controls.Add(btnriwayatadmin);
            Controls.Add(btnpesananadmin);
            Controls.Add(btnkatalogadmin);
            Controls.Add(dataGridView1);
            Controls.Add(btnbarang);
            Controls.Add(btncustomer);
            DoubleBuffered = true;
            Name = "v_riwayatadmin";
            Text = "v_riwayatadmin";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btncustomer;
        private Button btnbarang;
        private DataGridView dataGridView1;
        private Button btnlogout;
        private Button btnprofiladmin;
        private Button btnriwayatadmin;
        private Button btnpesananadmin;
        private Button btnkatalogadmin;
    }
}