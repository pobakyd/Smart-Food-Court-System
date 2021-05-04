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
    public partial class fUser_History : Form
    {
        private Account loginAccount;
        public fUser_History(Account loginAccount)
        {
            InitializeComponent();
            this.LoginAccount = loginAccount;
            this.textBox_User_Name.Text = loginAccount.UserName;
            LoadUserHistory(loginAccount.UserName);
        }

        void LoadUserHistory(string userName)
        {
            this.dataGridView_History.DataSource = OrderFoodInfoDAO.Instance.GetUserHistory(userName);
        }
        public Account LoginAccount { get => loginAccount; set => loginAccount = value; }
    }
}
