namespace TaniGrow2.View
{
    partial class v_pembayaran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(v_pembayaran));
            labeltotal = new Label();
            pictureBoxBukti = new PictureBox();
            tbalamat = new RichTextBox();
            btnbayar = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBukti).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labeltotal
            // 
            labeltotal.AutoSize = true;
            labeltotal.BackColor = Color.Transparent;
            labeltotal.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labeltotal.Location = new Point(770, 496);
            labeltotal.Name = "labeltotal";
            labeltotal.Size = new Size(104, 41);
            labeltotal.TabIndex = 0;
            labeltotal.Text = "label1";
            // 
            // pictureBoxBukti
            // 
            pictureBoxBukti.BackColor = Color.SeaGreen;
            pictureBoxBukti.Location = new Point(1063, 564);
            pictureBoxBukti.Name = "pictureBoxBukti";
            pictureBoxBukti.Size = new Size(469, 310);
            pictureBoxBukti.TabIndex = 1;
            pictureBoxBukti.TabStop = false;
            pictureBoxBukti.Click += pictureBoxBukti_Click;
            // 
            // tbalamat
            // 
            tbalamat.Font = new Font("Segoe UI", 16F);
            tbalamat.Location = new Point(770, 310);
            tbalamat.Name = "tbalamat";
            tbalamat.Size = new Size(1007, 96);
            tbalamat.TabIndex = 2;
            tbalamat.Text = "";
            // 
            // btnbayar
            // 
            btnbayar.Font = new Font("Segoe UI", 16F);
            btnbayar.Location = new Point(1217, 896);
            btnbayar.Name = "btnbayar";
            btnbayar.Size = new Size(180, 58);
            btnbayar.TabIndex = 3;
            btnbayar.Text = "Bayar";
            btnbayar.UseVisualStyleBackColor = true;
            btnbayar.Click += btnbayar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(43, 218);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(641, 778);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(1129, 513);
            label1.Name = "label1";
            label1.Size = new Size(340, 37);
            label1.TabIndex = 5;
            label1.Text = "Inputkan Bukti Pembayaran";
            // 
            // v_pembayaran
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1924, 1055);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnbayar);
            Controls.Add(tbalamat);
            Controls.Add(pictureBoxBukti);
            Controls.Add(labeltotal);
            DoubleBuffered = true;
            Name = "v_pembayaran";
            Text = "v_pembayaran";
            ((System.ComponentModel.ISupportInitialize)pictureBoxBukti).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labeltotal;
        private PictureBox pictureBoxBukti;
        private RichTextBox tbalamat;
        private Button btnbayar;
        private PictureBox pictureBox1;
        private Label label1;
    }
}