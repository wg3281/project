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
    public partial class checkbox控件 : Form
    {
        public checkbox控件()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.Font = new Font(this.Font, FontStyle.Bold);
            }
            else
            {
                textBox1.Font = new Font(this.Font, FontStyle.Regular);
            }            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox1.Font = new Font(this.Font, FontStyle.Italic|FontStyle.Bold);
            }
            else
            {
                textBox1.Font = new Font(this.Font, FontStyle.Regular);
            }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                textBox1.Font = new Font(this.Font, FontStyle.Underline);
            }
            else
            {
                textBox1.Font = new Font(this.Font, FontStyle.Regular);
            }
        }
    }
}
