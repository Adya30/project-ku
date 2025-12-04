namespace TaniGrow2.View
{
    partial class v_login
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
            linkdaftar = new LinkLabel();
            tblogin_username = new TextBox();
            tblogin_password = new TextBox();
            btnlogin = new Button();
            SuspendLayout();
            // 
            // linkdaftar
            // 
            linkdaftar.AutoSize = true;
            linkdaftar.Location = new Point(656, 328);
            linkdaftar.Name = "linkdaftar";
            linkdaftar.Size = new Size(51, 20);
            linkdaftar.TabIndex = 0;
            linkdaftar.TabStop = true;
            linkdaftar.Text = "Daftar";
            linkdaftar.LinkClicked += linkdaftar_LinkClicked;
            // 
            // tblogin_username
            // 
            tblogin_username.Location = new Point(241, 87);
            tblogin_username.Name = "tblogin_username";
            tblogin_username.Size = new Size(125, 27);
            tblogin_username.TabIndex = 1;
            // 
            // tblogin_password
            // 
            tblogin_password.Location = new Point(241, 149);
            tblogin_password.Name = "tblogin_password";
            tblogin_password.Size = new Size(125, 27);
            tblogin_password.TabIndex = 2;
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(323, 278);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(94, 29);
            btnlogin.TabIndex = 3;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // v_login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnlogin);
            Controls.Add(tblogin_password);
            Controls.Add(tblogin_username);
            Controls.Add(linkdaftar);
            Name = "v_login";
            Text = "v_login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkdaftar;
        private TextBox tblogin_username;
        private TextBox tblogin_password;
        private Button btnlogin;
    }
}