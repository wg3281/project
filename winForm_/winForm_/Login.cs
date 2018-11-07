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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginbt_Click(object sender, EventArgs e)
        {
            //检查身份选择
            if (adminrb.Checked || guestrb.Checked)
            {
                if (adminrb.Checked)
                {
                    if (usertb.Text == "admin")
                    {
                        if (pswdtb.Text == "admin")
                        {
                            MessageBox.Show("登录成功", "登录为管理员");
                        }
                        else
                        {
                            MessageBox.Show("密码错误");
                            pswdtb.Clear();
                            pswdtb.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("请输入正确的用户名", "用户名为\"admin\"");
                        usertb.Clear();
                        pswdtb.Clear();
                        usertb.Focus();
                    }
                }
                else if (guestrb.Checked)
                {
                    if (usertb.Text == "guest")
                    {
                        if (pswdtb.Text == "guest")
                        {
                            MessageBox.Show("登录成功", "登录为访客");
                        }
                        else
                        {
                            MessageBox.Show("密码错误");
                            pswdtb.Clear();
                            pswdtb.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("请输入正确的用户名", "用户名为\"guest\"");
                        usertb.Clear();
                        pswdtb.Clear();
                        usertb.Focus();
                    }

                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("请选择身份","没有选择身份");
                usertb.Clear();
                pswdtb.Clear();
                adminrb.Focus();
            }
        }
    }
}
