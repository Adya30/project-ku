namespace TaniGrow2.View
{
    partial class v_katalogcustomer
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
            btnprofilcustomer = new Button();
            btnriwayatcustomer = new Button();
            btnpesanancustomer = new Button();
            btnkatalogcustomer = new Button();
            panelflow = new FlowLayoutPanel();
            panelRingkasan = new Panel();
            btnbayar = new Button();
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
            // 
            // btnprofilcustomer
            // 
            btnprofilcustomer.Location = new Point(19, 244);
            btnprofilcustomer.Name = "btnprofilcustomer";
            btnprofilcustomer.Size = new Size(94, 29);
            btnprofilcustomer.TabIndex = 11;
            btnprofilcustomer.Text = "Profil";
            btnprofilcustomer.UseVisualStyleBackColor = true;
            // 
            // btnriwayatcustomer
            // 
            btnriwayatcustomer.Location = new Point(19, 190);
            btnriwayatcustomer.Name = "btnriwayatcustomer";
            btnriwayatcustomer.Size = new Size(94, 29);
            btnriwayatcustomer.TabIndex = 10;
            btnriwayatcustomer.Text = "Riwayat";
            btnriwayatcustomer.UseVisualStyleBackColor = true;
            // 
            // btnpesanancustomer
            // 
            btnpesanancustomer.Location = new Point(19, 129);
            btnpesanancustomer.Name = "btnpesanancustomer";
            btnpesanancustomer.Size = new Size(94, 29);
            btnpesanancustomer.TabIndex = 9;
            btnpesanancustomer.Text = "Pesanan";
            btnpesanancustomer.UseVisualStyleBackColor = true;
            // 
            // btnkatalogcustomer
            // 
            btnkatalogcustomer.Location = new Point(19, 73);
            btnkatalogcustomer.Name = "btnkatalogcustomer";
            btnkatalogcustomer.Size = new Size(94, 29);
            btnkatalogcustomer.TabIndex = 8;
            btnkatalogcustomer.Text = "Katalog";
            btnkatalogcustomer.UseVisualStyleBackColor = true;
            // 
            // panelflow
            // 
            panelflow.Location = new Point(146, 67);
            panelflow.Name = "panelflow";
            panelflow.Size = new Size(410, 365);
            panelflow.TabIndex = 7;
            // 
            // panelRingkasan
            // 
            panelRingkasan.Location = new Point(562, 67);
            panelRingkasan.Name = "panelRingkasan";
            panelRingkasan.Size = new Size(226, 365);
            panelRingkasan.TabIndex = 0;
            // 
            // btnbayar
            // 
            btnbayar.Location = new Point(657, 32);
            btnbayar.Name = "btnbayar";
            btnbayar.Size = new Size(94, 29);
            btnbayar.TabIndex = 13;
            btnbayar.Text = "Bayar";
            btnbayar.UseVisualStyleBackColor = true;
            // 
            // v_katalogcustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnbayar);
            Controls.Add(panelRingkasan);
            Controls.Add(btnlogout);
            Controls.Add(btnprofilcustomer);
            Controls.Add(btnriwayatcustomer);
            Controls.Add(btnpesanancustomer);
            Controls.Add(btnkatalogcustomer);
            Controls.Add(panelflow);
            Name = "v_katalogcustomer";
            Text = "v_katalogcustomer";
            ResumeLayout(false);
        }

        #endregion

        private Button btnlogout;
        private Button btnprofilcustomer;
        private Button btnriwayatcustomer;
        private Button btnpesanancustomer;
        private Button btnkatalogcustomer;
        private FlowLayoutPanel panelflow;
        private Panel panelRingkasan;
        private Button btnbayar;
    }
}