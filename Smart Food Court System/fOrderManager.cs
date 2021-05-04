using SmartFoodCourtSystem.DAO;
using SmartFoodCourtSystem.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartFoodCourtSystem
{
    public partial class fOrderManager : Form
    {
        private Account loginAccount;
        private int typeCourt;
        public fOrderManager(Account loginAccount, int typeCourt)
        {
            InitializeComponent();
            this.loginAccount = loginAccount;
            this.typeCourt = typeCourt;
            this.textBox_User_Name.Text = loginAccount.DisplayName;
            LoadOrder(this.typeCourt);
            LoadDataFood();
            if (this.loginAccount.Type != 2)
            {
                this.quảnLýToolStripMenuItem.Enabled = false;
            }
        }

        private void LoadDataFood()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            this.comboBox_Category.DataSource = listCategory;
            this.comboBox_Category.DisplayMember = "Name";
        }
        private void LoadOrder(int typeCourt)
        {
            this.flowLayoutPanel_Order.Controls.Clear();
            List<OrderFood> listOrder = OrderFoodDAO.Instance.GetOrderFoodByCourt(this.typeCourt);
            if (listOrder != null)
            {
                foreach (OrderFood item in listOrder)
                {
                    Button button = new Button() { Width = 100, Height = 100 };
                    button.BackgroundImage = Properties.Resources.order;
                    button.BackgroundImageLayout = ImageLayout.Stretch;
                    button.Click += Button_Click;
                    button.Tag = item;
                    this.flowLayoutPanel_Order.Controls.Add(button);
                }
            }

        }

        private void Button_Click(object sender, EventArgs e)
        {
            float totalPrice = 0;
            this.listView_Order_Info.Items.Clear();
            OrderFood orderFood = (sender as Button).Tag as OrderFood;
            int idOrder = orderFood.ID;
            DataTable data = OrderFoodInfoDAO.Instance.GetOrderFoodInfoByID(idOrder);
            foreach (DataRow item in data.Rows)
            {
                ListViewItem viewItem = new ListViewItem(item["id"].ToString());
                viewItem.SubItems.Add(item["UserName"].ToString());
                viewItem.SubItems.Add(item["DateOrder"].ToString());
                viewItem.SubItems.Add(item["name"].ToString());
                viewItem.SubItems.Add(item["amount"].ToString());
                viewItem.SubItems.Add(item["price"].ToString());
                viewItem.SubItems.Add(item["Thành tiền"].ToString());
                totalPrice = float.Parse(item["Thành tiền"].ToString());
                this.textBox_User_Mess.Text = item["userMess"].ToString();
                this.listView_Order_Info.Items.Add(viewItem);
            }

            CultureInfo culture = new CultureInfo("vi-VN");

            //Thread.CurrentThread.CurrentCulture = culture;

            this.textBox_Total_Price.Text = totalPrice.ToString("c", culture);

        }

        private void textBox_Mess_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBox_Mess.Clear();
            this.textBox_Mess.ForeColor = Color.Black;
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fOrderManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn đăng xuất ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        private void LoadFoodListByCategoryID(int id, int typeCourt)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id, typeCourt);
            this.comboBox_Food.DataSource = listFood;
            this.comboBox_Food.DisplayMember = "Name";
        }
        private void comboBox_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            Category selected = cb.SelectedItem as Category;
            id = selected.ID;

            LoadFoodListByCategoryID(id, this.typeCourt);
        }

        private void button_Send_Mess_Click(object sender, EventArgs e)
        {
            if (this.listView_Order_Info.Items.Count == 0)
            {
                MessageBox.Show("Chưa chọn người dùng để nhận tin nhắn");

            }
            else if (this.textBox_Mess.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập nội dung tin nhắn");
            }
            else
            {
                string userName = this.listView_Order_Info.Items[0].SubItems[1].Text;
                string mess = this.textBox_Mess.Text;
                if (UserMessDAO.Instance.SendMess(userName, mess))
                {
                    MessageBox.Show("Bạn đã gửi tin nhắn đến người dùng " + userName + " thành công !");
                    this.textBox_Mess.Text = "";
                }
            }
        }

        private void button_Add_Food_Click(object sender, EventArgs e)
        {
            if (this.listView_Order_Info.Items.Count == 0)
            {
                MessageBox.Show("Không có hóa đơn nào để thêm món ăn");
            }
            else
            {
                string foodName = this.comboBox_Food.Text;
                int idFood = FoodDAO.Instance.GetIDFoodByName(foodName, this.typeCourt);
                int amount = int.Parse(this.numericUpDown_Amount.Value.ToString());
                string userName = this.listView_Order_Info.Items[0].SubItems[1].Text;
                List<Food> listFood = FoodDAO.Instance.GetFoodByIDFood(idFood, this.typeCourt);
                OrderFoodDAO.Instance.InsertOrderFoodByStaff(userName,this.typeCourt);
                int idOrder=OrderFoodInfoDAO.Instance.GetMaxIDFoodOrder();
                OrderFoodInfoDAO.Instance.InsertOrderFoodInfoByUser(idOrder, idFood, amount, "");
                ListViewItem viewItem = new ListViewItem(idOrder.ToString());
                viewItem.SubItems.Add(userName);
                viewItem.SubItems.Add(DateTime.Now.ToString());
                viewItem.SubItems.Add(foodName);
                viewItem.SubItems.Add(amount.ToString());
                viewItem.SubItems.Add(listFood[0].Price.ToString());
                viewItem.SubItems.Add((amount * listFood[0].Price).ToString());
                this.listView_Order_Info.Items.Add(viewItem);
                CultureInfo culture = new CultureInfo("vi-VN");
                float totalPrice = 0;
                foreach (ListViewItem item in this.listView_Order_Info.Items)
                {
                    totalPrice += float.Parse(item.SubItems[6].Text);
                }
                //Thread.CurrentThread.CurrentCulture = culture;
                this.textBox_Total_Price.Text = totalPrice.ToString("c", culture);
                
            }
        }

        private void button_Complete_Click(object sender, EventArgs e)
        {
            if (this.listView_Order_Info.Items.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn đơn hàng để hoàn thành");
            }
            else
            {
                string userName = "";
                foreach (ListViewItem item in this.listView_Order_Info.Items)
                {
                    int idOrder = int.Parse(item.SubItems[0].Text);
                    userName = item.SubItems[1].Text;
                    OrderFoodDAO.Instance.CompleteOrderByStaff(idOrder);
                }
                MessageBox.Show("Đơn hàng cho người dùng '" + userName + "' đã hoàn thành !!");
                this.listView_Order_Info.Items.Clear();
                this.textBox_Total_Price.Text = "";
                LoadOrder(this.typeCourt);
            }
            
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin(this.typeCourt);
            f.loginAccount = this.loginAccount;
            f.InsertFood += f_InsertFood;
            f.DeleteFood += f_DeleteFood;
            f.UpdateFood += f_UpdateFood;
            f.ShowDialog();
        }
        void f_UpdateFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((this.comboBox_Category.SelectedItem as Category).ID);
            if (this.listView_Order_Info.Tag != null)
                ShowOrder((this.listView_Order_Info.Tag as Table).ID);
        }

        void f_DeleteFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((this.comboBox_Category.SelectedItem as Category).ID);
            if (this.listView_Order_Info.Tag != null)
                ShowOrder((this.listView_Order_Info.Tag as Table).ID);
            LoadOrder(this.typeCourt);
        }

        void f_InsertFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((this.comboBox_Category.SelectedItem as Category).ID);
            if (this.listView_Order_Info.Tag != null)
                ShowOrder((this.listView_Order_Info.Tag as Table).ID);
        }
        void LoadFoodListByCategoryID(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id, 1);
            this.comboBox_Food.DataSource = listFood;
            this.comboBox_Food.DisplayMember = "Name";
        }
        void ShowOrder(int id)
        {
            this.listView_Order_Info.Items.Clear();
            float totalPrice = 0;
            DataTable data = OrderFoodInfoDAO.Instance.GetOrderFoodInfoByID(id);
            foreach (DataRow item in data.Rows)
            {
                ListViewItem viewItem = new ListViewItem(item["id"].ToString());
                viewItem.SubItems.Add(item["UserName"].ToString());
                viewItem.SubItems.Add(item["DateOrder"].ToString());
                viewItem.SubItems.Add(item["name"].ToString());
                viewItem.SubItems.Add(item["amount"].ToString());
                viewItem.SubItems.Add(item["price"].ToString());
                viewItem.SubItems.Add(item["Thành tiền"].ToString());
                totalPrice = float.Parse(item["Thành tiền"].ToString());
                this.textBox_User_Mess.Text = item["userMess"].ToString();
                this.listView_Order_Info.Items.Add(viewItem);
            }

            CultureInfo culture = new CultureInfo("vi-VN");

            //Thread.CurrentThread.CurrentCulture = culture;

            this.textBox_Total_Price.Text = totalPrice.ToString("c", culture);

        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile fAccount = new fAccountProfile(this.loginAccount);
            fAccount.ShowDialog();
        }
    }
}

