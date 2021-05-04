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
    public partial class fUser_Mess : Form
    {
        private Account loginAccount;
        public fUser_Mess(Account loginAccount)
        {
            InitializeComponent();
            this.LoginAccount = loginAccount;
            this.textBox_Mess.Text = UserMessDAO.Instance.GetUserMess(this.LoginAccount.UserName);
        }

        public Account LoginAccount { get => loginAccount; set => loginAccount = value; }
    }
}
