using SmartFoodCourtSystem.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartFoodCourtSystem
{
    public partial class fRegister : Form
    {
        public fRegister()
        {
            InitializeComponent();
            this.comboBox_Court.SelectedIndex = 0;
        }

        private void button_Quay_Lai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát đăng kí?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }


        private void button_Nhap_Lai_Click(object sender, EventArgs e)
        {
            this.textBox_User_Name.Text = "";
            this.textBox_Display_Name.Text = "";
            this.textBox_Password.Text = "";
            this.textBox_ReEnter.Text = "";
            this.comboBox_Court.SelectedIndex = 0;
        }

        private void button_Dang_Ki_Click(object sender, EventArgs e)
        {
            if(this.textBox_User_Name.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập");
            }
            else if(this.textBox_Display_Name.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên hiển thị");
            }
            else if(this.textBox_Password.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu");
            }
            else if(this.textBox_ReEnter.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập lại mật khẩu");
            }
            else if(this.textBox_Password.Text != this.textBox_ReEnter.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không trùng khớp");
            }
            else if (AccountDAO.Instance.GetAccountExist(this.textBox_User_Name.Text) != 0)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại");
            }
            else
            {
                int typeCourt = this.comboBox_Court.SelectedIndex;
                if (AccountDAO.Instance.InsertNewAccount(this.textBox_User_Name.Text, this.textBox_Display_Name.Text, this.textBox_Password.Text, typeCourt, 0))
                {
                    MessageBox.Show("Tạo tài khoản thành công");
                    this.textBox_User_Name.Text = "";
                    this.textBox_Display_Name.Text = "";
                    this.textBox_Password.Text = "";
                    this.textBox_ReEnter.Text = "";
                    this.comboBox_Court.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Tạo tài khoản không thành công");
                }
            }
        }


        private void textBox_Ten_Dang_Nhap_Enter(object sender, EventArgs e)
        {
            this.textBox_User_Name.Text = "";
            this.textBox_User_Name.ForeColor = Color.Black;
        }

        private void textBox_Ten_Hien_Thi_Enter(object sender, EventArgs e)
        {
            this.textBox_Display_Name.Text = "";
            this.textBox_Display_Name.ForeColor = Color.Black;
        }

        private void textBox_Mat_Khau_Enter(object sender, EventArgs e)
        {
            this.textBox_Password.Text = "";
            this.textBox_Password.ForeColor = Color.Black;
        }

        private void textBox_Nhap_Lai_MK_Enter(object sender, EventArgs e)
        {
            this.textBox_ReEnter.Text = "";
            this.textBox_ReEnter.ForeColor = Color.Black;
        }
    }
}
