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
    public partial class fWelcome : Form
    {
        public fWelcome()
        {
            InitializeComponent();
        }

        #region Events
        private void button_Quay_1_Click(object sender, EventArgs e)
        {
            fEntrance entrance = new fEntrance(1);
            this.Hide();
            entrance.ShowDialog();
            this.Show();
        }

        private void button_Quay_2_Click(object sender, EventArgs e)
        {
            fEntrance entrance = new fEntrance(2);
            this.Hide();
            entrance.ShowDialog();
            this.Show();
        }

        private void button_Quay_3_Click(object sender, EventArgs e)
        {
            fEntrance entrance = new fEntrance(3);
            this.Hide();
            entrance.ShowDialog();
            this.Show();
        }
        #endregion
    }
}
