using LINQTOSQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.QLCHBTRASUATableAdapters;
using Main;

namespace GUI
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_user.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống" + lbl_user.Text.ToLower());
                this.txt_user.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txt_pass.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống" + lbl_pass.Text.ToLower());
                this.txt_pass.Focus();
                return;
            }
            if (IsvalidUser(txt_user.Text, txt_pass.Text))
            {
                MainForm a = new MainForm();
                this.Hide();
                a.ShowDialog();
                a.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu đã sai");
            }
        }
            private bool IsvalidUser(string userName, string password)
        {
            QLCHBANTRASUADataContext context = new QLCHBANTRASUADataContext();
            var q = from p in context.AccountDs
                    where p.userName == txt_user.Text
                    && p.password == txt_pass.Text
                    select p;
            if (q.Any())
            {

                return true;

            }

            else
            {

                return false;

            }
            
        }
     }
 }
