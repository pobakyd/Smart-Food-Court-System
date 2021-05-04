using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFoodCourtSystem.DTO
{
    public class OrderFood
    {
        private int iD;
        private DateTime dateOrder;
        private DateTime? datePay;
        private string userName;
        private int typeCourt;
        private int statusOrder;
        private int statusPay;

        public OrderFood(int id, DateTime dateOrder, DateTime? datePay, string userName,int typeCourt, int statusOrder, int statusPay)
        {
            this.ID = id;
            this.DateOrder = dateOrder;
            this.DatePay = datePay;
            this.UserName = userName;
            this.TypeCourt = typeCourt;
            this.StatusOrder = statusOrder;
            this.StatusPay = statusPay;
        }

        public OrderFood(DataRow row)
        {
            this.ID = (int)row["id"];
            this.DateOrder = (DateTime)row["DateOrder"];
            this.DatePay = (DateTime?)row["DatePay"];
            this.UserName = row["UserName"].ToString();
            this.TypeCourt = (int)row["TypeACourt"];
            this.StatusOrder = (int)row["StatusOrder"];
            this.StatusPay = (int)row["StatusPay"];
        }
        public int ID { get => iD; set => iD = value; }
        public DateTime DateOrder { get => dateOrder; set => dateOrder = value; }
        public DateTime? DatePay { get => datePay; set => datePay = value; }
        public string UserName { get => userName; set => userName = value; }
        public int StatusOrder { get => statusOrder; set => statusOrder = value; }
        public int StatusPay { get => statusPay; set => statusPay = value; }
        public int TypeCourt { get => typeCourt; set => typeCourt = value; }
    }
}
