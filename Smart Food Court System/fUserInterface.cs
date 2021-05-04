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
    public partial class fUserInterface : Form
    {
        private Account loginAccount;
        private int typeCourt;
        public fUserInterface(Account loginAccount, int typeCourt)
        {
            InitializeComponent();
            this.LoginAccount = loginAccount;
            this.TypeCourt = typeCourt;
            this.textBox_Display_Name.Text = loginAccount.DisplayName;
            LoadAmountMess();
        }

        public void LoadAmountMess()
        {
            int amount = UserMessDAO.Instance.GetAmountUserMess(this.LoginAccount.UserName);
            this.tinNhắnToolStripMenuItem.Text = "Tin nhắn (" + amount.ToString() + ")";
        }
        public Account LoginAccount { get => loginAccount; set => loginAccount = value; }
        public int TypeCourt { get => typeCourt; set => typeCourt = value; }

        private void giỏHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fUserCart userCart = new fUserCart(LoginAccount,this.TypeCourt);
            this.Hide();
            userCart.ShowDialog();
            this.Show();
        }

        private void tinNhắnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserMessDAO.Instance.GetAmountUserMess(this.LoginAccount.UserName) == 0)
            {
                MessageBox.Show("Bạn không có tin nhắn nào chưa xem");
            }
            else
            {
                fUser_Mess userMess = new fUser_Mess(LoginAccount);
                userMess.ShowDialog();
                LoadAmountMess();
            }
            
        }

        private void lịchSửGiaoDịchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fUser_History user_History = new fUser_History(LoginAccount);
            
            user_History.ShowDialog();
            
        }


        private void button_Banh_Mi_Click(object sender, EventArgs e)
        {
            fOrderFood orderFood = new fOrderFood(1, TypeCourt, this.LoginAccount);
            this.Hide();
            orderFood.ShowDialog();
            this.Show();
        }

        private void button_Giai_Khat_Click(object sender, EventArgs e)
        {
            fOrderFood orderFood = new fOrderFood(2, TypeCourt, this.LoginAccount);
            this.Hide();
            orderFood.ShowDialog();
            this.Show();
        }

        private void button_An_Nhanh_Click(object sender, EventArgs e)
        {
            fOrderFood orderFood = new fOrderFood(3, TypeCourt, this.LoginAccount);
            this.Hide();
            orderFood.ShowDialog();
            this.Show();
        }

        private void button_Tra_Sua_Click(object sender, EventArgs e)
        {
            fOrderFood orderFood = new fOrderFood(4, TypeCourt, this.LoginAccount);
            this.Hide();
            orderFood.ShowDialog();
            this.Show();
        }

        private void button_Com_Click(object sender, EventArgs e)
        {
            fOrderFood orderFood = new fOrderFood(5, TypeCourt, this.LoginAccount);
            this.Hide();
            orderFood.ShowDialog();
            this.Show();
        }

        private void button_Bun_Click(object sender, EventArgs e)
        {
            fOrderFood orderFood = new fOrderFood(6, TypeCourt, this.LoginAccount);
            this.Hide();
            orderFood.ShowDialog();
            this.Show();
        }

        private void button_New_Click(object sender, EventArgs e)
        {
            fOrderFood orderFood = new fOrderFood(7, TypeCourt, this.LoginAccount);
            this.Hide();
            orderFood.ShowDialog();
            this.Show();
        }

        private void button_Tim_Kiem_Click(object sender, EventArgs e)
        {
            fSearchFoodUser fSearch = new fSearchFoodUser(this.typeCourt);
            fSearch.ShowDialog();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile accountProfile = new fAccountProfile(LoginAccount);
            accountProfile.ShowDialog();
            
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fUserInterface_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn đăng xuất?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
