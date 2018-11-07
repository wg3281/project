namespace winForm_
{
    partial class Timer1
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
            this.components = new System.ComponentModel.Container();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Starbtn = new System.Windows.Forms.Button();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "●○●○●○●○●○●○●○●○";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(135, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "00:00:00.00";
            // 
            // Starbtn
            // 
            this.Starbtn.Location = new System.Drawing.Point(100, 169);
            this.Starbtn.Name = "Starbtn";
            this.Starbtn.Size = new System.Drawing.Size(125, 41);
            this.Starbtn.TabIndex = 2;
            this.Starbtn.Text = "开始计时";
            this.Starbtn.UseVisualStyleBackColor = true;
            this.Starbtn.Click += new System.EventHandler(this.Starbtn_Click);
            // 
            // Clearbtn
            // 
            this.Clearbtn.Location = new System.Drawing.Point(268, 169);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(125, 41);
            this.Clearbtn.TabIndex = 3;
            this.Clearbtn.Text = "清零";
            this.Clearbtn.UseVisualStyleBackColor = true;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(153, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 46);
            this.label3.TabIndex = 4;
            this.label3.Text = "00:00:00.00";
            // 
            // timer3
            // 
            this.timer3.Interval = 10;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Timer1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 360);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Clearbtn);
            this.Controls.Add(this.Starbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Timer1";
            this.Text = "Timer1";
            this.Activated += new System.EventHandler(this.Timer1_Activated);
            this.Deactivate += new System.EventHandler(this.Timer1_Deactivate);
            this.Load += new System.EventHandler(this.Timer1_Load);
            this.Enter += new System.EventHandler(this.Timer1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Starbtn;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer3;
    }
}