using SmartFoodCourtSystem.DAO;
using SmartFoodCourtSystem.DTO;
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
    public partial class fLogin : Form
    {
        private int typeAccount_Court;
        private int typeAccount;

        public int TypeAccount_Court { get => typeAccount_Court; set => typeAccount_Court = value; }
        public int TypeAccount { get => typeAccount; set => typeAccount = value; }

        public fLogin(int typeAccount_Court, int typeAccount)
        {
            InitializeComponent();
            this.TypeAccount = typeAccount;
            this.TypeAccount_Court = typeAccount_Court;
            if (this.TypeAccount != 0)
            {
                this.button_Register.Enabled = false;
            }
        }
        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string passWord = txbPassWord.Text;
            if (Login(userName, passWord,TypeAccount_Court, TypeAccount))
            {
                Account loginAccount = AccountDAO.Instance.GetAccountByUserName(userName);
                if (TypeAccount_Court == 1 && TypeAccount != 0)
                {
                    fTableManager f = new fTableManager(loginAccount);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else if(TypeAccount_Court != 1 && TypeAccount==0)
                {
                    fUserInterface userInterface = new fUserInterface(loginAccount,TypeAccount_Court);
                    this.Hide();
                    userInterface.ShowDialog();
                    this.Show();
                }
                else if(this.TypeAccount_Court != 1 && TypeAccount != 0)
                {
                    fOrderManager orderManager = new fOrderManager(loginAccount, TypeAccount_Court);
                    this.Hide();
                    orderManager.ShowDialog();
                    this.Show();
                }
                this.txbUserName.Clear();
                this.txbPassWord.Clear();
                this.txbUserName.Focus();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }
        }

        bool Login(string userName, string passWord, int typeAccount_Court, int typeAccount)
        {
            return AccountDAO.Instance.Login(userName, passWord, typeAccount_Court, typeAccount);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }


        private void button_Dang_Ki_Click(object sender, EventArgs e)
        {
            fRegister register = new fRegister();
            this.Hide();
            register.ShowDialog();
            this.Show();
        }
    }
}
