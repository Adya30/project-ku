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
            btnlogout = new Button();
            btnprofiladmin = new Button();
            btnriwayatadmin = new Button();
            btnpesananadmin = new Button();
            btnkatalogadminn = new Button();
            btnbatal = new Button();
            tbpassword = new TextBox();
            tbusername = new TextBox();
            btnsimpan = new Button();
            btnedit = new Button();
            SuspendLayout();
            // 
            // btnlogout
            // 
            btnlogout.Location = new Point(19, 385);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(94, 29);
            btnlogout.TabIndex = 12;
            btnlogout.Text = "Log Out";
            btnlogout.UseVisualStyleBackColor = true;
            btnlogout.Click += btnlogout_Click;
            // 
            // btnprofiladmin
            // 
            btnprofiladmin.Location = new Point(19, 244);
            btnprofiladmin.Name = "btnprofiladmin";
            btnprofiladmin.Size = new Size(94, 29);
            btnprofiladmin.TabIndex = 11;
            btnprofiladmin.Text = "Profil";
            btnprofiladmin.UseVisualStyleBackColor = true;
            btnprofiladmin.Click += btnprofiladmin_Click;
            // 
            // btnriwayatadmin
            // 
            btnriwayatadmin.Location = new Point(19, 190);
            btnriwayatadmin.Name = "btnriwayatadmin";
            btnriwayatadmin.Size = new Size(94, 29);
            btnriwayatadmin.TabIndex = 10;
            btnriwayatadmin.Text = "Riwayat";
            btnriwayatadmin.UseVisualStyleBackColor = true;
            btnriwayatadmin.Click += btnriwayatadmin_Click;
            // 
            // btnpesananadmin
            // 
            btnpesananadmin.Location = new Point(19, 129);
            btnpesananadmin.Name = "btnpesananadmin";
            btnpesananadmin.Size = new Size(94, 29);
            btnpesananadmin.TabIndex = 9;
            btnpesananadmin.Text = "Pesanan";
            btnpesananadmin.UseVisualStyleBackColor = true;
            btnpesananadmin.Click += btnpesananadmin_Click;
            // 
            // btnkatalogadminn
            // 
            btnkatalogadminn.Location = new Point(19, 73);
            btnkatalogadminn.Name = "btnkatalogadminn";
            btnkatalogadminn.Size = new Size(94, 29);
            btnkatalogadminn.TabIndex = 8;
            btnkatalogadminn.Text = "Katalog";
            btnkatalogadminn.UseVisualStyleBackColor = true;
            btnkatalogadminn.Click += btnkatalogadmin_Click;
            // 
            // btnbatal
            // 
            btnbatal.Location = new Point(454, 326);
            btnbatal.Name = "btnbatal";
            btnbatal.Size = new Size(103, 29);
            btnbatal.TabIndex = 13;
            btnbatal.Text = "Batal";
            btnbatal.UseVisualStyleBackColor = true;
            btnbatal.Click += btnbatal_Click;
            // 
            // tbpassword
            // 
            tbpassword.Location = new Point(377, 228);
            tbpassword.Name = "tbpassword";
            tbpassword.Size = new Size(125, 27);
            tbpassword.TabIndex = 15;
            // 
            // tbusername
            // 
            tbusername.Location = new Point(377, 160);
            tbusername.Name = "tbusername";
            tbusername.Size = new Size(125, 27);
            tbusername.TabIndex = 14;
            // 
            // btnsimpan
            // 
            btnsimpan.Location = new Point(329, 326);
            btnsimpan.Name = "btnsimpan";
            btnsimpan.Size = new Size(103, 29);
            btnsimpan.TabIndex = 16;
            btnsimpan.Text = "Simpan";
            btnsimpan.UseVisualStyleBackColor = true;
            btnsimpan.Click += btnsimpan_Click;
            // 
            // btnedit
            // 
            btnedit.Location = new Point(647, 39);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(103, 29);
            btnedit.TabIndex = 17;
            btnedit.Text = "Edit";
            btnedit.UseVisualStyleBackColor = true;
            btnedit.Click += btnedit_Click;
            // 
            // v_profiladmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnedit);
            Controls.Add(btnsimpan);
            Controls.Add(tbpassword);
            Controls.Add(tbusername);
            Controls.Add(btnbatal);
            Controls.Add(btnlogout);
            Controls.Add(btnprofiladmin);
            Controls.Add(btnriwayatadmin);
            Controls.Add(btnpesananadmin);
            Controls.Add(btnkatalogadminn);
            Name = "v_profiladmin";
            Text = "v_profiladmin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnlogout;
        private Button btnprofiladmin;
        private Button btnriwayatadmin;
        private Button btnpesananadmin;
        private Button btnkatalogadminn;
        private Button btnbatal;
        private TextBox tbpassword;
        private TextBox tbusername;
        private Button btnsimpan;
        private Button btnedit;
    }
}