using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winForm_
{
    public partial class rich_textbox : Form
    {
        public rich_textbox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Blue;
        }

        private void redbtn_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Pink;
        }

        private void lishubtn_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font("隶书",9);
        }

        private void yaheibtn_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font("微软雅黑", 15);
        }

        private void diwenbtn_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBackColor = Color.Gray;
        }

        private void xmhbtn_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBullet = !richTextBox1.SelectionBullet;
        }

        private void fybtn_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Black;
            richTextBox1.SelectionFont = new Font("宋体", 15);
            richTextBox1.SelectionBackColor = Color.White;
            richTextBox1.SelectionBullet = false;

        }
    }
}
