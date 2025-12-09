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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(v_tambahkatalog));
            btnpicture = new PictureBox();
            cbjenisproduk = new ComboBox();
            tbnama_produk = new TextBox();
            rbdeskripsi = new RichTextBox();
            tbharga = new TextBox();
            tbstok = new TextBox();
            btnsimpan = new Button();
            btnbatal = new Button();
            ((System.ComponentModel.ISupportInitialize)btnpicture).BeginInit();
            SuspendLayout();
            // 
            // btnpicture
            // 
            btnpicture.Location = new Point(69, 257);
            btnpicture.Name = "btnpicture";
            btnpicture.Size = new Size(578, 697);
            btnpicture.TabIndex = 0;
            btnpicture.TabStop = false;
            btnpicture.Click += btnpicture_Click;
            // 
            // cbjenisproduk
            // 
            cbjenisproduk.Font = new Font("Segoe UI", 16F);
            cbjenisproduk.FormattingEnabled = true;
            cbjenisproduk.Location = new Point(779, 428);
            cbjenisproduk.Name = "cbjenisproduk";
            cbjenisproduk.Size = new Size(273, 45);
            cbjenisproduk.TabIndex = 1;
            // 
            // tbnama_produk
            // 
            tbnama_produk.BorderStyle = BorderStyle.FixedSingle;
            tbnama_produk.Font = new Font("Segoe UI", 16F);
            tbnama_produk.Location = new Point(779, 311);
            tbnama_produk.Name = "tbnama_produk";
            tbnama_produk.Size = new Size(273, 43);
            tbnama_produk.TabIndex = 2;
            // 
            // rbdeskripsi
            // 
            rbdeskripsi.BorderStyle = BorderStyle.FixedSingle;
            rbdeskripsi.Font = new Font("Segoe UI", 16F);
            rbdeskripsi.Location = new Point(779, 649);
            rbdeskripsi.Name = "rbdeskripsi";
            rbdeskripsi.Size = new Size(693, 107);
            rbdeskripsi.TabIndex = 3;
            rbdeskripsi.Text = "";
            // 
            // tbharga
            // 
            tbharga.BorderStyle = BorderStyle.FixedSingle;
            tbharga.Font = new Font("Segoe UI", 16F);
            tbharga.Location = new Point(1139, 545);
            tbharga.Name = "tbharga";
            tbharga.Size = new Size(199, 43);
            tbharga.TabIndex = 4;
            // 
            // tbstok
            // 
            tbstok.BorderStyle = BorderStyle.FixedSingle;
            tbstok.Font = new Font("Segoe UI", 16F);
            tbstok.Location = new Point(779, 545);
            tbstok.Name = "tbstok";
            tbstok.Size = new Size(125, 43);
            tbstok.TabIndex = 5;
            // 
            // btnsimpan
            // 
            btnsimpan.Font = new Font("Segoe UI", 16F);
            btnsimpan.Location = new Point(1110, 853);
            btnsimpan.Name = "btnsimpan";
            btnsimpan.Size = new Size(180, 58);
            btnsimpan.TabIndex = 6;
            btnsimpan.Text = "Simpan";
            btnsimpan.UseVisualStyleBackColor = true;
            btnsimpan.Click += btnsimpan_Click;
            // 
            // btnbatal
            // 
            btnbatal.Font = new Font("Segoe UI", 16F);
            btnbatal.Location = new Point(1334, 853);
            btnbatal.Name = "btnbatal";
            btnbatal.Size = new Size(180, 58);
            btnbatal.TabIndex = 7;
            btnbatal.Text = "Batal";
            btnbatal.UseVisualStyleBackColor = true;
            btnbatal.Click += btnbatal_Click;
            // 
            // v_tambahkatalog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1924, 1055);
            Controls.Add(btnbatal);
            Controls.Add(btnsimpan);
            Controls.Add(tbstok);
            Controls.Add(tbharga);
            Controls.Add(rbdeskripsi);
            Controls.Add(tbnama_produk);
            Controls.Add(cbjenisproduk);
            Controls.Add(btnpicture);
            DoubleBuffered = true;
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
    }
}