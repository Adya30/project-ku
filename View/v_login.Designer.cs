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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(v_login));
            tblogin_username = new TextBox();
            tblogin_password = new TextBox();
            btnlogin = new Button();
            btndaftar = new Button();
            SuspendLayout();
            // 
            // tblogin_username
            // 
            tblogin_username.BackColor = SystemColors.Menu;
            tblogin_username.BorderStyle = BorderStyle.None;
            tblogin_username.Font = new Font("Segoe UI", 16F);
            tblogin_username.Location = new Point(1143, 294);
            tblogin_username.Name = "tblogin_username";
            tblogin_username.Size = new Size(266, 36);
            tblogin_username.TabIndex = 1;
            // 
            // tblogin_password
            // 
            tblogin_password.BackColor = SystemColors.Menu;
            tblogin_password.BorderStyle = BorderStyle.None;
            tblogin_password.Font = new Font("Segoe UI", 16F);
            tblogin_password.Location = new Point(1143, 468);
            tblogin_password.Name = "tblogin_password";
            tblogin_password.Size = new Size(266, 36);
            tblogin_password.TabIndex = 2;
            // 
            // btnlogin
            // 
            btnlogin.Font = new Font("Segoe UI", 16F);
            btnlogin.Location = new Point(1316, 599);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(151, 62);
            btnlogin.TabIndex = 3;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // btndaftar
            // 
            btndaftar.Font = new Font("Segoe UI", 16F);
            btndaftar.Location = new Point(1616, 813);
            btndaftar.Name = "btndaftar";
            btndaftar.Size = new Size(151, 62);
            btndaftar.TabIndex = 4;
            btndaftar.Text = "Daftar";
            btndaftar.UseVisualStyleBackColor = true;
            btndaftar.Click += btndaftar_Click;
            // 
            // v_login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1924, 1055);
            Controls.Add(btndaftar);
            Controls.Add(btnlogin);
            Controls.Add(tblogin_password);
            Controls.Add(tblogin_username);
            DoubleBuffered = true;
            Name = "v_login";
            Text = "v_login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tblogin_username;
        private TextBox tblogin_password;
        private Button btnlogin;
        private Button btndaftar;
    }
}