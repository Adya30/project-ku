namespace TaniGrow2.View
{
    partial class v_tambahkatalog
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
            btnpicture = new PictureBox();
            cbjenisproduk = new ComboBox();
            tbnama_produk = new TextBox();
            rbdeskripsi = new RichTextBox();
            tbharga = new TextBox();
            tbstok = new TextBox();
            btnsimpan = new Button();
            btnbatal = new Button();
            btnlogout = new Button();
            btnkatalogadmin = new Button();
            btnriwayatadmin = new Button();
            btnpesananadmin = new Button();
            btnprofiladmin = new Button();
            ((System.ComponentModel.ISupportInitialize)btnpicture).BeginInit();
            SuspendLayout();
            // 
            // btnpicture
            // 
            btnpicture.Location = new Point(295, 75);
            btnpicture.Name = "btnpicture";
            btnpicture.Size = new Size(125, 146);
            btnpicture.TabIndex = 0;
            btnpicture.TabStop = false;
            btnpicture.Click += btnpicture_Click;
            // 
            // cbjenisproduk
            // 
            cbjenisproduk.FormattingEnabled = true;
            cbjenisproduk.Location = new Point(453, 131);
            cbjenisproduk.Name = "cbjenisproduk";
            cbjenisproduk.Size = new Size(151, 28);
            cbjenisproduk.TabIndex = 1;
            // 
            // tbnama_produk
            // 
            tbnama_produk.Location = new Point(453, 75);
            tbnama_produk.Name = "tbnama_produk";
            tbnama_produk.Size = new Size(125, 27);
            tbnama_produk.TabIndex = 2;
            // 
            // rbdeskripsi
            // 
            rbdeskripsi.Location = new Point(333, 264);
            rbdeskripsi.Name = "rbdeskripsi";
            rbdeskripsi.Size = new Size(362, 120);
            rbdeskripsi.TabIndex = 3;
            rbdeskripsi.Text = "";
            // 
            // tbharga
            // 
            tbharga.Location = new Point(601, 194);
            tbharga.Name = "tbharga";
            tbharga.Size = new Size(125, 27);
            tbharga.TabIndex = 4;
            // 
            // tbstok
            // 
            tbstok.Location = new Point(453, 194);
            tbstok.Name = "tbstok";
            tbstok.Size = new Size(125, 27);
            tbstok.TabIndex = 5;
            // 
            // btnsimpan
            // 
            btnsimpan.Location = new Point(659, 26);
            btnsimpan.Name = "btnsimpan";
            btnsimpan.Size = new Size(94, 29);
            btnsimpan.TabIndex = 6;
            btnsimpan.Text = "Simpan";
            btnsimpan.UseVisualStyleBackColor = true;
            btnsimpan.Click += btnsimpan_Click;
            // 
            // btnbatal
            // 
            btnbatal.Location = new Point(662, 75);
            btnbatal.Name = "btnbatal";
            btnbatal.Size = new Size(94, 29);
            btnbatal.TabIndex = 7;
            btnbatal.Text = "Batal";
            btnbatal.UseVisualStyleBackColor = true;
            btnbatal.Click += btnbatal_Click;
            // 
            // btnlogout
            // 
            btnlogout.Location = new Point(57, 400);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(94, 29);
            btnlogout.TabIndex = 8;
            btnlogout.Text = "Log out";
            btnlogout.UseVisualStyleBackColor = true;
            btnlogout.Click += btnlogout_Click;
            // 
            // btnkatalogadmin
            // 
            btnkatalogadmin.Location = new Point(48, 75);
            btnkatalogadmin.Name = "btnkatalogadmin";
            btnkatalogadmin.Size = new Size(94, 29);
            btnkatalogadmin.TabIndex = 9;
            btnkatalogadmin.Text = "Katalog";
            btnkatalogadmin.UseVisualStyleBackColor = true;
            btnkatalogadmin.Click += btnkatalogadmin_Click;
            // 
            // btnriwayatadmin
            // 
            btnriwayatadmin.Location = new Point(48, 192);
            btnriwayatadmin.Name = "btnriwayatadmin";
            btnriwayatadmin.Size = new Size(94, 29);
            btnriwayatadmin.TabIndex = 10;
            btnriwayatadmin.Text = "Riwayat";
            btnriwayatadmin.UseVisualStyleBackColor = true;
            btnriwayatadmin.Click += btnriwayatadmin_Click;
            // 
            // btnpesananadmin
            // 
            btnpesananadmin.Location = new Point(48, 131);
            btnpesananadmin.Name = "btnpesananadmin";
            btnpesananadmin.Size = new Size(94, 29);
            btnpesananadmin.TabIndex = 11;
            btnpesananadmin.Text = "Pesanan";
            btnpesananadmin.UseVisualStyleBackColor = true;
            btnpesananadmin.Click += btnpesananadmin_Click;
            // 
            // btnprofiladmin
            // 
            btnprofiladmin.Location = new Point(48, 245);
            btnprofiladmin.Name = "btnprofiladmin";
            btnprofiladmin.Size = new Size(94, 29);
            btnprofiladmin.TabIndex = 12;
            btnprofiladmin.Text = "Profil";
            btnprofiladmin.UseVisualStyleBackColor = true;
            btnprofiladmin.Click += btnprofiladmin_Click;
            // 
            // v_tambahkatalog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnprofiladmin);
            Controls.Add(btnpesananadmin);
            Controls.Add(btnriwayatadmin);
            Controls.Add(btnkatalogadmin);
            Controls.Add(btnlogout);
            Controls.Add(btnbatal);
            Controls.Add(btnsimpan);
            Controls.Add(tbstok);
            Controls.Add(tbharga);
            Controls.Add(rbdeskripsi);
            Controls.Add(tbnama_produk);
            Controls.Add(cbjenisproduk);
            Controls.Add(btnpicture);
            Name = "v_tambahkatalog";
            Text = "v_tambahkatalog";
            ((System.ComponentModel.ISupportInitialize)btnpicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btnpicture;
        private ComboBox cbjenisproduk;
        private TextBox tbnama_produk;
        private RichTextBox rbdeskripsi;
        private TextBox tbharga;
        private TextBox tbstok;
        private Button btnsimpan;
        private Button btnbatal;
        private Button btnlogout;
        private Button btnkatalogadmin;
        private Button btnriwayatadmin;
        private Button btnpesananadmin;
        private Button btnprofiladmin;
    }
}