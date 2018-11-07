namespace winForm_
{
    partial class Login
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
            this.loginbt = new System.Windows.Forms.Button();
            this.userlb = new System.Windows.Forms.Label();
            this.pswdlb = new System.Windows.Forms.Label();
            this.usertb = new System.Windows.Forms.TextBox();
            this.pswdtb = new System.Windows.Forms.TextBox();
            this.adminrb = new System.Windows.Forms.RadioButton();
            this.guestrb = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // loginbt
            // 
            this.loginbt.Location = new System.Drawing.Point(87, 202);
            this.loginbt.Name = "loginbt";
            this.loginbt.Size = new System.Drawing.Size(127, 41);
            this.loginbt.TabIndex = 0;
            this.loginbt.Text = "登录";
            this.loginbt.UseVisualStyleBackColor = true;
            this.loginbt.Click += new System.EventHandler(this.loginbt_Click);
            // 
            // userlb
            // 
            this.userlb.AutoSize = true;
            this.userlb.Location = new System.Drawing.Point(49, 48);
            this.userlb.Name = "userlb";
            this.userlb.Size = new System.Drawing.Size(62, 18);
            this.userlb.TabIndex = 1;
            this.userlb.Text = "用户名";
            // 
            // pswdlb
            // 
            this.pswdlb.AutoSize = true;
            this.pswdlb.Location = new System.Drawing.Point(67, 97);
            this.pswdlb.Name = "pswdlb";
            this.pswdlb.Size = new System.Drawing.Size(44, 18);
            this.pswdlb.TabIndex = 2;
            this.pswdlb.Text = "密码";
            // 
            // usertb
            // 
            this.usertb.Location = new System.Drawing.Point(138, 48);
            this.usertb.Name = "usertb";
            this.usertb.Size = new System.Drawing.Size(100, 28);
            this.usertb.TabIndex = 3;
            // 
            // pswdtb
            // 
            this.pswdtb.Location = new System.Drawing.Point(138, 90);
            this.pswdtb.Name = "pswdtb";
            this.pswdtb.PasswordChar = '*';
            this.pswdtb.Size = new System.Drawing.Size(100, 28);
            this.pswdtb.TabIndex = 4;
            // 
            // adminrb
            // 
            this.adminrb.AutoSize = true;
            this.adminrb.Location = new System.Drawing.Point(70, 151);
            this.adminrb.Name = "adminrb";
            this.adminrb.Size = new System.Drawing.Size(87, 22);
            this.adminrb.TabIndex = 5;
            this.adminrb.TabStop = true;
            this.adminrb.Text = "管理员";
            this.adminrb.UseVisualStyleBackColor = true;
            // 
            // guestrb
            // 
            this.guestrb.AutoSize = true;
            this.guestrb.Location = new System.Drawing.Point(182, 151);
            this.guestrb.Name = "guestrb";
            this.guestrb.Size = new System.Drawing.Size(69, 22);
            this.guestrb.TabIndex = 6;
            this.guestrb.TabStop = true;
            this.guestrb.Text = "访客";
            this.guestrb.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 278);
            this.Controls.Add(this.guestrb);
            this.Controls.Add(this.adminrb);
            this.Controls.Add(this.pswdtb);
            this.Controls.Add(this.usertb);
            this.Controls.Add(this.pswdlb);
            this.Controls.Add(this.userlb);
            this.Controls.Add(this.loginbt);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginbt;
        private System.Windows.Forms.Label userlb;
        private System.Windows.Forms.Label pswdlb;
        private System.Windows.Forms.TextBox usertb;
        private System.Windows.Forms.TextBox pswdtb;
        private System.Windows.Forms.RadioButton adminrb;
        private System.Windows.Forms.RadioButton guestrb;
    }
}