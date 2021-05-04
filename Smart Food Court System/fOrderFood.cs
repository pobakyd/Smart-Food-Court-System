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
    public partial class fOrderFood : Form
    {
        private Account loginAccount;
        private int typeFood;
        private int typeCourt;
        private Food selectedFood;
        private int count = 0;
        private float totalPrice = 0;
        public fOrderFood(int typeFood, int typeCourt, Account loginAccount)
        {
            InitializeComponent();
            this.TypeFood = typeFood;
            this.TypeCourt = typeCourt;
            this.LoginAccount = loginAccount;
            LoadFood(typeFood, typeCourt);
        }

        private void LoadFood(int typeFood, int typeCourt)
        {
            switch (typeFood)
            {
                case 1:
                    List<Food> listFood_1=FoodDAO.Instance.GetFoodByCategoryID(1, typeCourt);
                    int count_1 = 1;
                    foreach (Food item in listFood_1)
                    {
                        string imageName = "banhmi_" + count_1.ToString();
                        Button button = new Button { Width = 100, Height = 100 };
                        object image = Properties.Resources.ResourceManager.GetObject(imageName);
                        if (image == null)
                        {
                            button.BackgroundImage = Properties.Resources.new_food;
                        }
                        else
                        {
                            button.BackgroundImage = (Image)image;
                        }
                       
                        button.BackgroundImageLayout = ImageLayout.Stretch;
                        button.Click += Button_Click;
                        button.Tag = item;
                        this.flowLayoutPanel_Food.Controls.Add(button);
                        ++count_1;
                    }
                    break;
                case 2:
                    List<Food> listFood_2 = FoodDAO.Instance.GetFoodByCategoryID(2, typeCourt);
                    int count_2 = 1;
                    foreach (Food item in listFood_2)
                    {
                        string imageName = "giaikhat_" + count_2.ToString();
                        Button button = new Button { Width = 100, Height = 100 };
                        object image = Properties.Resources.ResourceManager.GetObject(imageName);
                        if (image == null)
                        {
                            button.BackgroundImage = Properties.Resources.new_food;
                        }
                        else
                        {
                            button.BackgroundImage = (Image)image;
                        }

                        button.BackgroundImageLayout = ImageLayout.Stretch;
                        button.Click += Button_Click;
                        button.Tag = item;
                        this.flowLayoutPanel_Food.Controls.Add(button);
                        ++count_2;
                    }
                    break;
                case 4:
                    List<Food> listFood_4 = FoodDAO.Instance.GetFoodByCategoryID(4, typeCourt);
                    int count_4 = 1;
                    foreach (Food item in listFood_4)
                    {
                        string imageName = "trasua_" + count_4.ToString();
                        Button button = new Button { Width = 100, Height = 100 };
                        object image = Properties.Resources.ResourceManager.GetObject(imageName);
                        if (image == null)
                        {
                            button.BackgroundImage = Properties.Resources.new_food;
                        }
                        else
                        {
                            button.BackgroundImage = (Image)image;
                        }

                        button.BackgroundImageLayout = ImageLayout.Stretch;
                        button.Click += Button_Click;
                        button.Tag = item;
                        this.flowLayoutPanel_Food.Controls.Add(button);
                        ++count_4;
                    }
                    break;
                case 5:
                    List<Food> listFood_5 = FoodDAO.Instance.GetFoodByCategoryID(6, typeCourt);
                    int count_5 = 1;
                    foreach (Food item in listFood_5)
                    {
                        string imageName = "com_" + count_5.ToString();
                        Button button = new Button { Width = 100, Height = 100 };
                        object image = Properties.Resources.ResourceManager.GetObject(imageName);
                        if (image == null)
                        {
                            button.BackgroundImage = Properties.Resources.new_food;
                        }
                        else
                        {
                            button.BackgroundImage = (Image)image;
                        }

                        button.BackgroundImageLayout = ImageLayout.Stretch;
                        button.Click += Button_Click;
                        button.Tag = item;
                        this.flowLayoutPanel_Food.Controls.Add(button);
                        ++count_5;
                    }
                    break;
                case 6:
                    List<Food> listFood_6 = FoodDAO.Instance.GetFoodByCategoryID(7, typeCourt);
                    int count_6 = 1;
                    foreach (Food item in listFood_6)
                    {
                        string imageName = "bun_" + count_6.ToString();
                        Button button = new Button { Width = 100, Height = 100 };
                        object image = Properties.Resources.ResourceManager.GetObject(imageName);
                        if (image == null)
                        {
                            button.BackgroundImage = Properties.Resources.new_food;
                        }
                        else
                        {
                            button.BackgroundImage = (Image)image;
                        }

                        button.BackgroundImageLayout = ImageLayout.Stretch;
                        button.Click += Button_Click;
                        button.Tag = item;
                        this.flowLayoutPanel_Food.Controls.Add(button);
                        ++count_6;
                    }
                    break;
                case 3:
                    List<Food> listFood_3 = FoodDAO.Instance.GetFoodByCategoryID(3, typeCourt);
                    int count_3 = 1;
                    foreach (Food item in listFood_3)
                    {
                        string imageName = "annhanh_" + count_3.ToString();
                        Button button = new Button { Width = 100, Height = 100 };
                        object image = Properties.Resources.ResourceManager.GetObject(imageName);
                        if (image == null)
                        {
                            button.BackgroundImage = Properties.Resources.new_food;
                        }
                        else
                        {
                            button.BackgroundImage = (Image)image;
                        }

                        button.BackgroundImageLayout = ImageLayout.Stretch;
                        button.Click += Button_Click;
                        button.Tag = item;
                        this.flowLayoutPanel_Food.Controls.Add(button);
                        ++count_3;
                    }
                    break;
                default:
                    break;
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Food selectedFood = (sender as Button).Tag as Food;
            if (count == 0)
            {
                this.SelectedFood = selectedFood;
                ++count;
            }
            else if (count == 1)
            {
                if (this.SelectedFood == selectedFood)
                {
                    fFoodDetail foodDetail = new fFoodDetail(selectedFood);
                    this.count = 0;
                    this.SelectedFood = null;
                    
                    foodDetail.Show();
                    
                    
                }
                else
                {
                    this.SelectedFood = selectedFood;
                }
            }

        }

        public int TypeFood { get => typeFood; set => typeFood = value; }
        public int TypeCourt { get => typeCourt; set => typeCourt = value; }
        public Food SelectedFood { get => selectedFood; set => selectedFood = value; }
        public Account LoginAccount { get => loginAccount; set => loginAccount = value; }

        private void textBox_User_Mess_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBox_User_Mess.Text = "";
            this.textBox_User_Mess.ForeColor = Color.Black;
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fOrderFood_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn thoát đặt hàng ?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Information) != System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void button_Add_Food_Click(object sender, EventArgs e)
        {
            if (this.SelectedFood == null)
            {
                MessageBox.Show("Bạn chưa chọn món");
            }
            else
            {
                if (this.listView_Order.Items.Count == 0)
                {
                    ListViewItem listViewItem = new ListViewItem(this.SelectedFood.Name);
                    listViewItem.SubItems.Add(this.SelectedFood.Price.ToString());
                    listViewItem.SubItems.Add(this.numericUpDown_Amount.Value.ToString());
                    listViewItem.SubItems.Add((this.SelectedFood.Price * int.Parse(this.numericUpDown_Amount.Value.ToString())).ToString());
                    this.listView_Order.Items.Add(listViewItem);
                    this.totalPrice += float.Parse(listViewItem.SubItems[3].Text);
                    CultureInfo culture = new CultureInfo("vi-VN");
                    this.textBox_Total_Price.Text = this.totalPrice.ToString("c",culture);
                }
                else
                {
                    bool exist = false;
                    foreach (ListViewItem item in this.listView_Order.Items)
                    {
                        if (item.Text == selectedFood.Name)
                        {
                            exist = true;
                            int amount= int.Parse(item.SubItems[2].Text)+ int.Parse(this.numericUpDown_Amount.Value.ToString());
                            item.SubItems[2].Text = amount.ToString();
                            item.SubItems[3].Text = (amount * float.Parse(item.SubItems[1].Text)+float.Parse(item.SubItems[3].Text)).ToString();
                            this.totalPrice += float.Parse(item.SubItems[3].Text);
                            CultureInfo culture = new CultureInfo("vi-VN");
                            this.textBox_Total_Price.Text = this.totalPrice.ToString("c", culture);
                        }
                    }
                    if (exist == false)
                    {
                        ListViewItem listViewItem = new ListViewItem(this.SelectedFood.Name);
                        listViewItem.SubItems.Add(this.SelectedFood.Price.ToString());
                        listViewItem.SubItems.Add(this.numericUpDown_Amount.Value.ToString());
                        listViewItem.SubItems.Add((this.SelectedFood.Price * int.Parse(this.numericUpDown_Amount.Value.ToString())).ToString());
                        this.listView_Order.Items.Add(listViewItem);
                        this.totalPrice += float.Parse(listViewItem.SubItems[3].Text);
                        CultureInfo culture = new CultureInfo("vi-VN");
                        this.textBox_Total_Price.Text = this.totalPrice.ToString("c", culture);
                    }
                }
                this.numericUpDown_Amount.Value = 1;
                this.count = 0;
                this.SelectedFood = null;
            }
        }

        private void button_Add_Cart_Click(object sender, EventArgs e)
        {
            if (this.listView_Order.Items.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn món ăn nào để thêm vào giỏ hàng");
            }
            else
            {
                foreach (ListViewItem item in this.listView_Order.Items)
                {
                    int idFood = FoodDAO.Instance.GetIDFoodByName(item.SubItems[0].Text, this.TypeCourt);
                    int amount = int.Parse(item.SubItems[2].Text);
                    string userMess = this.textBox_User_Mess.Text;
                    if (OrderFoodDAO.Instance.InsertOrderFoodByUser(this.LoginAccount.UserName, this.typeCourt))
                    {
                        int idOrderFood = OrderFoodInfoDAO.Instance.GetMaxIDFoodOrder();
                        OrderFoodInfoDAO.Instance.InsertOrderFoodInfoByUser(idOrderFood, idFood, amount, userMess);
                    }
                }
                this.listView_Order.Items.Clear();
                this.textBox_Total_Price.Clear();
                this.textBox_User_Mess.Clear();
                MessageBox.Show("Đã thêm món ăn vào giỏ hàng thành công");

            }
        }

        private void button_Delete_Food_Click(object sender, EventArgs e)
        {
            if (this.listView_Order.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn món để xóa");
            }
            else
            {
                this.listView_Order.Items.Remove(this.listView_Order.SelectedItems[0]);
            }
            
        }
    }
}
