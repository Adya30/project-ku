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
            linkLabel1 = new LinkLabel();
            linklogin = new LinkLabel();
            btndaftar = new Button();
            tbnama_lengkap = new TextBox();
            tbusername_register = new TextBox();
            tbno_telp = new TextBox();
            tbpassword_register = new TextBox();
            tbkonfirmasi_password = new TextBox();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(675, 353);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 20);
            linkLabel1.TabIndex = 0;
            // 
            // linklogin
            // 
            linklogin.AutoSize = true;
            linklogin.Location = new Point(651, 312);
            linklogin.Name = "linklogin";
            linklogin.Size = new Size(46, 20);
            linklogin.TabIndex = 1;
            linklogin.TabStop = true;
            linklogin.Text = "Login";
            linklogin.LinkClicked += linklogin_LinkClicked;
            // 
            // btndaftar
            // 
            btndaftar.Location = new Point(530, 309);
            btndaftar.Name = "btndaftar";
            btndaftar.Size = new Size(94, 29);
            btndaftar.TabIndex = 2;
            btndaftar.Text = "Daftar";
            btndaftar.UseVisualStyleBackColor = true;
            btndaftar.Click += btndaftar_Click;
            // 
            // tbnama_lengkap
            // 
            tbnama_lengkap.Location = new Point(369, 87);
            tbnama_lengkap.Name = "tbnama_lengkap";
            tbnama_lengkap.Size = new Size(125, 27);
            tbnama_lengkap.TabIndex = 3;
            // 
            // tbusername_register
            // 
            tbusername_register.Location = new Point(369, 136);
            tbusername_register.Name = "tbusername_register";
            tbusername_register.Size = new Size(125, 27);
            tbusername_register.TabIndex = 4;
            // 
            // tbno_telp
            // 
            tbno_telp.Location = new Point(369, 187);
            tbno_telp.Name = "tbno_telp";
            tbno_telp.Size = new Size(125, 27);
            tbno_telp.TabIndex = 5;
            // 
            // tbpassword_register
            // 
            tbpassword_register.Location = new Point(369, 233);
            tbpassword_register.Name = "tbpassword_register";
            tbpassword_register.Size = new Size(125, 27);
            tbpassword_register.TabIndex = 6;
            // 
            // tbkonfirmasi_password
            // 
            tbkonfirmasi_password.Location = new Point(369, 283);
            tbkonfirmasi_password.Name = "tbkonfirmasi_password";
            tbkonfirmasi_password.Size = new Size(125, 27);
            tbkonfirmasi_password.TabIndex = 7;
            // 
            // v_register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbkonfirmasi_password);
            Controls.Add(tbpassword_register);
            Controls.Add(tbno_telp);
            Controls.Add(tbusername_register);
            Controls.Add(tbnama_lengkap);
            Controls.Add(btndaftar);
            Controls.Add(linklogin);
            Controls.Add(linkLabel1);
            Name = "v_register";
            Text = "v_register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private LinkLabel linklogin;
        private Button btndaftar;
        private TextBox tbnama_lengkap;
        private TextBox tbusername_register;
        private TextBox tbno_telp;
        private TextBox tbpassword_register;
        private TextBox tbkonfirmasi_password;
    }
}