using System.Windows.Forms;
using System.Drawing;
using System;


namespace winForm_
{
    public partial class MaimForm : Form
    {
        int i = 0;
        public MaimForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.Text = "111";
            //StaticTry.TryMainForm = this;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {

        }

        private void 新建ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ChildForm mychildfrm = new ChildForm();
            mychildfrm.MdiParent = this;
            mychildfrm.Show();
        }

        private void 层叠ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void 水平ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void 垂直ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void 关闭ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {                       
            ChildForm form2 = new ChildForm();
            StaticTry.TryForm.Push(form2);
            StaticTry.TryForm.Peek().Size = new Size(300, 300);
            StaticTry.TryForm.Peek().Text = i.ToString();
            i++;
            StaticTry.TryForm.Peek().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (StaticTry.TryForm.Count != 0)
            {
                StaticTry.TryForm.Peek().Close();
                StaticTry.TryForm.Pop();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StaticTry.TryMainForm = this;
            StaticTry.TryMainForm.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            rich_textbox rich_Textbox = new rich_textbox();
            rich_Textbox.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Timer1 timer1 = new Timer1();
            timer1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            checkbox控件 checkBox = new checkbox控件();
            checkBox.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Login login1 = new Login();
            login1.Show();

        }
    }
}
