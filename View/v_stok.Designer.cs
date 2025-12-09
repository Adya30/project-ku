namespace TaniGrow2.View
{
    partial class v_stok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(v_stok));
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            btnrestock = new Button();
            btnkembali = new Button();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Location = new Point(12, 220);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1354, 823);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(1388, 255);
            panel1.Name = "panel1";
            panel1.Size = new Size(492, 788);
            panel1.TabIndex = 1;
            // 
            // btnrestock
            // 
            btnrestock.Font = new Font("Segoe UI", 16F);
            btnrestock.Location = new Point(1388, 193);
            btnrestock.Name = "btnrestock";
            btnrestock.Size = new Size(239, 56);
            btnrestock.TabIndex = 2;
            btnrestock.Text = "Restock";
            btnrestock.UseVisualStyleBackColor = true;
            btnrestock.Click += btnrestock_Click;
            // 
            // btnkembali
            // 
            btnkembali.Font = new Font("Segoe UI", 16F);
            btnkembali.Location = new Point(1642, 193);
            btnkembali.Name = "btnkembali";
            btnkembali.Size = new Size(238, 56);
            btnkembali.TabIndex = 3;
            btnkembali.Text = "Kembali";
            btnkembali.UseVisualStyleBackColor = true;
            btnkembali.Click += btnkembali_Click;
            // 
            // v_stok
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1924, 1055);
            Controls.Add(btnkembali);
            Controls.Add(btnrestock);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            DoubleBuffered = true;
            Name = "v_stok";
            Text = "v_stok";
            Load += v_stok_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Button btnrestock;
        private Button btnkembali;
    }
}