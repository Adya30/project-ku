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
            btnprofiladmin = new Button();
            btnpesananadmin = new Button();
            btnriwayatadmin = new Button();
            btnkatalogadmin = new Button();
            btnlogout = new Button();
            btncustomer = new Button();
            btnbarang = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnprofiladmin
            // 
            btnprofiladmin.Location = new Point(46, 243);
            btnprofiladmin.Name = "btnprofiladmin";
            btnprofiladmin.Size = new Size(94, 29);
            btnprofiladmin.TabIndex = 25;
            btnprofiladmin.Text = "Profil";
            btnprofiladmin.UseVisualStyleBackColor = true;
            btnprofiladmin.Click += btnprofiladmin_Click;
            // 
            // btnpesananadmin
            // 
            btnpesananadmin.Location = new Point(46, 129);
            btnpesananadmin.Name = "btnpesananadmin";
            btnpesananadmin.Size = new Size(94, 29);
            btnpesananadmin.TabIndex = 24;
            btnpesananadmin.Text = "Pesanan";
            btnpesananadmin.UseVisualStyleBackColor = true;
            btnpesananadmin.Click += btnpesananadmin_Click;
            // 
            // btnriwayatadmin
            // 
            btnriwayatadmin.Location = new Point(46, 190);
            btnriwayatadmin.Name = "btnriwayatadmin";
            btnriwayatadmin.Size = new Size(94, 29);
            btnriwayatadmin.TabIndex = 23;
            btnriwayatadmin.Text = "Riwayat";
            btnriwayatadmin.UseVisualStyleBackColor = true;
            btnriwayatadmin.Click += btnriwayatadmin_Click;
            // 
            // btnkatalogadmin
            // 
            btnkatalogadmin.Location = new Point(46, 73);
            btnkatalogadmin.Name = "btnkatalogadmin";
            btnkatalogadmin.Size = new Size(94, 29);
            btnkatalogadmin.TabIndex = 22;
            btnkatalogadmin.Text = "Katalog";
            btnkatalogadmin.UseVisualStyleBackColor = true;
            btnkatalogadmin.Click += btnkatalogadmin_Click;
            // 
            // btnlogout
            // 
            btnlogout.Location = new Point(55, 398);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(94, 29);
            btnlogout.TabIndex = 21;
            btnlogout.Text = "Log out";
            btnlogout.UseVisualStyleBackColor = true;
            btnlogout.Click += btnlogout_Click;
            // 
            // btncustomer
            // 
            btncustomer.Location = new Point(641, 25);
            btncustomer.Name = "btncustomer";
            btncustomer.Size = new Size(94, 29);
            btncustomer.TabIndex = 27;
            btncustomer.Text = "Customer";
            btncustomer.UseVisualStyleBackColor = true;
            btncustomer.Click += btncustomer_Click;
            // 
            // btnbarang
            // 
            btnbarang.Location = new Point(774, 25);
            btnbarang.Name = "btnbarang";
            btnbarang.Size = new Size(94, 29);
            btnbarang.TabIndex = 28;
            btnbarang.Text = "Barang";
            btnbarang.UseVisualStyleBackColor = true;
            btnbarang.Click += btnbarang_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(271, 73);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(945, 553);
            dataGridView1.TabIndex = 29;
            // 
            // v_riwayatadmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(dataGridView1);
            Controls.Add(btnbarang);
            Controls.Add(btncustomer);
            Controls.Add(btnprofiladmin);
            Controls.Add(btnpesananadmin);
            Controls.Add(btnriwayatadmin);
            Controls.Add(btnkatalogadmin);
            Controls.Add(btnlogout);
            Name = "v_riwayatadmin";
            Text = "v_riwayatadmin";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnprofiladmin;
        private Button btnpesananadmin;
        private Button btnriwayatadmin;
        private Button btnkatalogadmin;
        private Button btnlogout;
        private Button btncustomer;
        private Button btnbarang;
        private DataGridView dataGridView1;
    }
}