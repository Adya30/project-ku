namespace TaniGrow2.View
{
    partial class v_profiladmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(v_profiladmin));
            tbpassword = new TextBox();
            tbusername = new TextBox();
            btnedit = new Button();
            btnsimpan = new Button();
            btnbatal = new Button();
            btnlogout = new Button();
            btnprofiladmin = new Button();
            btnriwayatadmin = new Button();
            btnpesananadmin = new Button();
            btnkatalogadmin = new Button();
            SuspendLayout();
            // 
            // tbpassword
            // 
            tbpassword.BorderStyle = BorderStyle.None;
            tbpassword.Font = new Font("Segoe UI", 16F);
            tbpassword.Location = new Point(601, 462);
            tbpassword.Name = "tbpassword";
            tbpassword.Size = new Size(319, 36);
            tbpassword.TabIndex = 26;
            // 
            // tbusername
            // 
            tbusername.BorderStyle = BorderStyle.None;
            tbusername.Font = new Font("Segoe UI", 16F);
            tbusername.Location = new Point(601, 344);
            tbusername.Name = "tbusername";
            tbusername.Size = new Size(319, 36);
            tbusername.TabIndex = 27;
            // 
            // btnedit
            // 
            btnedit.Font = new Font("Segoe UI", 16F);
            btnedit.Location = new Point(878, 862);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(148, 58);
            btnedit.TabIndex = 30;
            btnedit.Text = "Edit";
            btnedit.UseVisualStyleBackColor = true;
            btnedit.Click += btnedit_Click;
            // 
            // btnsimpan
            // 
            btnsimpan.Font = new Font("Segoe UI", 16F);
            btnsimpan.Location = new Point(1075, 862);
            btnsimpan.Name = "btnsimpan";
            btnsimpan.Size = new Size(180, 58);
            btnsimpan.TabIndex = 29;
            btnsimpan.Text = "Simpan";
            btnsimpan.UseVisualStyleBackColor = true;
            btnsimpan.Click += btnsimpan_Click;
            // 
            // btnbatal
            // 
            btnbatal.Font = new Font("Segoe UI", 16F);
            btnbatal.Location = new Point(1300, 862);
            btnbatal.Name = "btnbatal";
            btnbatal.Size = new Size(180, 58);
            btnbatal.TabIndex = 28;
            btnbatal.Text = "Batal";
            btnbatal.UseVisualStyleBackColor = true;
            btnbatal.Click += btnbatal_Click;
            // 
            // btnlogout
            // 
            btnlogout.Font = new Font("Segoe UI", 16F);
            btnlogout.Location = new Point(86, 916);
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
            btnprofiladmin.Location = new Point(86, 597);
            btnprofiladmin.Name = "btnprofiladmin";
            btnprofiladmin.Size = new Size(180, 58);
            btnprofiladmin.TabIndex = 36;
            btnprofiladmin.Text = "Profil";
            btnprofiladmin.UseVisualStyleBackColor = true;
            // 
            // btnriwayatadmin
            // 
            btnriwayatadmin.Font = new Font("Segoe UI", 16F);
            btnriwayatadmin.Location = new Point(86, 475);
            btnriwayatadmin.Name = "btnriwayatadmin";
            btnriwayatadmin.Size = new Size(180, 58);
            btnriwayatadmin.TabIndex = 35;
            btnriwayatadmin.Text = "Riwayat";
            btnriwayatadmin.UseVisualStyleBackColor = true;
            btnriwayatadmin.Click += btnriwayatadmin_Click;
            // 
            // btnpesananadmin
            // 
            btnpesananadmin.Font = new Font("Segoe UI", 16F);
            btnpesananadmin.Location = new Point(86, 358);
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
            btnkatalogadmin.Location = new Point(86, 240);
            btnkatalogadmin.Name = "btnkatalogadmin";
            btnkatalogadmin.Size = new Size(180, 58);
            btnkatalogadmin.TabIndex = 33;
            btnkatalogadmin.Text = "Katalog";
            btnkatalogadmin.UseVisualStyleBackColor = true;
            btnkatalogadmin.Click += btnkatalogadmin_Click;
            // 
            // v_profiladmin
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
            Controls.Add(btnedit);
            Controls.Add(btnsimpan);
            Controls.Add(btnbatal);
            Controls.Add(tbusername);
            Controls.Add(tbpassword);
            DoubleBuffered = true;
            Name = "v_profiladmin";
            Text = "v_profiladmin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbpassword;
        private TextBox tbusername;
        private Button btnedit;
        private Button btnsimpan;
        private Button btnbatal;
        private Button btnlogout;
        private Button btnprofiladmin;
        private Button btnriwayatadmin;
        private Button btnpesananadmin;
        private Button btnkatalogadmin;
    }
}