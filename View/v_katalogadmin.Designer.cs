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
            flowpanel = new FlowLayoutPanel();
            btnkatalogadmin = new Button();
            btnpesananadmin = new Button();
            btnriwayatadmin = new Button();
            btnprofiladmin = new Button();
            btnlogout = new Button();
            btntambahkatalog = new Button();
            btnstok = new Button();
            SuspendLayout();
            // 
            // flowpanel
            // 
            flowpanel.Location = new Point(152, 73);
            flowpanel.Name = "flowpanel";
            flowpanel.Size = new Size(636, 365);
            flowpanel.TabIndex = 0;
            // 
            // btnkatalogadmin
            // 
            btnkatalogadmin.Location = new Point(25, 73);
            btnkatalogadmin.Name = "btnkatalogadmin";
            btnkatalogadmin.Size = new Size(94, 29);
            btnkatalogadmin.TabIndex = 1;
            btnkatalogadmin.Text = "Katalog";
            btnkatalogadmin.UseVisualStyleBackColor = true;
            btnkatalogadmin.Click += btnkatalogadmin_Click;
            // 
            // btnpesananadmin
            // 
            btnpesananadmin.Location = new Point(25, 135);
            btnpesananadmin.Name = "btnpesananadmin";
            btnpesananadmin.Size = new Size(94, 29);
            btnpesananadmin.TabIndex = 2;
            btnpesananadmin.Text = "Pesanan";
            btnpesananadmin.UseVisualStyleBackColor = true;
            btnpesananadmin.Click += btnpesananadmin_Click;
            // 
            // btnriwayatadmin
            // 
            btnriwayatadmin.Location = new Point(25, 196);
            btnriwayatadmin.Name = "btnriwayatadmin";
            btnriwayatadmin.Size = new Size(94, 29);
            btnriwayatadmin.TabIndex = 3;
            btnriwayatadmin.Text = "Riwayat";
            btnriwayatadmin.UseVisualStyleBackColor = true;
            btnriwayatadmin.Click += btnriwayatadmin_Click;
            // 
            // btnprofiladmin
            // 
            btnprofiladmin.Location = new Point(25, 250);
            btnprofiladmin.Name = "btnprofiladmin";
            btnprofiladmin.Size = new Size(94, 29);
            btnprofiladmin.TabIndex = 4;
            btnprofiladmin.Text = "Profil";
            btnprofiladmin.UseVisualStyleBackColor = true;
            btnprofiladmin.Click += btnprofiladmin_Click;
            // 
            // btnlogout
            // 
            btnlogout.Location = new Point(25, 391);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(94, 29);
            btnlogout.TabIndex = 5;
            btnlogout.Text = "Log Out";
            btnlogout.UseVisualStyleBackColor = true;
            btnlogout.Click += btnlogout_Click;
            // 
            // btntambahkatalog
            // 
            btntambahkatalog.Location = new Point(637, 25);
            btntambahkatalog.Name = "btntambahkatalog";
            btntambahkatalog.Size = new Size(140, 29);
            btntambahkatalog.TabIndex = 6;
            btntambahkatalog.Text = "Tambah Katalog";
            btntambahkatalog.UseVisualStyleBackColor = true;
            btntambahkatalog.Click += btntambahkatalog_Click;
            // 
            // btnstok
            // 
            btnstok.Location = new Point(525, 25);
            btnstok.Name = "btnstok";
            btnstok.Size = new Size(94, 29);
            btnstok.TabIndex = 7;
            btnstok.Text = "Stok";
            btnstok.UseVisualStyleBackColor = true;
            btnstok.Click += btnstok_Click;
            // 
            // v_katalogadmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnstok);
            Controls.Add(btntambahkatalog);
            Controls.Add(btnlogout);
            Controls.Add(btnprofiladmin);
            Controls.Add(btnriwayatadmin);
            Controls.Add(btnpesananadmin);
            Controls.Add(btnkatalogadmin);
            Controls.Add(flowpanel);
            Name = "v_katalogadmin";
            Text = "v_katalogadmin";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowpanel;
        private Button btnkatalogadmin;
        private Button btnpesananadmin;
        private Button btnriwayatadmin;
        private Button btnprofiladmin;
        private Button btnlogout;
        private Button btntambahkatalog;
        private Button btnstok;
    }
}