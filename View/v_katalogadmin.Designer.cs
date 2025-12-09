namespace TaniGrow2.View
{
    partial class v_katalogadmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(v_katalogadmin));
            flowpanel = new FlowLayoutPanel();
            btntambahkatalog = new Button();
            btnstok = new Button();
            btnlogout = new Button();
            btnprofiladmin = new Button();
            btnriwayatadmin = new Button();
            btnpesananadmin = new Button();
            btnkatalogadmin = new Button();
            SuspendLayout();
            // 
            // flowpanel
            // 
            flowpanel.BackColor = Color.Transparent;
            flowpanel.Location = new Point(511, 261);
            flowpanel.Name = "flowpanel";
            flowpanel.Size = new Size(1386, 782);
            flowpanel.TabIndex = 0;
            // 
            // btntambahkatalog
            // 
            btntambahkatalog.Font = new Font("Segoe UI", 16F);
            btntambahkatalog.Location = new Point(511, 185);
            btntambahkatalog.Name = "btntambahkatalog";
            btntambahkatalog.Size = new Size(180, 58);
            btntambahkatalog.TabIndex = 6;
            btntambahkatalog.Text = "Tambah Katalog";
            btntambahkatalog.UseVisualStyleBackColor = true;
            btntambahkatalog.Click += btntambahkatalog_Click;
            // 
            // btnstok
            // 
            btnstok.Font = new Font("Segoe UI", 16F);
            btnstok.Location = new Point(726, 185);
            btnstok.Name = "btnstok";
            btnstok.Size = new Size(180, 58);
            btnstok.TabIndex = 7;
            btnstok.Text = "Stok";
            btnstok.UseVisualStyleBackColor = true;
            btnstok.Click += btnstok_Click;
            // 
            // btnlogout
            // 
            btnlogout.Font = new Font("Segoe UI", 16F);
            btnlogout.Location = new Point(86, 906);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(180, 58);
            btnlogout.TabIndex = 32;
            btnlogout.Text = "Log Out";
            btnlogout.UseVisualStyleBackColor = true;
            btnlogout.Click += btnlogout_Click;
            // 
            // btnprofiladmin
            // 
            btnprofiladmin.Font = new Font("Segoe UI", 16F);
            btnprofiladmin.Location = new Point(86, 587);
            btnprofiladmin.Name = "btnprofiladmin";
            btnprofiladmin.Size = new Size(180, 58);
            btnprofiladmin.TabIndex = 31;
            btnprofiladmin.Text = "Profil";
            btnprofiladmin.UseVisualStyleBackColor = true;
            btnprofiladmin.Click += btnprofiladmin_Click;
            // 
            // btnriwayatadmin
            // 
            btnriwayatadmin.Font = new Font("Segoe UI", 16F);
            btnriwayatadmin.Location = new Point(86, 465);
            btnriwayatadmin.Name = "btnriwayatadmin";
            btnriwayatadmin.Size = new Size(180, 58);
            btnriwayatadmin.TabIndex = 30;
            btnriwayatadmin.Text = "Riwayat";
            btnriwayatadmin.UseVisualStyleBackColor = true;
            btnriwayatadmin.Click += btnriwayatadmin_Click;
            // 
            // btnpesananadmin
            // 
            btnpesananadmin.Font = new Font("Segoe UI", 16F);
            btnpesananadmin.Location = new Point(86, 348);
            btnpesananadmin.Name = "btnpesananadmin";
            btnpesananadmin.Size = new Size(180, 58);
            btnpesananadmin.TabIndex = 29;
            btnpesananadmin.Text = "Pesanan";
            btnpesananadmin.UseVisualStyleBackColor = true;
            btnpesananadmin.Click += btnpesananadmin_Click;
            // 
            // btnkatalogadmin
            // 
            btnkatalogadmin.Font = new Font("Segoe UI", 16F);
            btnkatalogadmin.Location = new Point(86, 230);
            btnkatalogadmin.Name = "btnkatalogadmin";
            btnkatalogadmin.Size = new Size(180, 58);
            btnkatalogadmin.TabIndex = 28;
            btnkatalogadmin.Text = "Katalog";
            btnkatalogadmin.UseVisualStyleBackColor = true;
            btnkatalogadmin.Click += btnkatalogadmin_Click;
            // 
            // v_katalogadmin
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
            Controls.Add(btnstok);
            Controls.Add(btntambahkatalog);
            Controls.Add(flowpanel);
            Name = "v_katalogadmin";
            Text = "v_katalogadmin";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowpanel;
        private Button btntambahkatalog;
        private Button btnstok;
        private Button btnlogout;
        private Button btnprofiladmin;
        private Button btnriwayatadmin;
        private Button btnpesananadmin;
        private Button btnkatalogadmin;
    }
}