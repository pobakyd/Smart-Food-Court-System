using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartFoodCourtSystem
{
    public partial class fEntrance : Form
    {
        private int typeAccount_Court;
        private int typeAccount;

        public int TypeAccount_Court { get => typeAccount_Court; set => typeAccount_Court = value; }
        public int TypeAccount { get => typeAccount; set => typeAccount = value; }

        public fEntrance(int number)
        {
            InitializeComponent();
            this.TypeAccount_Court = number;
            switch (number)
            {
                case 1:
                    this.label_Chao_Mung.Text = "Chào mừng đến với The Canteen";
                    this.label_Chao_Mung.ForeColor = Color.Red;
                    this.pictureBox.Image = Properties.Resources.quay_1_image;
                    break;
                case 2:
                    this.label_Chao_Mung.Text = "Chào mừng đến với Green Mint";
                    this.label_Chao_Mung.ForeColor = Color.YellowGreen;
                    this.pictureBox.Image = Properties.Resources.quay_2_image;
                    break;
                case 3:
                    this.label_Chao_Mung.Text = "Chào mừng đến với The Rice";
                    this.label_Chao_Mung.ForeColor = Color.Gold;
                    this.pictureBox.Image = Properties.Resources.quay_3_image;
                    break;
                default:
                    break;
            }
            
        }

        #region Events
        private void button_Thuc_Khach_Click(object sender, EventArgs e)
        {
            this.TypeAccount = 0;
            fLogin login = new fLogin(TypeAccount_Court, TypeAccount);
            this.Hide();
            login.ShowDialog();
            this.Show();
        }

        private void button_Nhan_Vien_Click(object sender, EventArgs e)
        {
            this.TypeAccount = 1;
            fLogin login = new fLogin(TypeAccount_Court, TypeAccount);
            this.Hide();
            login.ShowDialog();
            this.Show();
        }

        private void button_Quan_Li_Click(object sender, EventArgs e)
        {
            this.TypeAccount = 2;
            fLogin login = new fLogin(TypeAccount_Court, TypeAccount);
            this.Hide();
            login.ShowDialog();
            this.Show();
        }
        #endregion

      
    }
}
