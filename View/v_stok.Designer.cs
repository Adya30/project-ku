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
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            btnrestock = new Button();
            btnkembali = new Button();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(19, 62);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(510, 411);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(535, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(463, 521);
            panel1.TabIndex = 1;
            // 
            // btnrestock
            // 
            btnrestock.Location = new Point(635, 20);
            btnrestock.Name = "btnrestock";
            btnrestock.Size = new Size(94, 29);
            btnrestock.TabIndex = 2;
            btnrestock.Text = "Restock";
            btnrestock.UseVisualStyleBackColor = true;
            btnrestock.Click += btnrestock_Click;
            // 
            // btnkembali
            // 
            btnkembali.Location = new Point(790, 23);
            btnkembali.Name = "btnkembali";
            btnkembali.Size = new Size(94, 29);
            btnkembali.TabIndex = 3;
            btnkembali.Text = "Kembali";
            btnkembali.UseVisualStyleBackColor = true;
            btnkembali.Click += btnkembali_Click;
            // 
            // v_stok
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 558);
            Controls.Add(btnkembali);
            Controls.Add(btnrestock);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Name = "v_stok";
            Text = "v_stok";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Button btnrestock;
        private Button btnkembali;
    }
}