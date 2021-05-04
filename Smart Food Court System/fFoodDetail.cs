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
    public partial class fFoodDetail : Form
    {
        private Food selectedFood;
        public fFoodDetail(Food selectedFood)
        {
            InitializeComponent();
            this.SelectedFood = selectedFood;
            LoadFoodDetail(this.SelectedFood);
        }

        public void LoadFoodDetail(Food seletcedFood)
        {
            this.textBox_Food_Name.Text = selectedFood.Name;
            this.textBox_Category.Text = FoodDAO.Instance.GetCategoryByFoodID(selectedFood.ID).Name;
            this.textBox_Price.Text = selectedFood.Price.ToString() + " VNĐ";
            this.textBox_Food_Detail.Text = selectedFood.FoodDetail;
            switch (FoodDAO.Instance.GetCourtByFoodID(selectedFood.ID))
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
        }
        public Food SelectedFood { get => selectedFood; set => selectedFood = value; }
    }
}
