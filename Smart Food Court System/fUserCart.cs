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
    public partial class fUserCart : Form
    {
        private Account loginAccount;
        private int typeCourt;
        public fUserCart(Account loginAccount, int typeCourt)
        {
            InitializeComponent();
            this.LoginAccount = loginAccount;
            this.TypeCourt = typeCourt;
            LoadUserCart(loginAccount, typeCourt);
        }

        private void LoadUserCart(Account loginAccount, int typeCourt)
        {
            this.dataGridView_Cart.DataSource = OrderFoodInfoDAO.Instance.GetUserCart(loginAccount.UserName, this.TypeCourt);
        }

        public Account LoginAccount { get => loginAccount; set => loginAccount = value; }
        public int TypeCourt { get => typeCourt; set => typeCourt = value; }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Delete_Order_Click(object sender, EventArgs e)
        {
            if (this.dataGridView_Cart.Rows.Count == 1)
            {
                MessageBox.Show("Không có đơn hàng nào để xóa");
            }
            else if (this.dataGridView_Cart.SelectedCells.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn đơn hàng để xóa");
            }
            else
            {
                int idOrder = int.Parse(this.dataGridView_Cart.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString());
                if (OrderFoodInfoDAO.Instance.DeleteOrderFoodByID(idOrder))
                {
                    MessageBox.Show("Xóa đơn hàng có ID " + idOrder.ToString() + " thành công");
                    LoadUserCart(this.LoginAccount, this.TypeCourt);
                }
            }
            
        }

        private void button_Order_Click(object sender, EventArgs e)
        {
            if (this.dataGridView_Cart.Rows.Count == 1)
            {
                MessageBox.Show("Không có món ăn nào để đặt hàng");
            }
            else
            {
                for (int i = 0; i < this.dataGridView_Cart.Rows.Count-1; i++)
                {
                    int id = int.Parse(this.dataGridView_Cart.Rows[i].Cells["ID"].Value.ToString());
                    OrderFoodDAO.Instance.OrderFoodByUser(id, this.TypeCourt);
                }
                MessageBox.Show("Đã đặt hàng thành công, hãy đến quầy nhận món ăn và thanh toán nhé");
                LoadUserCart(this.LoginAccount, this.TypeCourt);
            }
            
        }
    }
}
