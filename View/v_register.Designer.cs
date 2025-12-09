namespace TaniGrow2.View
{
    partial class v_register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(v_register));
            linklogin = new LinkLabel();
            btndaftar = new Button();
            tbnama_lengkap = new TextBox();
            tbusername_register = new TextBox();
            tbno_telp = new TextBox();
            tbpassword_register = new TextBox();
            tbkonfirmasi_password = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // linklogin
            // 
            linklogin.AutoSize = true;
            linklogin.BackColor = Color.Transparent;
            linklogin.LinkColor = Color.White;
            linklogin.Location = new Point(1620, 673);
            linklogin.Name = "linklogin";
            linklogin.Size = new Size(46, 20);
            linklogin.TabIndex = 1;
            linklogin.TabStop = true;
            linklogin.Text = "Login";
            linklogin.LinkClicked += linklogin_LinkClicked;
            // 
            // btndaftar
            // 
            btndaftar.Location = new Point(1392, 673);
            btndaftar.Name = "btndaftar";
            btndaftar.Size = new Size(94, 29);
            btndaftar.TabIndex = 2;
            btndaftar.Text = "Daftar";
            btndaftar.UseVisualStyleBackColor = true;
            btndaftar.Click += btndaftar_Click;
            // 
            // tbnama_lengkap
            // 
            tbnama_lengkap.BorderStyle = BorderStyle.None;
            tbnama_lengkap.Font = new Font("Segoe UI", 16.2F);
            tbnama_lengkap.Location = new Point(188, 277);
            tbnama_lengkap.Name = "tbnama_lengkap";
            tbnama_lengkap.Size = new Size(125, 36);
            tbnama_lengkap.TabIndex = 3;
            // 
            // tbusername_register
            // 
            tbusername_register.BorderStyle = BorderStyle.None;
            tbusername_register.Font = new Font("Segoe UI", 16.2F);
            tbusername_register.Location = new Point(188, 432);
            tbusername_register.Name = "tbusername_register";
            tbusername_register.Size = new Size(125, 36);
            tbusername_register.TabIndex = 4;
            // 
            // tbno_telp
            // 
            tbno_telp.BorderStyle = BorderStyle.None;
            tbno_telp.Font = new Font("Segoe UI", 16.2F);
            tbno_telp.Location = new Point(188, 585);
            tbno_telp.Name = "tbno_telp";
            tbno_telp.Size = new Size(125, 36);
            tbno_telp.TabIndex = 5;
            // 
            // tbpassword_register
            // 
            tbpassword_register.BorderStyle = BorderStyle.None;
            tbpassword_register.Font = new Font("Segoe UI", 16.2F);
            tbpassword_register.Location = new Point(188, 741);
            tbpassword_register.Name = "tbpassword_register";
            tbpassword_register.Size = new Size(125, 36);
            tbpassword_register.TabIndex = 6;
            // 
            // tbkonfirmasi_password
            // 
            tbkonfirmasi_password.BorderStyle = BorderStyle.None;
            tbkonfirmasi_password.Font = new Font("Segoe UI", 16F);
            tbkonfirmasi_password.Location = new Point(188, 893);
            tbkonfirmasi_password.Name = "tbkonfirmasi_password";
            tbkonfirmasi_password.Size = new Size(125, 36);
            tbkonfirmasi_password.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(680, 158);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 9;
            // 
            // v_register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1924, 1055);
            Controls.Add(label1);
            Controls.Add(tbkonfirmasi_password);
            Controls.Add(tbpassword_register);
            Controls.Add(tbno_telp);
            Controls.Add(tbusername_register);
            Controls.Add(tbnama_lengkap);
            Controls.Add(btndaftar);
            Controls.Add(linklogin);
            DoubleBuffered = true;
            Name = "v_register";
            Text = "v_register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private LinkLabel linklogin;
        private Button btndaftar;
        private TextBox tbnama_lengkap;
        private TextBox tbusername_register;
        private TextBox tbno_telp;
        private TextBox tbpassword_register;
        private TextBox tbkonfirmasi_password;
        private Label label1;
    }
}