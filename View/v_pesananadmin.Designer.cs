namespace TaniGrow2.View
{
    partial class v_pesananadmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(v_pesananadmin));
            dataGridView1 = new DataGridView();
            btnlogout = new Button();
            btnprofiladmin = new Button();
            btnriwayatadmin = new Button();
            btnpesananadmin = new Button();
            btnkatalogadmin = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(537, 248);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1285, 721);
            dataGridView1.TabIndex = 34;
            // 
            // btnlogout
            // 
            btnlogout.Font = new Font("Segoe UI", 16F);
            btnlogout.Location = new Point(88, 911);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(180, 58);
            btnlogout.TabIndex = 39;
            btnlogout.Text = "Log Out";
            btnlogout.UseVisualStyleBackColor = true;
            btnlogout.Click += btnlogout_Click;
            // 
            // btnprofiladmin
            // 
            btnprofiladmin.Font = new Font("Segoe UI", 16F);
            btnprofiladmin.Location = new Point(88, 592);
            btnprofiladmin.Name = "btnprofiladmin";
            btnprofiladmin.Size = new Size(180, 58);
            btnprofiladmin.TabIndex = 38;
            btnprofiladmin.Text = "Profil";
            btnprofiladmin.UseVisualStyleBackColor = true;
            btnprofiladmin.Click += btnprofiladmin_Click;
            // 
            // btnriwayatadmin
            // 
            btnriwayatadmin.Font = new Font("Segoe UI", 16F);
            btnriwayatadmin.Location = new Point(88, 470);
            btnriwayatadmin.Name = "btnriwayatadmin";
            btnriwayatadmin.Size = new Size(180, 58);
            btnriwayatadmin.TabIndex = 37;
            btnriwayatadmin.Text = "Riwayat";
            btnriwayatadmin.UseVisualStyleBackColor = true;
            btnriwayatadmin.Click += btnriwayatadmin_Click;
            // 
            // btnpesananadmin
            // 
            btnpesananadmin.Font = new Font("Segoe UI", 16F);
            btnpesananadmin.Location = new Point(88, 353);
            btnpesananadmin.Name = "btnpesananadmin";
            btnpesananadmin.Size = new Size(180, 58);
            btnpesananadmin.TabIndex = 36;
            btnpesananadmin.Text = "Pesanan";
            btnpesananadmin.UseVisualStyleBackColor = true;
            // 
            // btnkatalogadmin
            // 
            btnkatalogadmin.Font = new Font("Segoe UI", 16F);
            btnkatalogadmin.Location = new Point(88, 235);
            btnkatalogadmin.Name = "btnkatalogadmin";
            btnkatalogadmin.Size = new Size(180, 58);
            btnkatalogadmin.TabIndex = 35;
            btnkatalogadmin.Text = "Katalog";
            btnkatalogadmin.UseVisualStyleBackColor = true;
            btnkatalogadmin.Click += btnkatalaogadmin_Click;
            // 
            // v_pesananadmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1924, 1055);
            Controls.Add(btnlogout);
            Controls.Add(btnprofiladmin);
            Controls.Add(btnriwayatadmin);
            Controls.Add(btnpesananadmin);
            Controls.Add(btnkatalogadmin);
            Controls.Add(dataGridView1);
            Name = "v_pesananadmin";
            Text = "v_pesananadmin";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnlogout;
        private Button btnprofiladmin;
        private Button btnriwayatadmin;
        private Button btnpesananadmin;
        private Button btnkatalogadmin;
    }
}