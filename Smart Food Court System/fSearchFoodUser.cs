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
    public partial class fSearchFoodUser : Form
    {
        private int typeCourt;
        BindingSource foodList = new BindingSource();
        public fSearchFoodUser(int typeCourt)
        {
            InitializeComponent();
            this.TypeCourt = typeCourt;
            LoadDataFood(typeCourt);
            this.textBox_Food_Name.DataBindings.Add(new Binding("Text", this.dataGridView_Result.DataSource, "Tên món ăn", true, DataSourceUpdateMode.Never));
            switch (typeCourt)
            {
                case 1:
                    this.textBox_Court.Text = "The Canteen";
                    break;
                case 2:
                    this.textBox_Court.Text = "Green Mint";
                    break;
                case 3:
                    this.textBox_Court.Text = "The Rice";
                    break;
                default:
                    break;
            }
            this.textBox_Category.DataBindings.Add(new Binding("Text", this.dataGridView_Result.DataSource, "Loại", true, DataSourceUpdateMode.Never));
            this.textBox_Price.DataBindings.Add(new Binding("Text", this.dataGridView_Result.DataSource, "Đơn giá", true, DataSourceUpdateMode.Never));
            this.textBox_Detail.DataBindings.Add(new Binding("Text", this.dataGridView_Result.DataSource, "Mô tả", true, DataSourceUpdateMode.Never));
        }

        void LoadDataFood(int typeCourt)
        {
            this.foodList.DataSource = FoodDAO.Instance.GetListFood(typeCourt);
            this.dataGridView_Result.DataSource = foodList;
        }
        public int TypeCourt { get => typeCourt; set => typeCourt = value; }

        private void button_Search_Click(object sender, EventArgs e)
        {
            this.foodList.DataSource = FoodDAO.Instance.SearchFoodByName(this.textBox_Search.Text, this.typeCourt);
            this.dataGridView_Result.DataSource = foodList;
        }
    }
}
