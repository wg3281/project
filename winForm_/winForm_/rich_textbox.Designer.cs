namespace winForm_
{
    partial class rich_textbox
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.bluebtn = new System.Windows.Forms.Button();
            this.redbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.yaheibtn = new System.Windows.Forms.Button();
            this.diwenbtn = new System.Windows.Forms.Button();
            this.xmhbtn = new System.Windows.Forms.Button();
            this.lishubtn = new System.Windows.Forms.Button();
            this.fybtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 45);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(597, 393);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // bluebtn
            // 
            this.bluebtn.Location = new System.Drawing.Point(635, 45);
            this.bluebtn.Name = "bluebtn";
            this.bluebtn.Size = new System.Drawing.Size(135, 40);
            this.bluebtn.TabIndex = 1;
            this.bluebtn.Text = "蓝色";
            this.bluebtn.UseVisualStyleBackColor = true;
            this.bluebtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // redbtn
            // 
            this.redbtn.Location = new System.Drawing.Point(635, 100);
            this.redbtn.Name = "redbtn";
            this.redbtn.Size = new System.Drawing.Size(135, 40);
            this.redbtn.TabIndex = 2;
            this.redbtn.Text = "红色";
            this.redbtn.UseVisualStyleBackColor = true;
            this.redbtn.Click += new System.EventHandler(this.redbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "先选中文字";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(667, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "功能区";
            // 
            // yaheibtn
            // 
            this.yaheibtn.Location = new System.Drawing.Point(635, 210);
            this.yaheibtn.Name = "yaheibtn";
            this.yaheibtn.Size = new System.Drawing.Size(135, 40);
            this.yaheibtn.TabIndex = 5;
            this.yaheibtn.Text = "雅黑15";
            this.yaheibtn.UseVisualStyleBackColor = true;
            this.yaheibtn.Click += new System.EventHandler(this.yaheibtn_Click);
            // 
            // diwenbtn
            // 
            this.diwenbtn.Location = new System.Drawing.Point(635, 265);
            this.diwenbtn.Name = "diwenbtn";
            this.diwenbtn.Size = new System.Drawing.Size(135, 40);
            this.diwenbtn.TabIndex = 6;
            this.diwenbtn.Text = "底纹";
            this.diwenbtn.UseVisualStyleBackColor = true;
            this.diwenbtn.Click += new System.EventHandler(this.diwenbtn_Click);
            // 
            // xmhbtn
            // 
            this.xmhbtn.Location = new System.Drawing.Point(635, 320);
            this.xmhbtn.Name = "xmhbtn";
            this.xmhbtn.Size = new System.Drawing.Size(135, 40);
            this.xmhbtn.TabIndex = 7;
            this.xmhbtn.Text = "项目符号";
            this.xmhbtn.UseVisualStyleBackColor = true;
            this.xmhbtn.Click += new System.EventHandler(this.xmhbtn_Click);
            // 
            // lishubtn
            // 
            this.lishubtn.Location = new System.Drawing.Point(635, 155);
            this.lishubtn.Name = "lishubtn";
            this.lishubtn.Size = new System.Drawing.Size(135, 40);
            this.lishubtn.TabIndex = 8;
            this.lishubtn.Text = "隶书9";
            this.lishubtn.UseVisualStyleBackColor = true;
            this.lishubtn.Click += new System.EventHandler(this.lishubtn_Click);
            // 
            // fybtn
            // 
            this.fybtn.Location = new System.Drawing.Point(635, 375);
            this.fybtn.Name = "fybtn";
            this.fybtn.Size = new System.Drawing.Size(135, 40);
            this.fybtn.TabIndex = 9;
            this.fybtn.Text = "复原";
            this.fybtn.UseVisualStyleBackColor = true;
            this.fybtn.Click += new System.EventHandler(this.fybtn_Click);
            // 
            // rich_textbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fybtn);
            this.Controls.Add(this.lishubtn);
            this.Controls.Add(this.xmhbtn);
            this.Controls.Add(this.diwenbtn);
            this.Controls.Add(this.yaheibtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.redbtn);
            this.Controls.Add(this.bluebtn);
            this.Controls.Add(this.richTextBox1);
            this.Name = "rich_textbox";
            this.Text = "rich_textbox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button bluebtn;
        private System.Windows.Forms.Button redbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button yaheibtn;
        private System.Windows.Forms.Button diwenbtn;
        private System.Windows.Forms.Button xmhbtn;
        private System.Windows.Forms.Button lishubtn;
        private System.Windows.Forms.Button fybtn;
    }
}