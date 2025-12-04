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
            dataGridView1 = new DataGridView();
            btnprofiladmin = new Button();
            btnpesananadmin = new Button();
            btnriwayatadmin = new Button();
            btnkatalogadmin = new Button();
            btnlogout = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(223, 53);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(544, 379);
            dataGridView1.TabIndex = 34;
            // 
            // btnprofiladmin
            // 
            btnprofiladmin.Location = new Point(34, 237);
            btnprofiladmin.Name = "btnprofiladmin";
            btnprofiladmin.Size = new Size(94, 29);
            btnprofiladmin.TabIndex = 33;
            btnprofiladmin.Text = "Profil";
            btnprofiladmin.UseVisualStyleBackColor = true;
            btnprofiladmin.Click += btnprofiladmin_Click;
            // 
            // btnpesananadmin
            // 
            btnpesananadmin.Location = new Point(34, 123);
            btnpesananadmin.Name = "btnpesananadmin";
            btnpesananadmin.Size = new Size(94, 29);
            btnpesananadmin.TabIndex = 32;
            btnpesananadmin.Text = "Pesanan";
            btnpesananadmin.UseVisualStyleBackColor = true;
            // 
            // btnriwayatadmin
            // 
            btnriwayatadmin.Location = new Point(34, 184);
            btnriwayatadmin.Name = "btnriwayatadmin";
            btnriwayatadmin.Size = new Size(94, 29);
            btnriwayatadmin.TabIndex = 31;
            btnriwayatadmin.Text = "Riwayat";
            btnriwayatadmin.UseVisualStyleBackColor = true;
            btnriwayatadmin.Click += btnriwayatadmin_Click;
            // 
            // btnkatalogadmin
            // 
            btnkatalogadmin.Location = new Point(34, 67);
            btnkatalogadmin.Name = "btnkatalogadmin";
            btnkatalogadmin.Size = new Size(94, 29);
            btnkatalogadmin.TabIndex = 30;
            btnkatalogadmin.Text = "Katalog";
            btnkatalogadmin.UseVisualStyleBackColor = true;
            btnkatalogadmin.Click += btnkatalaogadmin_Click;
            // 
            // btnlogout
            // 
            btnlogout.Location = new Point(43, 392);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(94, 29);
            btnlogout.TabIndex = 29;
            btnlogout.Text = "Log out";
            btnlogout.UseVisualStyleBackColor = true;
            btnlogout.Click += btnlogout_Click;
            // 
            // v_pesananadmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnprofiladmin);
            Controls.Add(btnpesananadmin);
            Controls.Add(btnriwayatadmin);
            Controls.Add(btnkatalogadmin);
            Controls.Add(btnlogout);
            Name = "v_pesananadmin";
            Text = "v_pesananadmin";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnprofiladmin;
        private Button btnpesananadmin;
        private Button btnriwayatadmin;
        private Button btnkatalogadmin;
        private Button btnlogout;
    }
}